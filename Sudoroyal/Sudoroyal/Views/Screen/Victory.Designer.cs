
namespace Sudoroyal.Views.Popup
{
    partial class Victory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Victory));
            this.btnTry = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnMenuActive = new System.Windows.Forms.PictureBox();
            this.btnTryActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnTry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTryActive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.Color.Transparent;
            this.btnTry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTry.BackgroundImage")));
            this.btnTry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTry.Location = new System.Drawing.Point(389, 559);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(264, 69);
            this.btnTry.TabIndex = 0;
            this.btnTry.TabStop = false;
            this.btnTry.MouseHover += new System.EventHandler(this.btnTry_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(717, 559);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(264, 69);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // btnMenuActive
            // 
            this.btnMenuActive.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuActive.BackgroundImage")));
            this.btnMenuActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuActive.Location = new System.Drawing.Point(717, 559);
            this.btnMenuActive.Name = "btnMenuActive";
            this.btnMenuActive.Size = new System.Drawing.Size(264, 69);
            this.btnMenuActive.TabIndex = 3;
            this.btnMenuActive.TabStop = false;
            this.btnMenuActive.Visible = false;
            this.btnMenuActive.Click += new System.EventHandler(this.btnMenuActive_Click);
            this.btnMenuActive.MouseLeave += new System.EventHandler(this.btnMenuActive_MouseLeave);
            // 
            // btnTryActive
            // 
            this.btnTryActive.BackColor = System.Drawing.Color.Transparent;
            this.btnTryActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTryActive.BackgroundImage")));
            this.btnTryActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTryActive.Location = new System.Drawing.Point(389, 559);
            this.btnTryActive.Name = "btnTryActive";
            this.btnTryActive.Size = new System.Drawing.Size(264, 69);
            this.btnTryActive.TabIndex = 2;
            this.btnTryActive.TabStop = false;
            this.btnTryActive.Visible = false;
            this.btnTryActive.Click += new System.EventHandler(this.btnTryActive_Click);
            this.btnTryActive.MouseLeave += new System.EventHandler(this.btnTryActive_MouseLeave);
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenuActive);
            this.Controls.Add(this.btnTryActive);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnTry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Victory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoroyal";
            ((System.ComponentModel.ISupportInitialize)(this.btnTry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTryActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnTry;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnMenuActive;
        private System.Windows.Forms.PictureBox btnTryActive;
    }
}