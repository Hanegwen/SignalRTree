using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRChatClient
{
    class DataTree
    {
        public List<INode> branches = new List<INode>();

        public int i = 0;
        public void WriteOutLineFile() //Done
        {
            List<string> finalList = new List<string>();
            for (int i = 0; i < branches.Count; i++)
            {
                finalList.Add(branches[i].Content.ToString());
                Console.WriteLine(finalList[i]);
            }

            //System.IO.File.WriteAllLines(@"E:\Columbia\Senior\Algorithms\TreeFinalData.txt", finalList);

            System.IO.File.WriteAllLines(@"C:\workspace\FinalTreeData.txt", finalList);
        }

        void MakeParents()
        {
            int whiteForLast = 100;
            
            for (int i = 0; i < branches.Count; i++)
            {
                //INode currentParent = branches[0];
                int count = 0;
                foreach (char letter in branches[i].Content)
                {
                    if (letter == ' ')
                    {
                        count++;
                    }
                    else if (letter == '\t')
                    {
                        count += 3;
                    }
                }
                
                //int count = nodes[i].ToString().TakeWhile(c => c == ' ').Count();
                //int tabCount = nodes[i].ToString().TakeWhile(Char.).Count();
                //Console.WriteLine("WhiteSpace " + count);

                if (count > whiteForLast)
                {
                    branches[i].Parent = branches[i-1].Parent;
                    //branches = branches[i];
                }

                whiteForLast = count;
            }
        }

        public void AddNewNodesForTrees(string newData)
        {
            string Random = newData + branches.Count;

            TreeNode newNode = new TreeNode(Random, newData, true, null);

            

            branches.Add(newNode);

            MakeParents();
        }

        public void AddNewNodesForTrees(string[] newData)
        {
            foreach (string data in newData)
            {
                string Random = data + branches.Count;


                TreeNode newNode = new TreeNode(Random, data, true, null);
                branches.Add(newNode);
            }

            MakeParents();
            
        }

        public INode Get(string Id, bool shouldGetBranch) //Needs to Decide Should Get Branch
        {
            INode branchToReturn = null;

            foreach(INode branch in branches)
            {
                if(branch.ID == Id)
                {
                    branchToReturn = branch;
                }
            }

            if(shouldGetBranch)
            {
                return branchToReturn;
            }

            else
            {
                return branchToReturn;
            }
        }

        public void AddNode(string toAdd) //Works
        {
            INode parent = null;
            foreach(INode branch in branches)
            {
                //if(branch.ID == parentId)
                //{
                //    parent = branch;
                //}
            }
            TreeNode newNode = new TreeNode("Random ID", toAdd, true, parent);

            branches.Add(newNode);
        }

        public void DeleteNode(string objectName) //Works
        {
            foreach (INode branch in branches)
            {
                string localTreeNode = branch.Content.Replace("\t", "");
                string localNewNode = objectName.Replace("\t", "");

                if (localTreeNode.Trim().Equals(localNewNode.Trim()))
                {
                    branch.Children.Clear();
                    branches.Remove(branch);
                    break;
                }
            }
        }

        public void MoveNode(string objectId, string parentId)
        {
            foreach(TreeNode branch in branches)
            {
                if(branch.ID == objectId)
                {
                    foreach (TreeNode branch1 in branches)
                    {
                        if(branch1.ID == parentId)
                        {
                            branch.Parent.Children.Remove(branch);
                            branch.Parent = branch1.Parent;

                            branch.Parent.Children.Add(branch);
                        }
                        
                    }
                        
                }
            }
        }

        public INode FindNodeID(string id) //Works
        {
            foreach(INode branch in branches)
            {
                if(branch.ID == id)
                {
                    return branch;
                }
                //else
                //{
                //    TreeNode fakeNode = new TreeNode("No Node Like This Exists", "No Node Here", true, null);
                //    return fakeNode;
                //}
            }

            return null;
        }

        public INode FindNodeConent(string content) //Works
        {
            foreach (INode branch in branches)
            {
                string localTreeNode = branch.Content.Replace("\t","");
                string localNewNode = content.Replace("\t","");
                if (localTreeNode.Trim().Equals(localNewNode.Trim()))
                {
                    return branch;
                }
                //else
                //{
                //    TreeNode fakeNode = new TreeNode("No Node Like This Exists", "No Node Here", true, null);
                //    return fakeNode;
                //}
            }

            return null;
        }
    }
}
