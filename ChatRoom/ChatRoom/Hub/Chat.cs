// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.SignalR;

namespace Microsoft.Azure.SignalR.Samples.ChatRoom
{
    public class Chat : Hub
    {
        public void BroadcastMessage(string name, string message)
        {
            Clients.All.SendAsync("broadcastMessage", name, message);

            switch (message)
            {
                case "Add Node:":
                    tree.AddNode(message + i, null);
                    BroadcastMessage("Server", tree.branches.Count.ToString());
                    foreach (TreeNode branch in tree.branches)
                    {
                        BroadcastMessage("Server", branch.Content);
                    }

                    BroadcastMessage("Server", i++.ToString());
                    i++;
                    break;
                default:
                    break;
            }
        }

        public void Echo(string name, string message)
        {
            Clients.Client(Context.ConnectionId).SendAsync("echo", name, message + " (echo from server)");
        }
    }
}
