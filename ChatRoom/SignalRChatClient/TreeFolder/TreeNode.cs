using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRChatClient
{
    class TreeNode : INode
    {
        string id = " ";
        public string ID { get => id; set => id = value; }

        string content = " ";
        public string Content { get => content; set => content = value; }

        bool isReady = false;
        public bool IsReady { get => isReady; set => isReady = value; }

        INode parent = null;
        public INode Parent { get => parent; set => parent = value; }


        List<TreeNode> INode.Children { get => children; set => children = value; }

        List<TreeNode> children = new List<TreeNode>();
 

        public TreeNode(string ID, string Content, bool IsReady, INode Parent)
        {
            this.ID = ID;
            this.Content = Content;
            this.IsReady = IsReady;
            this.Parent = Parent;

            if (Parent != null)
            {
                Parent.Children.Add(this);
            }
        }
    }
}
