﻿
namespace BankManagementSystem.Presentation_Layer
{
    partial class ShowTransactionByBranchName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTransactionByBranchName));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowTransactionlabel = new System.Windows.Forms.Label();
            this.BranchNamecomboBox = new System.Windows.Forms.ComboBox();
            this.BranchNamelabel = new System.Windows.Forms.Label();
            this.TransactionsdataGridView = new System.Windows.Forms.DataGridView();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlepanel
            // 
            this.Titlepanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Titlepanel.Controls.Add(this.BackpictureBox);
            this.Titlepanel.Controls.Add(this.pictureBox1);
            this.Titlepanel.Controls.Add(this.Minimizelabel1);
            this.Titlepanel.Controls.Add(this.Maximizelabel1);
            this.Titlepanel.Controls.Add(this.Crosslabel1);
            this.Titlepanel.Controls.Add(this.Titlelabel);
            this.Titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlepanel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlepanel.ForeColor = System.Drawing.Color.White;
            this.Titlepanel.Location = new System.Drawing.Point(0, 0);
            this.Titlepanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Titlepanel.Name = "Titlepanel";
            this.Titlepanel.Size = new System.Drawing.Size(1197, 109);
            this.Titlepanel.TabIndex = 6;
            // 
            // BackpictureBox
            // 
            this.BackpictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackpictureBox.Image")));
            this.BackpictureBox.Location = new System.Drawing.Point(0, 0);
            this.BackpictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackpictureBox.Name = "BackpictureBox";
            this.BackpictureBox.Size = new System.Drawing.Size(50, 109);
            this.BackpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackpictureBox.TabIndex = 5;
            this.BackpictureBox.TabStop = false;
            this.BackpictureBox.Click += new System.EventHandler(this.BackpictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Minimizelabel1
            // 
            this.Minimizelabel1.AutoSize = true;
            this.Minimizelabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizelabel1.ForeColor = System.Drawing.Color.Green;
            this.Minimizelabel1.Location = new System.Drawing.Point(1104, 0);
            this.Minimizelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minimizelabel1.Name = "Minimizelabel1";
            this.Minimizelabel1.Size = new System.Drawing.Size(31, 27);
            this.Minimizelabel1.TabIndex = 3;
            this.Minimizelabel1.Text = "O";
            this.Minimizelabel1.Click += new System.EventHandler(this.Minimizelabel1_Click);
            // 
            // Maximizelabel1
            // 
            this.Maximizelabel1.AutoSize = true;
            this.Maximizelabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximizelabel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.Maximizelabel1.Location = new System.Drawing.Point(1135, 0);
            this.Maximizelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maximizelabel1.Name = "Maximizelabel1";
            this.Maximizelabel1.Size = new System.Drawing.Size(31, 27);
            this.Maximizelabel1.TabIndex = 2;
            this.Maximizelabel1.Text = "O";
            this.Maximizelabel1.Click += new System.EventHandler(this.Maximizelabel1_Click);
            // 
            // Crosslabel1
            // 
            this.Crosslabel1.AutoSize = true;
            this.Crosslabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Crosslabel1.ForeColor = System.Drawing.Color.Red;
            this.Crosslabel1.Location = new System.Drawing.Point(1166, 0);
            this.Crosslabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Crosslabel1.Name = "Crosslabel1";
            this.Crosslabel1.Size = new System.Drawing.Size(31, 27);
            this.Crosslabel1.TabIndex = 1;
            this.Crosslabel1.Text = "O";
            this.Crosslabel1.Click += new System.EventHandler(this.Crosslabel1_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(464, 29);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(368, 41);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Piggy Bank Limited";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(486, 132);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // ShowTransactionlabel
            // 
            this.ShowTransactionlabel.AutoSize = true;
            this.ShowTransactionlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTransactionlabel.Location = new System.Drawing.Point(520, 132);
            this.ShowTransactionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowTransactionlabel.Name = "ShowTransactionlabel";
            this.ShowTransactionlabel.Size = new System.Drawing.Size(208, 33);
            this.ShowTransactionlabel.TabIndex = 48;
            this.ShowTransactionlabel.Text = "Transactions";
            // 
            // BranchNamecomboBox
            // 
            this.BranchNamecomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamecomboBox.FormattingEnabled = true;
            this.BranchNamecomboBox.Items.AddRange(new object[] {
            "Chawrasta",
            "Joydeppur",
            "Boardbazar",
            "Uttara",
            "Badda",
            "Tongi",
            "Bashundhara"});
            this.BranchNamecomboBox.Location = new System.Drawing.Point(526, 212);
            this.BranchNamecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BranchNamecomboBox.Name = "BranchNamecomboBox";
            this.BranchNamecomboBox.Size = new System.Drawing.Size(348, 37);
            this.BranchNamecomboBox.TabIndex = 56;
            this.BranchNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.BranchNamecomboBox_SelectedIndexChanged);
            // 
            // BranchNamelabel
            // 
            this.BranchNamelabel.AutoSize = true;
            this.BranchNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamelabel.Location = new System.Drawing.Point(322, 220);
            this.BranchNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BranchNamelabel.Name = "BranchNamelabel";
            this.BranchNamelabel.Size = new System.Drawing.Size(194, 34);
            this.BranchNamelabel.TabIndex = 55;
            this.BranchNamelabel.Text = "Branch Name:";
            // 
            // TransactionsdataGridView
            // 
            this.TransactionsdataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.TransactionsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsdataGridView.Location = new System.Drawing.Point(33, 305);
            this.TransactionsdataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionsdataGridView.Name = "TransactionsdataGridView";
            this.TransactionsdataGridView.Size = new System.Drawing.Size(1134, 483);
            this.TransactionsdataGridView.TabIndex = 57;
            // 
            // ShowTransactionByBranchName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::BankManagementSystem.Properties.Resources.selective_focus_stack_coin_piggy_bank_blur_background_growth_coins_bar_life_expense_planning_lifestyle_wealth_concept_177535690;
            this.ClientSize = new System.Drawing.Size(1197, 832);
            this.Controls.Add(this.TransactionsdataGridView);
            this.Controls.Add(this.BranchNamecomboBox);
            this.Controls.Add(this.BranchNamelabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowTransactionlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowTransactionByBranchName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowTransactionByBranchName";
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Titlepanel;
        private System.Windows.Forms.PictureBox BackpictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Minimizelabel1;
        private System.Windows.Forms.Label Maximizelabel1;
        private System.Windows.Forms.Label Crosslabel1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ShowTransactionlabel;
        private System.Windows.Forms.ComboBox BranchNamecomboBox;
        private System.Windows.Forms.Label BranchNamelabel;
        private System.Windows.Forms.DataGridView TransactionsdataGridView;
    }
}