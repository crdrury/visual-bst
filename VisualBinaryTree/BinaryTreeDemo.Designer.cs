namespace VisualBinaryTree
{
    partial class BinaryTreeDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputField = new System.Windows.Forms.TextBox();
            this.treePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.AcceptsReturn = true;
            this.inputField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputField.Location = new System.Drawing.Point(0, 661);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(1264, 20);
            this.inputField.TabIndex = 0;
            // 
            // treePanel
            // 
            this.treePanel.AutoScroll = true;
            this.treePanel.AutoSize = true;
            this.treePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePanel.Location = new System.Drawing.Point(0, 0);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(1264, 661);
            this.treePanel.TabIndex = 1;
            this.treePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Event);
            // 
            // BinaryTreeDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.treePanel);
            this.Controls.Add(this.inputField);
            this.DoubleBuffered = true;
            this.Name = "BinaryTreeDemo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Panel treePanel;
    }
}

