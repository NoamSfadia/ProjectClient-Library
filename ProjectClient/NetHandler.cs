using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
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

        private static string OverlapString;

        public static bool Connect(string ip)
        {
            Client = new TcpClient();
            try
            {
                Client.Connect(ip, 500); //todo - to change the server ip to my computer ip
            }
            catch
            {
                MessageBox.Show("The server is closed.\nPlease Try Again", "Server Connection Attempt");
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
        private static OrderscreenForm OrderscreenInstance;

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
        internal static void InitializeOrderFormInstance(OrderscreenForm formInstance)
        {
            OrderscreenInstance = formInstance;
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
                byte[] bytesToSend = System.Text.Encoding.ASCII.GetBytes(message + "!");
                int chunkSize = 60000; // Chunk size in bytes
                int bytesSent = 0;
                while (bytesSent < bytesToSend.Length)
                {
                    int remainingBytes = bytesToSend.Length - bytesSent;
                    int currentChunkSize = Math.Min(remainingBytes, chunkSize);
                    ns.Write(bytesToSend, bytesSent, currentChunkSize);
                    bytesSent += currentChunkSize;
                }

                ns.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

                    if (messageReceived.EndsWith("!"))
                    {
                        messageReceived = messageReceived.Remove(messageReceived.Length - 1);
                        messageReceived = OverlapString + messageReceived;
                        
                        OverlapString = "";
                    }
                    else
                    {
                        OverlapString += messageReceived;
                    }

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
                    else if (OverlapString == "")
                    {
                        byte[] Key = Encoding.UTF8.GetBytes(SymmetricKey);
                        byte[] IV = new byte[16];
                        messageReceived = AES.Decrypt(messageReceived, Key, IV);

                        if (messageReceived == "In The Database") //If login valid.
                        {                 
                            Task.Run(() => { MessageBox.Show("Check your mail for the code.");  });
                            LoginInstance.Invoke((Action)(() => LoginInstance.ShowMail()));
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
                            Task.Run(() => { MessageBox.Show("Invalid username. please try different one."); });     
                        }
                        
                        if (messageReceived == "Signed Up") //If sign up valid.
                        {
                            //CreateAndShow();
                            CreateAndShowHome();
                        }
                        if (messageReceived == "Signed In") //If login try valid and paseed the tests.
                        {
                            //CreateAndShow();
                            CreateAndShowHome();
                        }
                        
                        if (messageReceived == "Valid Code") //If smtp code valid.
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

                        if(messageReceived.StartsWith("captUp:"))
                        {
                            string capthca = messageReceived.Remove(0, 7);
                            SignUpInstance.Invoke((Action)(() => SignUpInstance.ShowCaptcha(capthca)));
                        }
                        if (messageReceived.StartsWith("captIn:"))
                        {
                            string capthca = messageReceived.Remove(0, 7);
                            LoginInstance.Invoke((Action)(() => LoginInstance.ShowCaptcha(capthca)));
                        }


                        if (messageReceived.StartsWith("UserType:"))
                        {
                            messageReceived = messageReceived.Remove(0, 9);
                            string UserType = messageReceived.Trim();
                            SettingsInstance.UserType = UserType;
                            if (UserType.Equals("Manager") || UserType.Equals("VManager"))
                            {
                                SettingsInstance.Invoke((Action)(() => SettingsInstance.ManagerPanelVisible()));
                                SendMessage("GetGenres");
                            }
                        }


                        if(messageReceived.StartsWith("UserTypeOrder:"))
                        {
                            string Type = messageReceived.Remove(0, 14).Trim();
                            if (Type.Equals("Manager") || Type.Equals("Librarian") || Type.Equals("VManager"))
                            {
                                OrderscreenInstance.Invoke((Action) (() => OrderscreenInstance.ShowLibrarianOptionsButton()));
                            }
                        }
                        if(messageReceived.StartsWith("OrderLibrary:"))
                        {

                            string[] strings = messageReceived.Remove(0, 13).Split(',');
                            string library = strings[0];
                            string[] bookAndQuantity = strings[1].Split('/');
                            if(!library.Equals("Does not relate to any library."))
                            {
                                OrderscreenInstance.Library = library;
                            }
                            OrderscreenInstance.Invoke((Action)(() => OrderscreenInstance.UpdateCurrentLabel(bookAndQuantity[1])));
                        }
                        if(messageReceived.StartsWith("ReturnDemandOrder"))
                        {
                            string[] AllLibraries = messageReceived.Remove(0,17).Split(',');
                            OrderscreenInstance.Libraries = AllLibraries.ToList();
                            foreach(string Library in AllLibraries) 
                            {
                                string[] LibraryAfterSpilt = Library.Split('/');
                                OrderscreenInstance.Invoke((Action)(() => OrderscreenInstance.LibrariesComboBox.Items.Add(LibraryAfterSpilt[0])));
                            }

                        }


                        if(messageReceived.StartsWith("UserName:"))
                        {
                            messageReceived = messageReceived.Remove(0, 9);
                            HomeInstance.Invoke((Action)(() => HomeInstance.setUsername(messageReceived)));
                            SendMessage("GetLibraries");
                        }
                        if(messageReceived.StartsWith("lb:"))
                        {
                            HomeInstance.Invoke((Action)(() => HomeInstance.InsertLibraries(messageReceived.Remove(0, 3))));
                            SendMessage("GetBooks:");
                        }
                        if(messageReceived.StartsWith("Genres:"))
                        {
                            SettingsInstance.Invoke((Action) ((() => SettingsInstance.insertGenres(messageReceived.Remove(0,7)))));
                        }
                        if(messageReceived.StartsWith("genresForHome:"))
                        {
                            string Genres = messageReceived.Remove(0, 14);
                            HomeInstance.Invoke((Action)((() => HomeInstance.InsertGenres(Genres))));
                        }
                        if(messageReceived.StartsWith("BooksToPreview:"))
                        {
                            messageReceived = messageReceived.Remove(0, 15);
                            HomeInstance.Invoke((Action)((() => HomeInstance.ResetBooks())));
                            HomeInstance.pageNumber = 0;
                            string[] AllBooks = messageReceived.Split('@');
                            for (int i = 0; i < AllBooks.Length; i++)
                            {
                                if(messageReceived != "None")
                                {
                                    string[] BookData = AllBooks[i].Split('$');
                                    BookDetails bookDetails = new BookDetails(BookData[0], BookData[1], BookData[2], BookData[3], BookData[4], BookData[5]);
                                    HomeInstance.Invoke((Action)(() => HomeInstance.setBook(BookData[0], BookData[1], BookData[2], BookData[3], BookData[4], BookData[5])));
                                }
                            }

                            HomeInstance.pageMax = AllBooks.Length/6;

                            SendMessage("getGenresForHome");
                        }
                        if(messageReceived == "SuccesfulRating")
                        {
                            Task.Run(() => { MessageBox.Show("The review has been successfully delivered! Thank you!"); });
                        }
                        if(messageReceived.StartsWith("UsersForSettings:"))
                        {
                            string[] AllUsers = messageReceived.Remove(0, 17).Split(',');
                            SettingsInstance.Invoke((Action)(() => SettingsInstance.insertUsers(AllUsers)));
                        }
                        
                        if(messageReceived.Equals("Confirmed"))
                        {
                            Task.Run(() => MessageBox.Show("Confirmed."));
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
        public static void Disconnect()
        {
            SendMessage("Disconnection In proccess");
            Client.Close();
            Client.GetStream().Close();
        }

    }
}
