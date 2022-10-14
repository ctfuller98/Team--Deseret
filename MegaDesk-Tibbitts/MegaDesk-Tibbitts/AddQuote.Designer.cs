
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // aqFullNameLabel
            // 
            this.aqFullNameLabel.AutoSize = true;
            this.aqFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.aqFullNameLabel.Location = new System.Drawing.Point(18, 9);
            this.aqFullNameLabel.Name = "aqFullNameLabel";
            this.aqFullNameLabel.Size = new System.Drawing.Size(106, 25);
            this.aqFullNameLabel.TabIndex = 0;
            this.aqFullNameLabel.Text = "Full Name:";
            // 
            // aqFullNameTB
            // 
            this.aqFullNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aqFullNameTB.Location = new System.Drawing.Point(23, 37);
            this.aqFullNameTB.Name = "aqFullNameTB";
            this.aqFullNameTB.Size = new System.Drawing.Size(232, 26);
            this.aqFullNameTB.TabIndex = 1;
            this.aqFullNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.aqFullNameTB_Validating);
            // 
            // aqDeskWidthLabel
            // 
            this.aqDeskWidthLabel.AutoSize = true;
            this.aqDeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.aqDeskWidthLabel.Location = new System.Drawing.Point(18, 82);
            this.aqDeskWidthLabel.Name = "aqDeskWidthLabel";
            this.aqDeskWidthLabel.Size = new System.Drawing.Size(69, 25);
            this.aqDeskWidthLabel.TabIndex = 2;
            this.aqDeskWidthLabel.Text = "Width:";
            // 
            // aqDeskWidthTB
            // 
            this.aqDeskWidthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aqDeskWidthTB.Location = new System.Drawing.Point(97, 81);
            this.aqDeskWidthTB.Name = "aqDeskWidthTB";
            this.aqDeskWidthTB.Size = new System.Drawing.Size(57, 26);
            this.aqDeskWidthTB.TabIndex = 3;
            this.aqDeskWidthTB.TextChanged += new System.EventHandler(this.aqDeskWidthTB_TextChanged);
            this.aqDeskWidthTB.Validating += new System.ComponentModel.CancelEventHandler(this.aqDeskWidthTB_Validating);
            this.aqDeskWidthTB.Validated += new System.EventHandler(this.aqDeskWidthTB_Validated);
            // 
            // agDeskDepthLabel
            // 
            this.agDeskDepthLabel.AutoSize = true;
            this.agDeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.agDeskDepthLabel.Location = new System.Drawing.Point(174, 81);
            this.agDeskDepthLabel.Name = "agDeskDepthLabel";
            this.agDeskDepthLabel.Size = new System.Drawing.Size(75, 25);
            this.agDeskDepthLabel.TabIndex = 4;
            this.agDeskDepthLabel.Text = "Depth: ";
            // 
            // aqDeskLengthTB
            // 
            this.aqDeskLengthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aqDeskLengthTB.Location = new System.Drawing.Point(247, 81);
            this.aqDeskLengthTB.Name = "aqDeskLengthTB";
            this.aqDeskLengthTB.Size = new System.Drawing.Size(58, 26);
            this.aqDeskLengthTB.TabIndex = 5;
            this.aqDeskLengthTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aqDeskDepthTB_KeyDown);
            this.aqDeskLengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aqDeskDepthTB_KeyPress);
            // 
            // agNumDrawersLabel
            // 
            this.agNumDrawersLabel.AutoSize = true;
            this.agNumDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.agNumDrawersLabel.Location = new System.Drawing.Point(18, 140);
            this.agNumDrawersLabel.Name = "agNumDrawersLabel";
            this.agNumDrawersLabel.Size = new System.Drawing.Size(90, 25);
            this.agNumDrawersLabel.TabIndex = 6;
            this.agNumDrawersLabel.Text = "Drawers:";
            // 
            // aqNumDrawersCB
            // 
            this.aqNumDrawersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqNumDrawersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.aqNumDrawersCB.Location = new System.Drawing.Point(114, 141);
            this.aqNumDrawersCB.Name = "aqNumDrawersCB";
            this.aqNumDrawersCB.Size = new System.Drawing.Size(121, 28);
            this.aqNumDrawersCB.TabIndex = 7;
            // 
            // aqSurfMaterialLabel
            // 
            this.aqSurfMaterialLabel.AutoSize = true;
            this.aqSurfMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.aqSurfMaterialLabel.Location = new System.Drawing.Point(18, 181);
            this.aqSurfMaterialLabel.Name = "aqSurfMaterialLabel";
            this.aqSurfMaterialLabel.Size = new System.Drawing.Size(160, 25);
            this.aqSurfMaterialLabel.TabIndex = 8;
            this.aqSurfMaterialLabel.Text = "Surface Material:";
            // 
            // aqSurfMaterialCB
            // 
            this.aqSurfMaterialCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqSurfMaterialCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aqSurfMaterialCB.FormattingEnabled = true;
            this.aqSurfMaterialCB.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.aqSurfMaterialCB.Location = new System.Drawing.Point(160, 224);
            this.aqSurfMaterialCB.Name = "aqSurfMaterialCB";
            this.aqSurfMaterialCB.Size = new System.Drawing.Size(121, 28);
            this.aqSurfMaterialCB.TabIndex = 9;
            // 
            // aqMainMenuBtn
            // 
            this.aqMainMenuBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.aqMainMenuBtn.Location = new System.Drawing.Point(23, 294);
            this.aqMainMenuBtn.Name = "aqMainMenuBtn";
            this.aqMainMenuBtn.Size = new System.Drawing.Size(100, 47);
            this.aqMainMenuBtn.TabIndex = 10;
            this.aqMainMenuBtn.Text = "&Main Menu";
            this.aqMainMenuBtn.UseVisualStyleBackColor = true;
            this.aqMainMenuBtn.Click += new System.EventHandler(this.aqMainMenuBtn_Click);
            // 
            // aqRushOptionsLabel
            // 
            this.aqRushOptionsLabel.AutoSize = true;
            this.aqRushOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.aqRushOptionsLabel.Location = new System.Drawing.Point(18, 223);
            this.aqRushOptionsLabel.Name = "aqRushOptionsLabel";
            this.aqRushOptionsLabel.Size = new System.Drawing.Size(136, 25);
            this.aqRushOptionsLabel.TabIndex = 11;
            this.aqRushOptionsLabel.Text = "Rush Options:";
            // 
            // aqRushSubLabel
            // 
            this.aqRushSubLabel.AutoSize = true;
            this.aqRushSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqRushSubLabel.Location = new System.Drawing.Point(20, 248);
            this.aqRushSubLabel.Name = "aqRushSubLabel";
            this.aqRushSubLabel.Size = new System.Drawing.Size(98, 13);
            this.aqRushSubLabel.TabIndex = 12;
            this.aqRushSubLabel.Text = "(14 Days Standard)";
            // 
            // aqRushOptionsCB
            // 
            this.aqRushOptionsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqRushOptionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aqRushOptionsCB.FormattingEnabled = true;
            this.aqRushOptionsCB.Items.AddRange(new object[] {
            "14",
            "7",
            "5",
            "3"});
            this.aqRushOptionsCB.Location = new System.Drawing.Point(184, 182);
            this.aqRushOptionsCB.Name = "aqRushOptionsCB";
            this.aqRushOptionsCB.Size = new System.Drawing.Size(121, 28);
            this.aqRushOptionsCB.TabIndex = 13;
            // 
            // aqSubmitBtn
            // 
            this.aqSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.aqSubmitBtn.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aqSubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aqSubmitBtn.Location = new System.Drawing.Point(160, 287);
            this.aqSubmitBtn.Name = "aqSubmitBtn";
            this.aqSubmitBtn.Size = new System.Drawing.Size(138, 54);
            this.aqSubmitBtn.TabIndex = 14;
            this.aqSubmitBtn.Text = "&Submit";
            this.aqSubmitBtn.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "(24 - 96 inches)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "(12 - 48 inches)";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 381);
            this.Controls.Add(this.aqSubmitBtn);
            this.Controls.Add(this.aqRushOptionsCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}