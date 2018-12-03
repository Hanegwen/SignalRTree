#region snippet_MainWindowClass
using System;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRChatClient
{
    public partial class MainWindow : Window
    {

        DataTree tree = new DataTree();
        string previousMessage = "";
        int i = 0;


        HubConnection connection;
        public MainWindow()
        {
            InitializeComponent();

            connection = new HubConnectionBuilder()
                .WithUrl("168.61.189.194")
                .Build();

            #region snippet_ClosedRestart
            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0,5) * 1000);
                await connection.StartAsync();
            };
            #endregion
        }

        private async void connectButton_Click(object sender, RoutedEventArgs e)
        {
            #region snippet_ConnectionOn
            connection.On<string, string>("broadcastMessage", (user, message) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                   var newMessage = $"{user}: {message}";
                   messagesList.Items.Add(newMessage);
                });
            });
            #endregion

            try
            {
                await connection.StartAsync();
                messagesList.Items.Add("Connection started");
                connectButton.IsEnabled = false;
                sendButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }

            
        }

        private async void sendButton_Click(object sender, RoutedEventArgs e)
        {
            #region snippet_ErrorHandling
            try
            {
                #region snippet_InvokeAsync
                await connection.InvokeAsync("BroadcastMessage", 
                    userTextBox.Text, messageTextBox.Text);
                #endregion
            }
            catch (Exception ex)
            {                
                messagesList.Items.Add(ex.Message);                
            }
            #endregion
        }

        private void userTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            switch (e)
            {
                case "Add Node:":
                    tree.AddNode(previousMessage);
                    //BroadcastMessage("Server", tree.branches.Count.ToString());
                    foreach (TreeNode branch in tree.branches)
                    {
                        //BroadcastMessage("Server", branch.Content);
                        //Clients.All.SendAsync("Server", branch.Content);
                    }

                    //BroadcastMessage("Server", i++.ToString());
                    //i++;
                    break;
                case "Remove Node":

                    break;

                default:

                    break;
            }
        }

        private void messagesList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
#endregion
