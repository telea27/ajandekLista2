﻿namespace ajandekLista2
{
    partial class Form1
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
            this.ajandekListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ajandekListBox
            // 
            this.ajandekListBox.FormattingEnabled = true;
            this.ajandekListBox.ItemHeight = 16;
            this.ajandekListBox.Location = new System.Drawing.Point(28, 27);
            this.ajandekListBox.Name = "ajandekListBox";
            this.ajandekListBox.Size = new System.Drawing.Size(192, 196);
            this.ajandekListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ajandekListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ajandekListBox;
    }
}

