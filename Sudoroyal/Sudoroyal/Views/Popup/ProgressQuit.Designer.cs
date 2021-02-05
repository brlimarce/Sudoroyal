
namespace Sudoroyal.Views.Popup
{
    partial class ProgressQuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressQuit));
            this.btnYay = new System.Windows.Forms.PictureBox();
            this.btnYayActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnYay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYayActive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYay
            // 
            this.btnYay.BackColor = System.Drawing.Color.Transparent;
            this.btnYay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYay.BackgroundImage")));
            this.btnYay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYay.Location = new System.Drawing.Point(58, 262);
            this.btnYay.Name = "btnYay";
            this.btnYay.Size = new System.Drawing.Size(288, 34);
            this.btnYay.TabIndex = 0;
            this.btnYay.TabStop = false;
            this.btnYay.MouseHover += new System.EventHandler(this.btnYay_MouseHover);
            // 
            // btnYayActive
            // 
            this.btnYayActive.BackColor = System.Drawing.Color.Transparent;
            this.btnYayActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYayActive.BackgroundImage")));
            this.btnYayActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYayActive.Location = new System.Drawing.Point(58, 262);
            this.btnYayActive.Name = "btnYayActive";
            this.btnYayActive.Size = new System.Drawing.Size(288, 34);
            this.btnYayActive.TabIndex = 1;
            this.btnYayActive.TabStop = false;
            this.btnYayActive.Visible = false;
            this.btnYayActive.Click += new System.EventHandler(this.btnYayActive_Click);
            this.btnYayActive.MouseLeave += new System.EventHandler(this.btnYayActive_MouseLeave);
            // 
            // ProgressQuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnYayActive);
            this.Controls.Add(this.btnYay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgressQuit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoroyal";
            ((System.ComponentModel.ISupportInitialize)(this.btnYay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYayActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnYay;
        private System.Windows.Forms.PictureBox btnYayActive;
    }
}