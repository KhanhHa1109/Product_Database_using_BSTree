using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL
{
    public class BSTree
    {
        private int size;
        public Node root;

        public BSTree()
        {
            size = 0;
            root = null;
        }

        public int Size()
        {
            return size;
        }

        #region Insert
        public void Insert(Node newNode)
        {
            root = Insert(root, newNode);
        }

        private Node Insert(Node node, Node newNode)
        {
            if (node == null)
            {
                size++;
                return newNode;
            }

            if (newNode.lessThanOrEqual(node.product))
            {
                node.left = Insert(node.left, newNode);
            }
            else
            {
                node.right = Insert(node.right, newNode);
            }
            return node;
        }
        #endregion

        #region Find
        public Node Find(int productId)
        {
            return Find(this.root, productId);
        }

        private Node Find(Node node, int productId)
        {
            if (node == null) return null;


            if (node.hasproduct(productId))
            {
                return node;
            }
            if (node.lessThan(productId))
            {
                return Find(node.right, productId);
            }
            else
            {
                return Find(node.left, productId);
            }
        }
        #endregion

        #region Delete
        public void Delete(int productId)
        {
            root = Delete(root, productId);
        }

        public Node Delete(Node node, int productId)
        {
            if (node == null) return null;


            if (node.hasproduct(productId))
            {
                size--;
                if (node.left == null)
                {
                    return node.right;
                }
                Node maxNode = node.left;
                Node preNode = maxNode;
                while (maxNode.right != null)
                {
                    preNode = maxNode;
                    maxNode = maxNode.right;
                }

                maxNode.right = node.right;
                if (maxNode != node.left)
                {
                    preNode.right = maxNode.left;
                    maxNode.left = node.left;

                }
                return maxNode;
            }
            if (node.lessThan(productId))
            {
                node.right = Delete(node.right, productId);
            }
            else
            {
                node.left = Delete(node.left, productId);
            }
            return node;

        }
        #endregion

        #region TraversePreOrder
        public void TraversePreOrder()
        {
            Console.Write("\n\n----------------------------------------TraversePreOrder---------------------------------------");
            TraversePreOrder(root);
        }

        private void TraversePreOrder(Node node)
        {
            if (node == null) return;
            node.Data();
            TraversePreOrder(node.left);
            TraversePreOrder(node.right);
        }
        #endregion

        #region TraverseInOrder
        public void TraversetInOrder()
        {
            Console.Write("\n\n----------------------------------------TraverseInOrder----------------------------------------");
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node node)
        {
            if (node == null) return;
            TraverseInOrder(node.left);
            node.Data();
            TraverseInOrder(node.right);
        }
        #endregion

        #region TraversePostOrder
        public void TraversePostOrder()
        {
            Console.Write("\n\n----------------------------------------TraversePostOrder----------------------------------------");
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            TraversePostOrder(node.left);
            TraversePostOrder(node.right);
            node.Data();
        }
        #endregion

        #region Max Depth
        public int maxDepth(Node node)
        {
            if (node == null)
                return -1;
            else
            {
                int leftDep = maxDepth(node.left);
                int rightDep = maxDepth(node.right);

                if (leftDep > rightDep)
                {
                    return (leftDep + 1);
                }
                else
                {
                    return (rightDep + 1);
                }
            }
        }
        public int maxDepth()
        {
            return maxDepth(this.root);
        }
        #endregion

        #region Min Depth
        public int minDepth(Node node)
        {
            if (node == null)
                return -1;
            else
            {
                int leftDep = minDepth(node.left);
                int rightDep = minDepth(node.right);

                if (leftDep < rightDep)
                {
                    return (leftDep + 1);
                }
                else
                {
                    return (rightDep + 1);
                }
            }
        }
        public int minDepth()
        {
            return minDepth(this.root);
        }
        #endregion

        #region Count node
        public int numNodesIn(Node node)
        {
            if (node == null) return 0;
            return 1 + numNodesIn(node.left) + numNodesIn(node.right);
        }
        public int numNodesIn()
        {
            return numNodesIn(this.root);
        }
        #endregion

        #region Count edge
        public int numEdgesIn(Node node)
        {
            return node == null ? 0 : numNodesIn(node) - 1;
        }
        public int numEdgesIn()
        {
            return numEdgesIn(this.root);
        }
        #endregion

    }
}