﻿namespace Lab7OOp
{
    partial class Test
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
            this.listViewTests = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewTests
            // 
            this.listViewTests.HideSelection = false;
            this.listViewTests.Location = new System.Drawing.Point(12, 12);
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(776, 426);
            this.listViewTests.TabIndex = 0;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewTests);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTests;
    }
}