
namespace MegaDesk_Tibbitts
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mmAddBtn = new System.Windows.Forms.Button();
            this.mmViewBtn = new System.Windows.Forms.Button();
            this.mmSearchBtn = new System.Windows.Forms.Button();
            this.mmExitBtn = new System.Windows.Forms.Button();
            this.mmPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mmPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mmAddBtn
            // 
            this.mmAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mmAddBtn.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmAddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mmAddBtn.Location = new System.Drawing.Point(22, 65);
            this.mmAddBtn.Name = "mmAddBtn";
            this.mmAddBtn.Size = new System.Drawing.Size(200, 50);
            this.mmAddBtn.TabIndex = 0;
            this.mmAddBtn.Text = "&Add New Quote";
            this.mmAddBtn.UseVisualStyleBackColor = false;
            this.mmAddBtn.Click += new System.EventHandler(this.mmAddBtn_Click);
            // 
            // mmViewBtn
            // 
            this.mmViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mmViewBtn.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmViewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mmViewBtn.Location = new System.Drawing.Point(22, 141);
            this.mmViewBtn.Name = "mmViewBtn";
            this.mmViewBtn.Size = new System.Drawing.Size(200, 50);
            this.mmViewBtn.TabIndex = 1;
            this.mmViewBtn.Text = "&View Quotes";
            this.mmViewBtn.UseVisualStyleBackColor = false;
            this.mmViewBtn.Click += new System.EventHandler(this.mmViewBtn_Click);
            // 
            // mmSearchBtn
            // 
            this.mmSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mmSearchBtn.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmSearchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mmSearchBtn.Location = new System.Drawing.Point(22, 221);
            this.mmSearchBtn.Name = "mmSearchBtn";
            this.mmSearchBtn.Size = new System.Drawing.Size(200, 50);
            this.mmSearchBtn.TabIndex = 2;
            this.mmSearchBtn.Text = "&Search Quotes";
            this.mmSearchBtn.UseVisualStyleBackColor = false;
            this.mmSearchBtn.Click += new System.EventHandler(this.mmSearchBtn_Click);
            // 
            // mmExitBtn
            // 
            this.mmExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mmExitBtn.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmExitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mmExitBtn.Location = new System.Drawing.Point(22, 295);
            this.mmExitBtn.Name = "mmExitBtn";
            this.mmExitBtn.Size = new System.Drawing.Size(200, 50);
            this.mmExitBtn.TabIndex = 3;
            this.mmExitBtn.Text = "E&xit";
            this.mmExitBtn.UseVisualStyleBackColor = false;
            this.mmExitBtn.Click += new System.EventHandler(this.mmExitBtn_Click);
            // 
            // mmPicBox
            // 
            this.mmPicBox.Image = global::MegaDesk_Tibbitts.Properties.Resources.MegaDesk;
            this.mmPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("mmPicBox.InitialImage")));
            this.mmPicBox.Location = new System.Drawing.Point(254, 40);
            this.mmPicBox.Name = "mmPicBox";
            this.mmPicBox.Size = new System.Drawing.Size(413, 343);
            this.mmPicBox.TabIndex = 4;
            this.mmPicBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 413);
            this.Controls.Add(this.mmPicBox);
            this.Controls.Add(this.mmExitBtn);
            this.Controls.Add(this.mmSearchBtn);
            this.Controls.Add(this.mmViewBtn);
            this.Controls.Add(this.mmAddBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.mmPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mmAddBtn;
        private System.Windows.Forms.Button mmViewBtn;
        private System.Windows.Forms.Button mmSearchBtn;
        private System.Windows.Forms.Button mmExitBtn;
        private System.Windows.Forms.PictureBox mmPicBox;
    }
}

