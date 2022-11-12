﻿
namespace BankManagementSystem.Presentation_Layer
{
    partial class DepositeLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositeLoan));
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.Minimizelabel1 = new System.Windows.Forms.Label();
            this.Maximizelabel1 = new System.Windows.Forms.Label();
            this.Crosslabel1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.AccountNumbertextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberlabel = new System.Windows.Forms.Label();
            this.LoanPaymentlabel = new System.Windows.Forms.Label();
            this.LoandataGridView = new System.Windows.Forms.DataGridView();
            this.AccountTypecomboBox = new System.Windows.Forms.ComboBox();
            this.AccountTypelabel = new System.Windows.Forms.Label();
            this.BranchNamecomboBox = new System.Windows.Forms.ComboBox();
            this.BranchNamelabel = new System.Windows.Forms.Label();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Depositbutton = new System.Windows.Forms.Button();
            this.PaidAmounttextBox = new System.Windows.Forms.TextBox();
            this.PriviouslyPaidlabel = new System.Windows.Forms.Label();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoandataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Titlepanel.TabIndex = 51;
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
            this.Titlelabel.Location = new System.Drawing.Point(470, 28);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(368, 41);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Piggy Bank Limited";
            // 
            // AccountNumbertextBox
            // 
            this.AccountNumbertextBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumbertextBox.Location = new System.Drawing.Point(502, 168);
            this.AccountNumbertextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountNumbertextBox.Name = "AccountNumbertextBox";
            this.AccountNumbertextBox.Size = new System.Drawing.Size(348, 37);
            this.AccountNumbertextBox.TabIndex = 62;
            // 
            // AccountNumberlabel
            // 
            this.AccountNumberlabel.AutoSize = true;
            this.AccountNumberlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberlabel.Location = new System.Drawing.Point(262, 175);
            this.AccountNumberlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccountNumberlabel.Name = "AccountNumberlabel";
            this.AccountNumberlabel.Size = new System.Drawing.Size(234, 34);
            this.AccountNumberlabel.TabIndex = 61;
            this.AccountNumberlabel.Text = "Account Number:";
            // 
            // LoanPaymentlabel
            // 
            this.LoanPaymentlabel.AutoSize = true;
            this.LoanPaymentlabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanPaymentlabel.Location = new System.Drawing.Point(512, 114);
            this.LoanPaymentlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoanPaymentlabel.Name = "LoanPaymentlabel";
            this.LoanPaymentlabel.Size = new System.Drawing.Size(229, 33);
            this.LoanPaymentlabel.TabIndex = 59;
            this.LoanPaymentlabel.Text = "Loan Payment";
            // 
            // LoandataGridView
            // 
            this.LoandataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.LoandataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoandataGridView.Location = new System.Drawing.Point(46, 242);
            this.LoandataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoandataGridView.Name = "LoandataGridView";
            this.LoandataGridView.Size = new System.Drawing.Size(1120, 169);
            this.LoandataGridView.TabIndex = 64;
            this.LoandataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoandataGridView_CellClick);
            // 
            // AccountTypecomboBox
            // 
            this.AccountTypecomboBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypecomboBox.FormattingEnabled = true;
            this.AccountTypecomboBox.Items.AddRange(new object[] {
            "Savings Account",
            "Checking Account"});
            this.AccountTypecomboBox.Location = new System.Drawing.Point(304, 511);
            this.AccountTypecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountTypecomboBox.Name = "AccountTypecomboBox";
            this.AccountTypecomboBox.Size = new System.Drawing.Size(348, 37);
            this.AccountTypecomboBox.TabIndex = 78;
            // 
            // AccountTypelabel
            // 
            this.AccountTypelabel.AutoSize = true;
            this.AccountTypelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypelabel.Location = new System.Drawing.Point(57, 518);
            this.AccountTypelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccountTypelabel.Name = "AccountTypelabel";
            this.AccountTypelabel.Size = new System.Drawing.Size(192, 34);
            this.AccountTypelabel.TabIndex = 77;
            this.AccountTypelabel.Text = "Account Type:";
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
            this.BranchNamecomboBox.Location = new System.Drawing.Point(304, 729);
            this.BranchNamecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BranchNamecomboBox.Name = "BranchNamecomboBox";
            this.BranchNamecomboBox.Size = new System.Drawing.Size(348, 37);
            this.BranchNamecomboBox.TabIndex = 76;
            // 
            // BranchNamelabel
            // 
            this.BranchNamelabel.AutoSize = true;
            this.BranchNamelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNamelabel.Location = new System.Drawing.Point(57, 737);
            this.BranchNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BranchNamelabel.Name = "BranchNamelabel";
            this.BranchNamelabel.Size = new System.Drawing.Size(194, 34);
            this.BranchNamelabel.TabIndex = 75;
            this.BranchNamelabel.Text = "Branch Name:";
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmounttextBox.Location = new System.Drawing.Point(304, 588);
            this.AmounttextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(348, 37);
            this.AmounttextBox.TabIndex = 74;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.Location = new System.Drawing.Point(57, 595);
            this.Amountlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(123, 34);
            this.Amountlabel.TabIndex = 73;
            this.Amountlabel.Text = "Amount:";
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(304, 660);
            this.TransactionDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionDateTimePicker.MaxDate = new System.DateTime(2030, 2, 28, 0, 0, 0, 0);
            this.TransactionDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(348, 37);
            this.TransactionDateTimePicker.TabIndex = 72;
            this.TransactionDateTimePicker.Value = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(57, 668);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(240, 34);
            this.Datelabel.TabIndex = 71;
            this.Datelabel.Text = "Transaction Date:";
            // 
            // Depositbutton
            // 
            this.Depositbutton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Depositbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Depositbutton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositbutton.ForeColor = System.Drawing.Color.White;
            this.Depositbutton.Location = new System.Drawing.Point(824, 760);
            this.Depositbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Depositbutton.Name = "Depositbutton";
            this.Depositbutton.Size = new System.Drawing.Size(314, 54);
            this.Depositbutton.TabIndex = 79;
            this.Depositbutton.Text = "Deposit";
            this.Depositbutton.UseVisualStyleBackColor = false;
            this.Depositbutton.Click += new System.EventHandler(this.Depositbutton_Click);
            // 
            // PaidAmounttextBox
            // 
            this.PaidAmounttextBox.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmounttextBox.Location = new System.Drawing.Point(304, 438);
            this.PaidAmounttextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaidAmounttextBox.Name = "PaidAmounttextBox";
            this.PaidAmounttextBox.Size = new System.Drawing.Size(348, 37);
            this.PaidAmounttextBox.TabIndex = 81;
            // 
            // PriviouslyPaidlabel
            // 
            this.PriviouslyPaidlabel.AutoSize = true;
            this.PriviouslyPaidlabel.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriviouslyPaidlabel.Location = new System.Drawing.Point(57, 446);
            this.PriviouslyPaidlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriviouslyPaidlabel.Name = "PriviouslyPaidlabel";
            this.PriviouslyPaidlabel.Size = new System.Drawing.Size(188, 34);
            this.PriviouslyPaidlabel.TabIndex = 80;
            this.PriviouslyPaidlabel.Text = "Paid Amount:";
            // 
            // SearchpictureBox
            // 
            this.SearchpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchpictureBox.Image")));
            this.SearchpictureBox.Location = new System.Drawing.Point(846, 168);
            this.SearchpictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchpictureBox.Name = "SearchpictureBox";
            this.SearchpictureBox.Size = new System.Drawing.Size(50, 42);
            this.SearchpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchpictureBox.TabIndex = 63;
            this.SearchpictureBox.TabStop = false;
            this.SearchpictureBox.Click += new System.EventHandler(this.SearchpictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(477, 115);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
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
            this.pictureBox1.Location = new System.Drawing.Point(374, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DepositeLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::BankManagementSystem.Properties.Resources.selective_focus_stack_coin_piggy_bank_blur_background_growth_coins_bar_life_expense_planning_lifestyle_wealth_concept_177535690;
            this.ClientSize = new System.Drawing.Size(1197, 832);
            this.Controls.Add(this.PaidAmounttextBox);
            this.Controls.Add(this.PriviouslyPaidlabel);
            this.Controls.Add(this.Depositbutton);
            this.Controls.Add(this.AccountTypecomboBox);
            this.Controls.Add(this.AccountTypelabel);
            this.Controls.Add(this.BranchNamecomboBox);
            this.Controls.Add(this.BranchNamelabel);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.Amountlabel);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.LoandataGridView);
            this.Controls.Add(this.SearchpictureBox);
            this.Controls.Add(this.AccountNumbertextBox);
            this.Controls.Add(this.AccountNumberlabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoanPaymentlabel);
            this.Controls.Add(this.Titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepositeLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositeLoan";
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoandataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.TextBox AccountNumbertextBox;
        private System.Windows.Forms.Label AccountNumberlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LoanPaymentlabel;
        private System.Windows.Forms.DataGridView LoandataGridView;
        private System.Windows.Forms.ComboBox AccountTypecomboBox;
        private System.Windows.Forms.Label AccountTypelabel;
        private System.Windows.Forms.ComboBox BranchNamecomboBox;
        private System.Windows.Forms.Label BranchNamelabel;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Button Depositbutton;
        private System.Windows.Forms.TextBox PaidAmounttextBox;
        private System.Windows.Forms.Label PriviouslyPaidlabel;
    }
}