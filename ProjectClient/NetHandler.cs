using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ProjectClient
{
    internal static class NetHandler
    {
        //tcp details
        private static TcpClient Client;
        private static string _clientIP = "127.0.0.1";
        private static int _clientPort = 500;
        // used for sending and reciving data
        private static byte[] data;

        private static RsaHandler Rsa;
        private static string ServerPublicKey;
        private static string PrivateKey;

        public static string SymmetricKey;

        public static bool Connect(string ip)
        {
            Client = new TcpClient();
            try
            {
                Client.Connect(ip, 500); //todo - to change the server ip to my computer ip
            }
            catch
            {
                MessageBox.Show("There wasn't a server in this address...\nPlease Try Again", "Server Connection Attempt");
            }

            Rsa = new RsaHandler();
            PrivateKey = Rsa.GetPrivateKey();
            SendMessage("public key:" + Rsa.GetPublicKey());
            if (!Client.Connected)
                return false;
            data = new byte[Client.ReceiveBufferSize];
            // BeginRead will begin async read from the NetworkStream
            // This allows the server to remain responsive and continue accepting new connections from other clients
            // When reading complete control will be transfered to the ReviveMessage() function.
            Client.GetStream().BeginRead(data,
                                          0,
                                          System.Convert.ToInt32(Client.ReceiveBufferSize),
                                          ReceiveMessage,
                                          null);
            return true;
        }
        private static ForgotPassForm ForgotInstance;
        private static LoginForm LoginInstance;
        private static SignUpForm SignUpInstance;
        private static HomeScreenForm HomeInstance;
        private static SettingsForm SettingsInstance;

        public static void BeginRead()
        {
            Client.GetStream().BeginRead(data,
                                                      0,
                                                      System.Convert.ToInt32(Client.ReceiveBufferSize),
                                                      ReceiveMessage, null);
        }
        // Initialize the form instance.
        internal static void InitializeForgotFormInstance(ForgotPassForm formInstance)
        {
            ForgotInstance = formInstance;
        }
        internal static void InitializeLoginFormInstance(LoginForm formInstance)
        {
            LoginInstance = formInstance;
        }
        internal static void InitializeSignUpFormInstance(SignUpForm formInstance)
        {
            SignUpInstance = formInstance;
        }
        internal static void InitializeHomeScreenFormInstance(HomeScreenForm formInstance)
        {
            HomeInstance = formInstance;
        }
        internal static void InitializeSettingsFormInstance(SettingsForm formInstance)
        {
            SettingsInstance = formInstance;
        }


        //delegates

        internal static void ShowPass()
        {
            if (ForgotInstance != null)
            {
                ForgotInstance.Invoke((Action)(() => ForgotInstance.ShowNewPass()));
            }
        }
        internal static void LockLogin()
        {
            if (LoginInstance != null)
            {
                LoginInstance.Invoke((Action)(() => LoginInstance.DisableAll()));
            }
        }
        internal static void UnlockLogin()
        {
            if (LoginInstance != null)
            {
                LoginInstance.Invoke((Action)(() => LoginInstance.EnableAll()));
            }
        }
        internal static void CreateAndShowHome()
        {
            LoginInstance.Invoke((Action)(() => LoginInstance.CreateAndShowHomeForm()));
        }
        internal static void UnlockSettings()
        {
            SettingsInstance.Invoke((Action) (() => SettingsInstance.UnlockSettings()));
        }



        public static void SendMessage(string message)
        {

            try
            {
                System.Net.Sockets.NetworkStream ns;


                // use lock to present multiple threads from using the networkstream object
                // this is likely to occur when the server is connected to multiple clients all of 
                // them trying to access to the networkstram at the same time.
                lock (Client.GetStream())
                {
                    ns = Client.GetStream();
                }
                if (!message.StartsWith("public key:"))
                {
                    byte[] Key = Encoding.UTF8.GetBytes(SymmetricKey);
                    byte[] IV = new byte[16];
                    message = AES.Encrypt(message, Key, IV);

                }

                // Send data to the client
                byte[] bytesToSend = System.Text.Encoding.ASCII.GetBytes(message);
                ns.Write(bytesToSend, 0, bytesToSend.Length);
                ns.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// reciev and handel incomming streem 
        /// Asynchrom
        /// </summary>
        /// <param name="ar">IAsyncResult Interface</param>
        public static void ReceiveMessage(IAsyncResult ar)
        {
            
            try
            {
                int bytesRead;
                
                // call EndRead to handle the end of an async read.
                bytesRead = Client.GetStream().EndRead(ar);
                
                // if bytesread<1 -> the client disconnected
                if (bytesRead < 1)
                {
                    // remove the client from out list of clients

                    return;
                }
                else // client still connected
                {
                    string messageReceived = System.Text.Encoding.ASCII.GetString(data, 0, bytesRead);
                    // if the client is sending its nickname
                    if (messageReceived.StartsWith("*"))
                    {
                        messageReceived = messageReceived.Remove(0, 1);

                        ServerPublicKey = messageReceived; //maybe i should make the publickey as bytes and not string and then do the switch to string just after that...  
                    }
                    else if (messageReceived.StartsWith("$"))//gets Symmetrical Key
                    {
                        messageReceived = messageReceived.Remove(0, 1);
                        string DecryptedMessageDetails = Rsa.Decrypt(messageReceived, PrivateKey);
                        SymmetricKey = DecryptedMessageDetails;
                    }
                    else
                    {
                        byte[] Key = Encoding.UTF8.GetBytes(SymmetricKey);
                        byte[] IV = new byte[16];
                        messageReceived = AES.Decrypt(messageReceived, Key, IV);

                        if (messageReceived == "In The Database") //If login valid.
                        {
                            //CreateAndShowType();
                            CreateAndShowHome();
                        }
                        if (messageReceived == "Not In The Database") //If login not valid.
                        {
                            MessageBox.Show("Invalid.");
                        }
                        if(messageReceived == "CheckUserValidSignUp")
                        {
                            string userDetails = SignUpInstance.getUserDetails();
                            SendMessage("Up" + userDetails);
                            SignUpInstance.Invoke((Action)(() => SignUpInstance.ShowCode()));
                        }
                        if (messageReceived == "CheckUserValid")
                        {
                            SettingsInstance.isUsernameValid = true;
                        }
                        if (messageReceived == "CheckUserInvalid")
                        {
                            MessageBox.Show("Invalid username. please try different one.");
                        }
                        if (messageReceived == "Signed Up") //If sign up valid.
                        {
                            //CreateAndShow();
                            CreateAndShowHome();
                        }
                        if(messageReceived == "Valid Code") //If smtp code valid.
                        {
                            ShowPass();
                        }
                        if(messageReceived == "Valid Code For Settings")
                        {
                            UnlockSettings();
                        }
                        if(messageReceived == "ban") //If tried to hack.
                        {
                            LockLogin();
                        }
                        if(messageReceived == "UnBan") // Unban previous if.
                        {
                            UnlockLogin();
                        }
                        if(messageReceived.StartsWith("capt:"))
                        {
                            string capthca = messageReceived.Remove(0, 5);
                            SignUpInstance.Invoke((Action)(() => SignUpInstance.ShowCaptcha(capthca)));
                        }
                        if(messageReceived.StartsWith("UserType:"))
                        {
                            messageReceived = messageReceived.Remove(0, 9);

                        }
                        if(messageReceived.StartsWith("UserName:"))
                        {
                            messageReceived = messageReceived.Remove(0, 9);
                            HomeInstance.Invoke((Action)(() => HomeInstance.setUsername(messageReceived)));
                            SendMessage("GetLibraries");
                        }
                        if(messageReceived.StartsWith("lb:"))
                        {
                            HomeInstance.Invoke ((Action)(() => HomeInstance.InsertLibraries(messageReceived.Remove(0, 3))));
                        }
                        if(messageReceived.StartsWith("BooksToPreview"))
                        {
                            string[] bookDetails = messageReceived.Remove(0, 14).Split(',');
                            HomeInstance.Invoke((Action)(() => HomeInstance.setBook(bookDetails[0], bookDetails[1], bookDetails[2], bookDetails[3])));
                        }
                        
                    }
                }
                lock (Client.GetStream())
                {
                    // continue reading form the client
                    Client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(Client.ReceiveBufferSize), ReceiveMessage, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
