using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();

            // Insert Product
            Console.Write("**Product Database using Binary Search Tree** \n");
            BSTree tree = new BSTree();
            tree.Insert(new Node(new Product(18, "Dell XPS 15 9510", 180, 1, "Up-to-date")));
            tree.Insert(new Node(new Product(20, "Ram DDR4", 980, 5, "Fast")));
            tree.Insert(new Node(new Product(10, "SSD 256gb", 1000, 4, "Reasonable")));
            tree.Insert(new Node(new Product(15, "HDD 1T", 560, 3, "Cheap")));
            tree.Insert(new Node(new Product(12, "VGA NVIDIA", 3800, 4, "Cool")));
            tree.Insert(new Node(new Product(17, "USB 16gb", 250, 3, "Great")));
            tree.Insert(new Node(new Product(7, "Dell Vostro 5490", 18000, 4, "Versatile")));
            tree.Insert(new Node(new Product(8, "Surface Pro 3", 15000, 3, "Expensive")));
            tree.Insert(new Node(new Product(3, "Logitech Mouse", 480, 3, "Good")));


            // Create MENU   
            for (; ; )
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("| 1 - Insert   |\n| 2 - Traverse |\n| 3 - Find     |\n| 4 - Remove   |\n| 5 - DepthTree|\n| 0 - Exit     |");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n\n---Choose number: ");
                string sel = Console.ReadLine();
                int _Id;
                int _Price;
                string _Productname;
                int _Rating;
                string _Des;
                Console.ForegroundColor = ConsoleColor.White;

                switch (sel)
                {
                    case "1":
                        Console.Write("\nInsert product information: ");
                        Console.Write("\nId = ");
                        _Id = int.Parse(Console.ReadLine());
                        Console.Write("Product Name = ");
                        _Productname = Console.ReadLine();
                        Console.Write("Product Price = ");
                        _Price = int.Parse(Console.ReadLine());
                        Console.Write("Product Rating = ");
                        _Rating = int.Parse(Console.ReadLine());
                        Console.Write("Product Description = ");
                        _Des = Console.ReadLine();
                        tree.Insert(new Node(new Product(_Id, _Productname, _Price, _Rating, _Des)));
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    case "2":
                        try
                        {
                            Console.WriteLine("\n>> Count nodes: " + tree.numNodesIn());
                            Console.WriteLine(">> Count edges: " + tree.numEdgesIn());
                            Console.WriteLine("\nChoose number:");
                            Console.Write(">> [1] -- Inorder\n>> [2] -- Preorder\n>> [3] -- Postorder\n");
                            Console.Write("Choose number: ");
                            sel = Console.ReadLine();
                            switch (sel)
                            {
                                case "1":
                                    tree.TraversetInOrder();
                                    break;
                                case "2":
                                    tree.TraversePreOrder();
                                    break;
                                case "3":
                                    tree.TraversePostOrder();
                                    break;
                                default:
                                    Console.WriteLine(">> Try again please!");
                                    continue;
                            }
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        catch
                        {
                            Console.WriteLine(">> BSTree not found!");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    case "3":
                        try
                        {
                            Console.Write("Enter product Id : ");
                            _Id = int.Parse(Console.ReadLine());
                            Node node = tree.Find(_Id);
                            if (node == null)
                            {
                                Console.WriteLine("\n\n>> No results. Please try again!");
                            }
                            else
                            {
                                Console.WriteLine("\n\n---Find result = " + _Id);
                                node.Data();
                            }

                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        catch
                        {
                            Console.WriteLine("\n\n>> No results. Please try again!");

                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    case "4":
                        try
                        {
                            Console.Write("Enter product Id: ");
                            _Id = int.Parse(Console.ReadLine());
                            Node node = tree.Find(_Id);
                            if (node == null)
                            {
                                Console.WriteLine("\n\n>> No results. Please try again!");
                            }
                            else
                            {
                                tree.Delete(_Id);
                                Console.WriteLine("\n\n---Delete product have Id = " + _Id);
                                //Show Preorder
                                tree.TraversePreOrder();

                                //Show Postorder
                                //tree.TraversePostOrder();
                                //Show Inorder
                                //tree.TraversetInOrder();
                            }

                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        catch
                        {
                            Console.WriteLine("\n\n>> No results. Please try again!");

                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    case "5":
                        {
                            Console.Write("\n>> Max Depth: " + tree.maxDepth());
                            Console.Write("\n>> Min Depth: " + tree.minDepth());

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "0":
                        Environment.Exit(0);
                        continue;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n>> Please try another number!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}