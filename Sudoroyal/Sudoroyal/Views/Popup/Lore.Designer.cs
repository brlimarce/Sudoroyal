
namespace Sudoroyal.Views.Popup
{
    partial class Lore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lore));
            this.btnAccept = new System.Windows.Forms.PictureBox();
            this.btnAcceptActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptActive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccept.BackgroundImage")));
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.Location = new System.Drawing.Point(75, 621);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(606, 51);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.TabStop = false;
            this.btnAccept.MouseHover += new System.EventHandler(this.btnAccept_MouseHover);
            // 
            // btnAcceptActive
            // 
            this.btnAcceptActive.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceptActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcceptActive.BackgroundImage")));
            this.btnAcceptActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptActive.Location = new System.Drawing.Point(75, 621);
            this.btnAcceptActive.Name = "btnAcceptActive";
            this.btnAcceptActive.Size = new System.Drawing.Size(606, 52);
            this.btnAcceptActive.TabIndex = 1;
            this.btnAcceptActive.TabStop = false;
            this.btnAcceptActive.Visible = false;
            this.btnAcceptActive.Click += new System.EventHandler(this.btnAcceptActive_Click);
            this.btnAcceptActive.MouseLeave += new System.EventHandler(this.btnAcceptActive_MouseLeave);
            // 
            // Lore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.ControlBox = false;
            this.Controls.Add(this.btnAcceptActive);
            this.Controls.Add(this.btnAccept);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoroyal";
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAccept;
        private System.Windows.Forms.PictureBox btnAcceptActive;
    }
}