using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------
/// 
/// Author: Chris Drury
/// Created: 2/19/2020
/// 
/// This is the main class of the program, containing the GUI
/// window and I/O handlers.
/// 
/// The purpose of the program is to visualize how a binary search
/// tree organizes nurmerical data. The user can add values to the
/// tree and see them displayed graphically.
/// 
/// ---------------------------------------------------------
/// </summary>

namespace VisualBinaryTree
{
    public partial class BinaryTreeDemo : Form
    {
        BinaryTree binaryTree;

        Bitmap bufferImage;
        Graphics frameGraphics;

        public BinaryTreeDemo()
        {
            binaryTree = new BinaryTree();

            Console.WriteLine();
            Console.WriteLine("Binary Tree Demo");
            Console.WriteLine("By Chris Drury");
            Console.WriteLine();
            Console.WriteLine("Add values by typing them in the text box and pressing Enter.");
            Console.WriteLine("Values must be integers between 1 and 99.");
            Console.WriteLine();

            InitializeComponent();
            frameGraphics = treePanel.CreateGraphics();
            bufferImage = new Bitmap(Size.Width, Size.Height);
            KeyPreview = true;
            this.inputField.KeyDown += this.InputEntered;

            PaintTree();
        }

        private void InputEntered(object sender, KeyEventArgs e)
        {
            Console.Write(e.KeyCode);
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.TryParse(inputField.Text, out int newValue) && newValue > 0 && newValue < 100)
                {
                    binaryTree.AddValue(newValue);
                }
                else
                {
                    Console.WriteLine("Value must be a number between 1 and 99.");
                }
                PaintTree();

                inputField.Text = "";
            }
            e.Handled = true;
        }

        private void Paint_Event(object sender, PaintEventArgs e)
        {
            PaintTree();
        }

        private void PaintTree()
        {
            binaryTree.PaintTree(frameGraphics, treePanel.Width / 2);
        }
    }
}
