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



        HubConnection connection;
        public MainWindow()
        {
            InitializeComponent();

            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chat")
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
            
            switch (messageTextBox.Text)
            {
                case "Add Local Node":
                    tree.AddNode(previousMessage);
                    break;
                case "Add Node:":
                    tree.AddNode(previousMessage);
                    messagesList.Items.Add("Add Local Node:");
                    messagesList.Items.Add(previousMessage);
                    break;
                case "Remove Node":
                    tree.DeleteNode(previousMessage);
                    messagesList.Items.Add("Remove Local Node:");
                    messagesList.Items.Remove(previousMessage);
                    break;
                case "Remove Local Node":
                    tree.DeleteNode(previousMessage);
                    break;
                case "Show Tree":
                    foreach (INode node in tree.branches)
                    {
                        messagesList.Items.Add(node.Content);
                    }
                    break;
                default:

                    break;
            }
        }

        private void userTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void messagesList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
#endregion
