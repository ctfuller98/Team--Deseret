
namespace MegaDesk_Tibbitts
{
    partial class SearchQuotes
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
            this.sqMainMenuBtn = new System.Windows.Forms.Button();
            this.allQuotesTable = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rush = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // sqMainMenuBtn
            // 
            this.sqMainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqMainMenuBtn.Location = new System.Drawing.Point(12, 384);
            this.sqMainMenuBtn.Name = "sqMainMenuBtn";
            this.sqMainMenuBtn.Size = new System.Drawing.Size(138, 54);
            this.sqMainMenuBtn.TabIndex = 0;
            this.sqMainMenuBtn.Text = "&Main Menu";
            this.sqMainMenuBtn.UseVisualStyleBackColor = true;
            this.sqMainMenuBtn.Click += new System.EventHandler(this.sqMainMenuBtn_Click);
            // 
            // allQuotesTable
            // 
            this.allQuotesTable.AllowUserToAddRows = false;
            this.allQuotesTable.AllowUserToDeleteRows = false;
            this.allQuotesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuotesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.TimeStamp,
            this.totalCost,
            this.rush,
            this.width,
            this.depth,
            this.numDrawers,
            this.materialType});
            this.allQuotesTable.Location = new System.Drawing.Point(12, 121);
            this.allQuotesTable.Name = "allQuotesTable";
            this.allQuotesTable.Size = new System.Drawing.Size(776, 257);
            this.allQuotesTable.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = " Customer Name";
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "Date";
            this.TimeStamp.Name = "TimeStamp";
            // 
            // totalCost
            // 
            this.totalCost.HeaderText = "Total Price";
            this.totalCost.Name = "totalCost";
            // 
            // rush
            // 
            this.rush.HeaderText = "Rush Days";
            this.rush.Name = "rush";
            this.rush.Width = 75;
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            this.width.Width = 50;
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            this.depth.Width = 50;
            // 
            // numDrawers
            // 
            this.numDrawers.HeaderText = "Drawers";
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Width = 75;
            // 
            // materialType
            // 
            this.materialType.HeaderText = "Material";
            this.materialType.Name = "materialType";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(304, 92);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 21);
            this.MaterialComboBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(431, 92);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search List";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.allQuotesTable);
            this.Controls.Add(this.sqMainMenuBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sqMainMenuBtn;
        private System.Windows.Forms.DataGridView allQuotesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn rush;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialType;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Button SearchButton;
    }
}