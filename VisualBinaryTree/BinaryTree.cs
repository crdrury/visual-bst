using System;
using System.Collections.Generic;
using System.Drawing;

/// <summary>
/// ---------------------------------------------------------
/// 
/// Author: Chris Drury
/// Created: 2/19/2020
/// 
/// This class contains the binary search tree data structure.
/// In addition to the standard data members of a binary search tree,
/// it also holds data required for displaying the tree visually.
/// 
/// ---------------------------------------------------------
/// </summary>

namespace VisualBinaryTree
{
    class BinaryTree
    {
        // Standard BST data
        private BinaryTreeNode rootNode;            // The 'entry point' for recursive searches.

        // Tree size variables needed to paint the tree correctly.
        private int treeDepth;                      // The 'height' of the tree, or maximum number of recursion levels to reach a node.
        private int treeWidth;                      // The visual width of the tree, equal to (2 ^ treeDepth).

        // Graphical objects used to painting the tree.
        readonly Pen drawingPen = new Pen(Brushes.Black, 3.0f);
        readonly Font drawingFont = new Font("Times", 18, FontStyle.Bold);

        // Returns false if the tree is currently storing any values, otherwise returns true.
        public bool IsEmpty()
        {
            return rootNode == null;
        }

        // Initializes the tree if it is currently empty, otherwise begins the recursive add process.
        public void AddValue(int newValue)
        {
            BinaryTreeNode newNode = new BinaryTreeNode(newValue);
            if (IsEmpty())
            {
                rootNode = newNode;
                treeDepth = 1;
            }
            else
            {
                AddNode(rootNode, newNode, 0);
            }
        }

        // The recursive method for adding a node to the tree.
        private void AddNode(BinaryTreeNode thisNode, BinaryTreeNode newNode, int tempDepth)
        {
            // Increment the current depth of the tree traversal
            tempDepth++;
            // If the new value is less than or equal to the current value, add to the left, otherwise add to the right.
            BinaryTreeNode.ChildNode nextNode =
                (newNode.CompareTo(thisNode) > 0) ?
                BinaryTreeNode.ChildNode.RIGHT :
                BinaryTreeNode.ChildNode.LEFT;

            // If the chosen child node is null, set it to the new value, otherwise continue the recursion.
            if (thisNode.GetChildNode(nextNode) == null)
            {
                newNode.SetPosition(thisNode.GetX() + ((int)nextNode * 2 - 1) * (Math.Pow(2, -tempDepth)), thisNode.GetY() + 1);
                thisNode.SetChildNode(nextNode, newNode);

                // If we are currently deeper than the known depth of the tree, increase the tree depth and calculate the tree width.
                if (tempDepth + 1 > treeDepth)
                {
                    treeDepth = tempDepth + 1;
                    treeWidth = (int)Math.Pow(2, treeDepth);
                }
            }
            else
            {
                AddNode(thisNode.GetChildNode(nextNode), newNode, tempDepth);
            }
        }

        // Begin recursively painting the tree, starting at the root node.
        public void PaintTree(Graphics graphics, int treeCenterX)
        {
            graphics.Clear(Color.DimGray);
            PaintNode(rootNode, treeCenterX, graphics, -1, -1);
        }
        // Paints the current node, then recursively paints children, until all child nodes are null.
        private void PaintNode(BinaryTreeNode node, int treeCenterX, Graphics graphics, int parentX, int parentY)
        {
            if (node != null)
            {
                int adjustedX = (int)(node.GetX() * BinaryTreeNode.SIZE * Math.Pow(2, treeDepth) / 2);
                int adjustedY = (int)(node.GetY() * BinaryTreeNode.SIZE * 2);
                if (parentX != -1 && parentY != -1)
                {
                    graphics.DrawLine(drawingPen,
                        treeCenterX + parentX,
                        parentY,
                        treeCenterX + adjustedX + BinaryTreeNode.SIZE / 2,
                        adjustedY);
                }
                graphics.DrawEllipse(drawingPen, treeCenterX + adjustedX,
                    adjustedY,
                    BinaryTreeNode.SIZE,
                    BinaryTreeNode.SIZE);
                graphics.DrawString("" + node.GetValue(),
                    drawingFont,
                    drawingPen.Brush,
                    treeCenterX + adjustedX + BinaryTreeNode.SIZE / 4,
                    (int)(node.GetY() * BinaryTreeNode.SIZE * 2) + BinaryTreeNode.SIZE / 4);
                
                foreach (BinaryTreeNode n in node.GetChildren()) {
                    PaintNode(n, treeCenterX, graphics, adjustedX + BinaryTreeNode.SIZE / 2, adjustedY + BinaryTreeNode.SIZE);
                }
            }
        }
    }
}
