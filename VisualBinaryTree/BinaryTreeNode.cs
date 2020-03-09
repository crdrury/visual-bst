namespace VisualBinaryTree
{
    class BinaryTreeNode
    {
        // Standard BST variables
        int value;
        readonly BinaryTreeNode[] childNode;

        public enum ChildNode { LEFT = 0, RIGHT = 1 }

        // Variables needed to display the node graphically.
        private double drawX = 0, drawY = 0;
        public static int SIZE = 50;

        public BinaryTreeNode(int value)
        {
            childNode = new BinaryTreeNode[2];
            this.value = value;
        }

        public void SetChildNode(ChildNode selectedNode, BinaryTreeNode node)
        {
            childNode[(int)selectedNode] = node;
        }

        public BinaryTreeNode GetChildNode(ChildNode selectedNode)
        {
            return childNode[(int)selectedNode];
        }

        public BinaryTreeNode[] GetChildren()
        {
            return childNode;
        }

        public void SetPosition(double x, double y)
        {
            drawX = x;
            drawY = y;
        }

        public double GetX()
        {
            return drawX;
        }

        public double GetY()
        {
            return drawY;
        }

        public int GetValue()
        {
            return value;
        }

        public int CompareTo(BinaryTreeNode otherNode)
        {
            return value.CompareTo(otherNode.value);
        }
    }
}
