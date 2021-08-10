﻿
namespace BaarDanaTraderPOS.Screens
{
    partial class ViewHistoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerSearch = new System.Windows.Forms.TextBox();
            this.dgvViewHistory = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_All = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(952, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "کسٹمر کا نام یا انوائس نمبر درج کریں:۔";
            // 
            // tbCustomerSearch
            // 
            this.tbCustomerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCustomerSearch.Location = new System.Drawing.Point(502, 11);
            this.tbCustomerSearch.Name = "tbCustomerSearch";
            this.tbCustomerSearch.Size = new System.Drawing.Size(384, 35);
            this.tbCustomerSearch.TabIndex = 1;
            // 
            // dgvViewHistory
            // 
            this.dgvViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewHistory.Location = new System.Drawing.Point(22, 197);
            this.dgvViewHistory.Name = "dgvViewHistory";
            this.dgvViewHistory.RowHeadersWidth = 62;
            this.dgvViewHistory.RowTemplate.Height = 28;
            this.dgvViewHistory.Size = new System.Drawing.Size(1353, 429);
            this.dgvViewHistory.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_search.Location = new System.Drawing.Point(304, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_search.Size = new System.Drawing.Size(130, 43);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "تلاش کریں۔";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(3, 88);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(140, 50);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "پرنٹ کریں";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.Show_All);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.from);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCustomerSearch);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 148);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(1080, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "شروع ہونے والی تاریخ۔";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(594, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "اختتامی تاریخ۔";
            // 
            // Show_All
            // 
            this.Show_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Show_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Show_All.Location = new System.Drawing.Point(99, 11);
            this.Show_All.Name = "Show_All";
            this.Show_All.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Show_All.Size = new System.Drawing.Size(168, 43);
            this.Show_All.TabIndex = 5;
            this.Show_All.Text = "سب دکھائیں۔";
            this.Show_All.UseVisualStyleBackColor = true;
            this.Show_All.Click += new System.EventHandler(this.Show_All_Click);
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.to.Location = new System.Drawing.Point(229, 88);
            this.to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(348, 30);
            this.to.TabIndex = 7;
            this.to.ValueChanged += new System.EventHandler(this.to_ValueChanged);
            // 
            // from
            // 
            this.from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.from.Location = new System.Drawing.Point(723, 89);
            this.from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(350, 30);
            this.from.TabIndex = 6;
            this.from.Value = new System.DateTime(2021, 8, 7, 18, 57, 52, 0);
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1080, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = "کل فروخت";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1020, 646);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 41);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0";
            // 
            // ViewHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 738);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvViewHistory);
            this.Name = "ViewHistoryForm";
            this.Text = "ViewHistoryForm";
            this.Load += new System.EventHandler(this.ViewHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerSearch;
        private System.Windows.Forms.DataGridView dgvViewHistory;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Show_All;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
    }
}