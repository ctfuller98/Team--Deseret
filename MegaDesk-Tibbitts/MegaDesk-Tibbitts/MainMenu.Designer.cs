
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
            this.mmAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmAddBtn.Location = new System.Drawing.Point(22, 26);
            this.mmAddBtn.Name = "mmAddBtn";
            this.mmAddBtn.Size = new System.Drawing.Size(200, 50);
            this.mmAddBtn.TabIndex = 0;
            this.mmAddBtn.Text = "&Add New Quote";
            this.mmAddBtn.UseVisualStyleBackColor = true;
            this.mmAddBtn.Click += new System.EventHandler(this.mmAddBtn_Click);
            // 
            // mmViewBtn
            // 
            this.mmViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmViewBtn.Location = new System.Drawing.Point(22, 94);
            this.mmViewBtn.Name = "mmViewBtn";
            this.mmViewBtn.Size = new System.Drawing.Size(200, 50);
            this.mmViewBtn.TabIndex = 1;
            this.mmViewBtn.Text = "&View Quotes";
            this.mmViewBtn.UseVisualStyleBackColor = true;
            this.mmViewBtn.Click += new System.EventHandler(this.mmViewBtn_Click);
            // 
            // mmSearchBtn
            // 
            this.mmSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmSearchBtn.Location = new System.Drawing.Point(22, 160);
            this.mmSearchBtn.Name = "mmSearchBtn";
            this.mmSearchBtn.Size = new System.Drawing.Size(200, 50);
            this.mmSearchBtn.TabIndex = 2;
            this.mmSearchBtn.Text = "&Search Quotes";
            this.mmSearchBtn.UseVisualStyleBackColor = true;
            this.mmSearchBtn.Click += new System.EventHandler(this.mmSearchBtn_Click);
            // 
            // mmExitBtn
            // 
            this.mmExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmExitBtn.Location = new System.Drawing.Point(22, 225);
            this.mmExitBtn.Name = "mmExitBtn";
            this.mmExitBtn.Size = new System.Drawing.Size(200, 50);
            this.mmExitBtn.TabIndex = 3;
            this.mmExitBtn.Text = "E&xit";
            this.mmExitBtn.UseVisualStyleBackColor = true;
            this.mmExitBtn.Click += new System.EventHandler(this.mmExitBtn_Click);
            // 
            // mmPicBox
            // 
            this.mmPicBox.Image = global::MegaDesk_Tibbitts.Properties.Resources.MegaDesk;
            this.mmPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("mmPicBox.InitialImage")));
            this.mmPicBox.Location = new System.Drawing.Point(270, 26);
            this.mmPicBox.Name = "mmPicBox";
            this.mmPicBox.Size = new System.Drawing.Size(413, 343);
            this.mmPicBox.TabIndex = 4;
            this.mmPicBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 413);
            this.Controls.Add(this.mmPicBox);
            this.Controls.Add(this.mmExitBtn);
            this.Controls.Add(this.mmSearchBtn);
            this.Controls.Add(this.mmViewBtn);
            this.Controls.Add(this.mmAddBtn);
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

