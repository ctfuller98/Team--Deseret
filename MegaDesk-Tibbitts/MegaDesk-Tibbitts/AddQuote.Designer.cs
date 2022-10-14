
namespace MegaDesk_Tibbitts
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.aqFullNameLabel = new System.Windows.Forms.Label();
            this.aqFullNameTB = new System.Windows.Forms.TextBox();
            this.aqDeskWidthLabel = new System.Windows.Forms.Label();
            this.aqDeskWidthTB = new System.Windows.Forms.TextBox();
            this.agDeskDepthLabel = new System.Windows.Forms.Label();
            this.aqDeskLengthTB = new System.Windows.Forms.TextBox();
            this.agNumDrawersLabel = new System.Windows.Forms.Label();
            this.aqNumDrawersCB = new System.Windows.Forms.ComboBox();
            this.aqSurfMaterialLabel = new System.Windows.Forms.Label();
            this.aqSurfMaterialCB = new System.Windows.Forms.ComboBox();
            this.aqMainMenuBtn = new System.Windows.Forms.Button();
            this.aqRushOptionsLabel = new System.Windows.Forms.Label();
            this.aqRushSubLabel = new System.Windows.Forms.Label();
            this.aqRushOptionsCB = new System.Windows.Forms.ComboBox();
            this.aqSubmitBtn = new System.Windows.Forms.Button();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // aqFullNameLabel
            // 
            this.aqFullNameLabel.AutoSize = true;
            this.aqFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqFullNameLabel.Location = new System.Drawing.Point(12, 9);
            this.aqFullNameLabel.Name = "aqFullNameLabel";
            this.aqFullNameLabel.Size = new System.Drawing.Size(79, 18);
            this.aqFullNameLabel.TabIndex = 0;
            this.aqFullNameLabel.Text = "Full Name:";
            // 
            // aqFullNameTB
            // 
            this.aqFullNameTB.Location = new System.Drawing.Point(12, 30);
            this.aqFullNameTB.Name = "aqFullNameTB";
            this.aqFullNameTB.Size = new System.Drawing.Size(100, 20);
            this.aqFullNameTB.TabIndex = 1;
            this.aqFullNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.aqFullNameTB_Validating);
            // 
            // aqDeskWidthLabel
            // 
            this.aqDeskWidthLabel.AutoSize = true;
            this.aqDeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqDeskWidthLabel.Location = new System.Drawing.Point(12, 71);
            this.aqDeskWidthLabel.Name = "aqDeskWidthLabel";
            this.aqDeskWidthLabel.Size = new System.Drawing.Size(89, 18);
            this.aqDeskWidthLabel.TabIndex = 2;
            this.aqDeskWidthLabel.Text = "Desk Width:";
            // 
            // aqDeskWidthTB
            // 
            this.aqDeskWidthTB.Location = new System.Drawing.Point(12, 92);
            this.aqDeskWidthTB.Name = "aqDeskWidthTB";
            this.aqDeskWidthTB.Size = new System.Drawing.Size(100, 20);
            this.aqDeskWidthTB.TabIndex = 3;
            this.aqDeskWidthTB.TextChanged += new System.EventHandler(this.aqDeskWidthTB_TextChanged);
            this.aqDeskWidthTB.Validating += new System.ComponentModel.CancelEventHandler(this.aqDeskWidthTB_Validating);
            this.aqDeskWidthTB.Validated += new System.EventHandler(this.aqDeskWidthTB_Validated);
            // 
            // agDeskDepthLabel
            // 
            this.agDeskDepthLabel.AutoSize = true;
            this.agDeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agDeskDepthLabel.Location = new System.Drawing.Point(15, 137);
            this.agDeskDepthLabel.Name = "agDeskDepthLabel";
            this.agDeskDepthLabel.Size = new System.Drawing.Size(94, 18);
            this.agDeskDepthLabel.TabIndex = 4;
            this.agDeskDepthLabel.Text = "Desk Depth: ";
            // 
            // aqDeskLengthTB
            // 
            this.aqDeskLengthTB.Location = new System.Drawing.Point(12, 158);
            this.aqDeskLengthTB.Name = "aqDeskLengthTB";
            this.aqDeskLengthTB.Size = new System.Drawing.Size(100, 20);
            this.aqDeskLengthTB.TabIndex = 5;
            this.aqDeskLengthTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aqDeskDepthTB_KeyDown);
            this.aqDeskLengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aqDeskDepthTB_KeyPress);
            // 
            // agNumDrawersLabel
            // 
            this.agNumDrawersLabel.AutoSize = true;
            this.agNumDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agNumDrawersLabel.Location = new System.Drawing.Point(178, 9);
            this.agNumDrawersLabel.Name = "agNumDrawersLabel";
            this.agNumDrawersLabel.Size = new System.Drawing.Size(142, 18);
            this.agNumDrawersLabel.TabIndex = 6;
            this.agNumDrawersLabel.Text = "Number of Drawers:";
            // 
            // aqNumDrawersCB
            // 
            this.aqNumDrawersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqNumDrawersCB.FormattingEnabled = true;
            this.aqNumDrawersCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.aqNumDrawersCB.Location = new System.Drawing.Point(181, 30);
            this.aqNumDrawersCB.Name = "aqNumDrawersCB";
            this.aqNumDrawersCB.Size = new System.Drawing.Size(121, 21);
            this.aqNumDrawersCB.TabIndex = 7;
            // 
            // aqSurfMaterialLabel
            // 
            this.aqSurfMaterialLabel.AutoSize = true;
            this.aqSurfMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqSurfMaterialLabel.Location = new System.Drawing.Point(178, 71);
            this.aqSurfMaterialLabel.Name = "aqSurfMaterialLabel";
            this.aqSurfMaterialLabel.Size = new System.Drawing.Size(119, 18);
            this.aqSurfMaterialLabel.TabIndex = 8;
            this.aqSurfMaterialLabel.Text = "Surface Material:";
            // 
            // aqSurfMaterialCB
            // 
            this.aqSurfMaterialCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqSurfMaterialCB.FormattingEnabled = true;
            this.aqSurfMaterialCB.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.aqSurfMaterialCB.Location = new System.Drawing.Point(181, 92);
            this.aqSurfMaterialCB.Name = "aqSurfMaterialCB";
            this.aqSurfMaterialCB.Size = new System.Drawing.Size(121, 21);
            this.aqSurfMaterialCB.TabIndex = 9;
            // 
            // aqMainMenuBtn
            // 
            this.aqMainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqMainMenuBtn.Location = new System.Drawing.Point(355, 124);
            this.aqMainMenuBtn.Name = "aqMainMenuBtn";
            this.aqMainMenuBtn.Size = new System.Drawing.Size(138, 54);
            this.aqMainMenuBtn.TabIndex = 10;
            this.aqMainMenuBtn.Text = "&Main Menu";
            this.aqMainMenuBtn.UseVisualStyleBackColor = true;
            this.aqMainMenuBtn.Click += new System.EventHandler(this.aqMainMenuBtn_Click);
            // 
            // aqRushOptionsLabel
            // 
            this.aqRushOptionsLabel.AutoSize = true;
            this.aqRushOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqRushOptionsLabel.Location = new System.Drawing.Point(178, 124);
            this.aqRushOptionsLabel.Name = "aqRushOptionsLabel";
            this.aqRushOptionsLabel.Size = new System.Drawing.Size(103, 18);
            this.aqRushOptionsLabel.TabIndex = 11;
            this.aqRushOptionsLabel.Text = "Rush Options:";
            // 
            // aqRushSubLabel
            // 
            this.aqRushSubLabel.AutoSize = true;
            this.aqRushSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqRushSubLabel.Location = new System.Drawing.Point(178, 142);
            this.aqRushSubLabel.Name = "aqRushSubLabel";
            this.aqRushSubLabel.Size = new System.Drawing.Size(98, 13);
            this.aqRushSubLabel.TabIndex = 12;
            this.aqRushSubLabel.Text = "(14 Days Standard)";
            // 
            // aqRushOptionsCB
            // 
            this.aqRushOptionsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqRushOptionsCB.FormattingEnabled = true;
            this.aqRushOptionsCB.Items.AddRange(new object[] {
            "14",
            "7",
            "5",
            "3"});
            this.aqRushOptionsCB.Location = new System.Drawing.Point(181, 159);
            this.aqRushOptionsCB.Name = "aqRushOptionsCB";
            this.aqRushOptionsCB.Size = new System.Drawing.Size(121, 21);
            this.aqRushOptionsCB.TabIndex = 13;
            // 
            // aqSubmitBtn
            // 
            this.aqSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqSubmitBtn.Location = new System.Drawing.Point(355, 35);
            this.aqSubmitBtn.Name = "aqSubmitBtn";
            this.aqSubmitBtn.Size = new System.Drawing.Size(138, 54);
            this.aqSubmitBtn.TabIndex = 14;
            this.aqSubmitBtn.Text = "&Submit";
            this.aqSubmitBtn.UseVisualStyleBackColor = true;
            this.aqSubmitBtn.Click += new System.EventHandler(this.aqSubmitBtn_Click);
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            this.DepthErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 340);
            this.Controls.Add(this.aqSubmitBtn);
            this.Controls.Add(this.aqRushOptionsCB);
            this.Controls.Add(this.aqRushSubLabel);
            this.Controls.Add(this.aqRushOptionsLabel);
            this.Controls.Add(this.aqMainMenuBtn);
            this.Controls.Add(this.aqSurfMaterialCB);
            this.Controls.Add(this.aqSurfMaterialLabel);
            this.Controls.Add(this.aqNumDrawersCB);
            this.Controls.Add(this.agNumDrawersLabel);
            this.Controls.Add(this.aqDeskLengthTB);
            this.Controls.Add(this.agDeskDepthLabel);
            this.Controls.Add(this.aqDeskWidthTB);
            this.Controls.Add(this.aqDeskWidthLabel);
            this.Controls.Add(this.aqFullNameTB);
            this.Controls.Add(this.aqFullNameLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aqFullNameLabel;
        private System.Windows.Forms.TextBox aqFullNameTB;
        private System.Windows.Forms.Label aqDeskWidthLabel;
        private System.Windows.Forms.TextBox aqDeskWidthTB;
        private System.Windows.Forms.Label agDeskDepthLabel;
        private System.Windows.Forms.TextBox aqDeskLengthTB;
        private System.Windows.Forms.Label agNumDrawersLabel;
        private System.Windows.Forms.ComboBox aqNumDrawersCB;
        private System.Windows.Forms.Label aqSurfMaterialLabel;
        private System.Windows.Forms.ComboBox aqSurfMaterialCB;
        private System.Windows.Forms.Button aqMainMenuBtn;
        private System.Windows.Forms.Label aqRushOptionsLabel;
        private System.Windows.Forms.Label aqRushSubLabel;
        private System.Windows.Forms.ComboBox aqRushOptionsCB;
        private System.Windows.Forms.Button aqSubmitBtn;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider DepthErrorProvider;
    }
}