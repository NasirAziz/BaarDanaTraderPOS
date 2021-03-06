
namespace BaarDanaTraderPOS.Screens
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.tbItemQuantity = new System.Windows.Forms.TextBox();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemCancel = new System.Windows.Forms.Button();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.tbAISearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAISearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbItemName
            // 
            resources.ApplyResources(this.tbItemName, "tbItemName");
            this.tbItemName.Name = "tbItemName";
            // 
            // tbItemPrice
            // 
            resources.ApplyResources(this.tbItemPrice, "tbItemPrice");
            this.tbItemPrice.Name = "tbItemPrice";
            // 
            // tbItemQuantity
            // 
            resources.ApplyResources(this.tbItemQuantity, "tbItemQuantity");
            this.tbItemQuantity.Name = "tbItemQuantity";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnItemAdd, "btnItemAdd");
            this.btnItemAdd.ForeColor = System.Drawing.Color.White;
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.UseVisualStyleBackColor = false;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemCancel
            // 
            this.btnItemCancel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnItemCancel, "btnItemCancel");
            this.btnItemCancel.Name = "btnItemCancel";
            this.btnItemCancel.UseVisualStyleBackColor = false;
            this.btnItemCancel.Click += new System.EventHandler(this.btnItemCancel_Click);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnItemUpdate, "btnItemUpdate");
            this.btnItemUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.UseVisualStyleBackColor = false;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnItemDelete, "btnItemDelete");
            this.btnItemDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.UseVisualStyleBackColor = false;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // dgvItems
            // 
            resources.ApplyResources(this.dgvItems, "dgvItems");
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // tbAISearch
            // 
            resources.ApplyResources(this.tbAISearch, "tbAISearch");
            this.tbAISearch.Name = "tbAISearch";
            this.tbAISearch.TextChanged += new System.EventHandler(this.tbAISearch_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnAISearch
            // 
            resources.ApplyResources(this.btnAISearch, "btnAISearch");
            this.btnAISearch.Name = "btnAISearch";
            this.btnAISearch.UseVisualStyleBackColor = true;
            this.btnAISearch.Click += new System.EventHandler(this.btnAISearch_Click);
            // 
            // btnShowAll
            // 
            resources.ApplyResources(this.btnShowAll, "btnShowAll");
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // AddItemForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.tbAISearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAISearch);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnItemUpdate);
            this.Controls.Add(this.btnItemCancel);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.tbItemQuantity);
            this.Controls.Add(this.tbItemPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.TextBox tbItemQuantity;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemCancel;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox tbAISearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAISearch;
        private System.Windows.Forms.Button btnShowAll;
    }
}