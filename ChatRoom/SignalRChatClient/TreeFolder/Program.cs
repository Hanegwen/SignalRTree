using System;

namespace SignalRChatClient
{
    class Program1
    {
        //    //static void Main(string[] args)
        //    {
        //        DataTree tree = new DataTree();
        //        bool KeepRunningInput = true;
        //        bool hasLoaded = false;
        //        do
        //        {
        //            Console.WriteLine("Type In What You Would Like To Do and Press Enter");

        //            Console.WriteLine("1: ADD To Tree via Console");
        //            Console.WriteLine("2: ADD To Tree via Document");
        //            Console.WriteLine("3: Get a Node");
        //            Console.WriteLine("4: Add a Node");
        //            Console.WriteLine("5: Delete a Node");
        //            Console.WriteLine("6: Move a Node");
        //            Console.WriteLine("7: Find Node based on ID");
        //            Console.WriteLine("8: Find Node based on Contents");

        //            string Input = Console.ReadLine();

        //            switch (Input)
        //            {
        //                case "1":
        //                    Console.WriteLine("What will the new data be");
        //                    string newData = Console.ReadLine();

        //                    tree.AddNewNodesForTrees(newData);
        //                    break; //Works
        //                case "2":

        //                    //string[] TheBaseData = System.IO.File.ReadAllLines(@"E:\Columbia\Senior\Algorithms\TreeData.txt");
        //                    //Mike's Home

        //                    string[] TheBaseData = System.IO.File.ReadAllLines(@"C:\workspace\names.tab");
        //                    //School

        //                    tree.AddNewNodesForTrees(TheBaseData);
        //                    hasLoaded = true;

        //                    if (hasLoaded)
        //                    {
        //                        foreach (TreeNode node in tree.branches)
        //                        {
        //                            Console.WriteLine(node.Content);
        //                        }
        //                    }
        //                    break;
        //                case "3":
        //                    Console.WriteLine("What Node Would You Like");
        //                    string inputID = Console.ReadLine();

        //                    Console.WriteLine(tree.Get(inputID, true));
        //                    break; //Works
        //                case "4":
        //                    Console.WriteLine("What Data Would You LIke to Add");
        //                    string dataToAdd = Console.ReadLine();
        //                    Console.WriteLine("What is the ID of Your Parent?");
        //                    string parentID = Console.ReadLine();

        //                    tree.AddNode(dataToAdd, parentID);
        //                    break; //Works
        //                case "5":
        //                    Console.WriteLine("What Node Data");
        //                    string NodeToDelete = Console.ReadLine();

        //                    tree.DeleteNode(NodeToDelete);
        //                    break; //Works
        //                case "6":
        //                    Console.WriteLine("What Node ID would you like to move");
        //                    string NodeToMove = Console.ReadLine();

        //                    Console.WriteLine("Who is The New Parent?");
        //                    string NewParent = Console.ReadLine();

        //                    tree.MoveNode(NodeToMove, NewParent);
        //                    break; //Works
        //                case "7":
        //                    Console.WriteLine("What Node via ID would you like to return?");
        //                    string IDOfNode = Console.ReadLine();

        //                    Console.WriteLine(tree.FindNodeID(IDOfNode).ID);
        //                    foreach(INode child in tree.FindNodeID(IDOfNode).Children)
        //                    {
        //                        Console.WriteLine(tree.FindNodeID(IDOfNode).ID);
        //                    }
        //                    break; //works
        //                case "8":
        //                    Console.WriteLine("What Node via Content would you like to return?");
        //                    string FindNodeContent = Console.ReadLine();

        //                    Console.WriteLine(tree.FindNodeConent(FindNodeContent).Content);
        //                    foreach(INode child in tree.FindNodeConent(FindNodeContent).Children)
        //                    {
        //                        Console.WriteLine(tree.FindNodeConent(FindNodeContent).Content);
        //                    }
        //                    break;
        //                default:
        //                    KeepRunningInput = false;
        //                    break; //works
        //            }

        //            //Need To Add via Console
        //            //Need to Add via Text File
        //        } while (KeepRunningInput);

        //        if (hasLoaded)
        //        {
        //            foreach (TreeNode node in tree.branches)
        //            {
        //                Console.WriteLine(node.Content);
        //            }
        //        }

        //        Console.ReadLine();

        //        if (hasLoaded)
        //        {
        //            tree.WriteOutLineFile();
        //        }
        //    }


        //}
    }
}
