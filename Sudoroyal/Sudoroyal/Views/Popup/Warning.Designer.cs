
namespace Sudoroyal.Views.Popup
{
    partial class Warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.btnSwitch = new System.Windows.Forms.PictureBox();
            this.btnSwitchActive = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnCancelActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitchActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelActive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.BackgroundImage")));
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.Location = new System.Drawing.Point(46, 276);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(310, 34);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.TabStop = false;
            this.btnSwitch.MouseHover += new System.EventHandler(this.btnSwitch_MouseHover);
            // 
            // btnSwitchActive
            // 
            this.btnSwitchActive.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitchActive.BackgroundImage")));
            this.btnSwitchActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchActive.Location = new System.Drawing.Point(46, 276);
            this.btnSwitchActive.Name = "btnSwitchActive";
            this.btnSwitchActive.Size = new System.Drawing.Size(310, 34);
            this.btnSwitchActive.TabIndex = 1;
            this.btnSwitchActive.TabStop = false;
            this.btnSwitchActive.Visible = false;
            this.btnSwitchActive.Click += new System.EventHandler(this.btnSwitchActive_Click);
            this.btnSwitchActive.MouseLeave += new System.EventHandler(this.btnSwitchActive_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(46, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(310, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnCancelActive
            // 
            this.btnCancelActive.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelActive.BackgroundImage")));
            this.btnCancelActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelActive.Location = new System.Drawing.Point(46, 318);
            this.btnCancelActive.Name = "btnCancelActive";
            this.btnCancelActive.Size = new System.Drawing.Size(310, 34);
            this.btnCancelActive.TabIndex = 3;
            this.btnCancelActive.TabStop = false;
            this.btnCancelActive.Visible = false;
            this.btnCancelActive.Click += new System.EventHandler(this.btnCancelActive_Click);
            this.btnCancelActive.MouseLeave += new System.EventHandler(this.btnCancelActive_MouseLeave);
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelActive);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSwitchActive);
            this.Controls.Add(this.btnSwitch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoroyal";
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwitchActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSwitch;
        private System.Windows.Forms.PictureBox btnSwitchActive;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox btnCancelActive;
    }
}