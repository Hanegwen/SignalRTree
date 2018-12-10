#region snippet_MainWindowClass
using System;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;

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
            //request.UserAgent = "Fiddler";
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chat")
                //.ConfigureLogging(logging => {
                //    logging.SetMinimumLevel(LogLevel.Information);
                //})
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
            sendButton.IsEnabled = true;
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
            int count;
            try
            {
                await connection.StartAsync();
                count = tree.branches.Capacity;
                messagesList.Items.Add("Connection started");
                connectButton.IsEnabled = false;
                sendButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                count = tree.branches.Capacity;
                messagesList.Items.Add(ex.Message);

            }

            
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string testString = messageTextBox.Text;
            switch (previousMessage)
            {

                case "Add Node:":
                    tree.AddNode(messageTextBox.Text);
                    messagesList.Items.Add(messageTextBox.Text);
                    
                    break;
                case "Remove Node":
                    tree.DeleteNode(messageTextBox.Text);
                    messagesList.Items.Remove(messageTextBox.Text);
                    
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

            previousMessage = messageTextBox.Text;
        }

        private void userTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void messagesList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void MessageTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
#endregion
