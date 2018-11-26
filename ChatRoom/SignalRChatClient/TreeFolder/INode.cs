using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRChatClient
{
    interface INode
    {
        
        string ID { get; set; }

        string Content { get; set; }

        bool IsReady { get; set; }
        INode Parent { get; set; }
        List<TreeNode> Children { get; set; }

        
    }
}
