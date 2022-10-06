
namespace MegaDesk_Tibbitts
{
    partial class ViewAllQuotes
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
            this.vqMainMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vqMainMenuBtn
            // 
            this.vqMainMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vqMainMenuBtn.Location = new System.Drawing.Point(614, 346);
            this.vqMainMenuBtn.Name = "vqMainMenuBtn";
            this.vqMainMenuBtn.Size = new System.Drawing.Size(138, 54);
            this.vqMainMenuBtn.TabIndex = 0;
            this.vqMainMenuBtn.Text = "&Main Menu";
            this.vqMainMenuBtn.UseVisualStyleBackColor = true;
            this.vqMainMenuBtn.Click += new System.EventHandler(this.vqMainMenuBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vqMainMenuBtn);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vqMainMenuBtn;
    }
}