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
            this.label1 = new System.Windows.Forms.Label();
            this.treePanel.SuspendLayout();
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
            this.inputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treePanel
            // 
            this.treePanel.AutoScroll = true;
            this.treePanel.AutoSize = true;
            this.treePanel.Controls.Add(this.label1);
            this.treePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePanel.Location = new System.Drawing.Point(0, 0);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(1264, 661);
            this.treePanel.TabIndex = 1;
            this.treePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Event);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number from 1-99";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.treePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.Label label1;
    }
}

