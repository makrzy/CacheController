﻿using System;
using System.Windows.Forms;

namespace CacheController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

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
        private void InitializeComponents()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 75);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 75);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 75);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 75);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Make changes to form components that are not set by default.
        /// Can not be done in 'InitializeComponent' method as it is owned by designer.
        /// </summary>
        private void PersonalizeComponents()
        {
            this.button1.Click += new System.EventHandler(Program.Insert);
            this.button2.Click += new System.EventHandler(Program.FlushAll);
            this.button3.Click += new System.EventHandler(Program.InsertClass);
            //this.button4.Click += new System.EventHandler(Program.AddAssignmentSubmission);

            this.button1.Text = "Insert";
            this.button2.Text = "Flush All";
            this.button3.Text = "Initialize with New Data";
            this.button4.Text = "Add an Assignment Submission";
        }
    }
}

