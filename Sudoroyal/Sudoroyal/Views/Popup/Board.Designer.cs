
namespace Sudoroyal.Views.Popup
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.lblKing = new System.Windows.Forms.Label();
            this.lblQueen = new System.Windows.Forms.Label();
            this.btnKing = new System.Windows.Forms.PictureBox();
            this.btnKingActive = new System.Windows.Forms.PictureBox();
            this.btnQueenActive = new System.Windows.Forms.PictureBox();
            this.btnQueen = new System.Windows.Forms.PictureBox();
            this.btnKingChosen = new System.Windows.Forms.PictureBox();
            this.btnQueenChosen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKingActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueenActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKingChosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueenChosen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKing
            // 
            this.lblKing.AutoSize = true;
            this.lblKing.BackColor = System.Drawing.Color.Transparent;
            this.lblKing.Font = new System.Drawing.Font("Gotham Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblKing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblKing.Location = new System.Drawing.Point(223, 399);
            this.lblKing.Name = "lblKing";
            this.lblKing.Size = new System.Drawing.Size(73, 22);
            this.lblKing.TabIndex = 0;
            this.lblKing.Text = "King 9";
            // 
            // lblQueen
            // 
            this.lblQueen.AutoSize = true;
            this.lblQueen.BackColor = System.Drawing.Color.Transparent;
            this.lblQueen.Font = new System.Drawing.Font("Gotham Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblQueen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.lblQueen.Location = new System.Drawing.Point(544, 399);
            this.lblQueen.Name = "lblQueen";
            this.lblQueen.Size = new System.Drawing.Size(100, 22);
            this.lblQueen.TabIndex = 1;
            this.lblQueen.Text = "Queen 16";
            // 
            // btnKing
            // 
            this.btnKing.BackColor = System.Drawing.Color.Transparent;
            this.btnKing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKing.BackgroundImage")));
            this.btnKing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKing.Location = new System.Drawing.Point(185, 173);
            this.btnKing.Name = "btnKing";
            this.btnKing.Size = new System.Drawing.Size(154, 212);
            this.btnKing.TabIndex = 2;
            this.btnKing.TabStop = false;
            this.btnKing.Visible = false;
            this.btnKing.MouseHover += new System.EventHandler(this.btnKing_MouseHover);
            // 
            // btnKingActive
            // 
            this.btnKingActive.BackColor = System.Drawing.Color.Transparent;
            this.btnKingActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKingActive.BackgroundImage")));
            this.btnKingActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKingActive.Location = new System.Drawing.Point(185, 173);
            this.btnKingActive.Name = "btnKingActive";
            this.btnKingActive.Size = new System.Drawing.Size(154, 212);
            this.btnKingActive.TabIndex = 3;
            this.btnKingActive.TabStop = false;
            this.btnKingActive.Visible = false;
            this.btnKingActive.Click += new System.EventHandler(this.btnKingActive_Click);
            this.btnKingActive.MouseLeave += new System.EventHandler(this.btnKingActive_MouseLeave);
            // 
            // btnQueenActive
            // 
            this.btnQueenActive.BackColor = System.Drawing.Color.Transparent;
            this.btnQueenActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueenActive.BackgroundImage")));
            this.btnQueenActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueenActive.Location = new System.Drawing.Point(515, 173);
            this.btnQueenActive.Name = "btnQueenActive";
            this.btnQueenActive.Size = new System.Drawing.Size(154, 212);
            this.btnQueenActive.TabIndex = 5;
            this.btnQueenActive.TabStop = false;
            this.btnQueenActive.Visible = false;
            this.btnQueenActive.Click += new System.EventHandler(this.btnQueenActive_Click);
            this.btnQueenActive.MouseLeave += new System.EventHandler(this.btnQueenActive_MouseLeave);
            // 
            // btnQueen
            // 
            this.btnQueen.BackColor = System.Drawing.Color.Transparent;
            this.btnQueen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueen.BackgroundImage")));
            this.btnQueen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueen.Location = new System.Drawing.Point(515, 173);
            this.btnQueen.Name = "btnQueen";
            this.btnQueen.Size = new System.Drawing.Size(154, 212);
            this.btnQueen.TabIndex = 4;
            this.btnQueen.TabStop = false;
            this.btnQueen.Visible = false;
            this.btnQueen.MouseHover += new System.EventHandler(this.btnQueen_MouseHover);
            // 
            // btnKingChosen
            // 
            this.btnKingChosen.BackColor = System.Drawing.Color.Transparent;
            this.btnKingChosen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKingChosen.BackgroundImage")));
            this.btnKingChosen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKingChosen.Location = new System.Drawing.Point(185, 173);
            this.btnKingChosen.Name = "btnKingChosen";
            this.btnKingChosen.Size = new System.Drawing.Size(154, 212);
            this.btnKingChosen.TabIndex = 6;
            this.btnKingChosen.TabStop = false;
            this.btnKingChosen.Visible = false;
            // 
            // btnQueenChosen
            // 
            this.btnQueenChosen.BackColor = System.Drawing.Color.Transparent;
            this.btnQueenChosen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQueenChosen.BackgroundImage")));
            this.btnQueenChosen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQueenChosen.Location = new System.Drawing.Point(515, 173);
            this.btnQueenChosen.Name = "btnQueenChosen";
            this.btnQueenChosen.Size = new System.Drawing.Size(154, 212);
            this.btnQueenChosen.TabIndex = 7;
            this.btnQueenChosen.TabStop = false;
            this.btnQueenChosen.Visible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 521);
            this.Controls.Add(this.btnQueenChosen);
            this.Controls.Add(this.btnKingChosen);
            this.Controls.Add(this.btnQueenActive);
            this.Controls.Add(this.btnQueen);
            this.Controls.Add(this.btnKingActive);
            this.Controls.Add(this.btnKing);
            this.Controls.Add(this.lblQueen);
            this.Controls.Add(this.lblKing);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoroyal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Board_FormClosed);
            this.Load += new System.EventHandler(this.Board_Load);
            this.Shown += new System.EventHandler(this.Board_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.btnKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKingActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueenActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKingChosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQueenChosen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKing;
        private System.Windows.Forms.Label lblQueen;
        private System.Windows.Forms.PictureBox btnKing;
        private System.Windows.Forms.PictureBox btnKingActive;
        private System.Windows.Forms.PictureBox btnQueenActive;
        private System.Windows.Forms.PictureBox btnQueen;
        private System.Windows.Forms.PictureBox btnKingChosen;
        private System.Windows.Forms.PictureBox btnQueenChosen;
    }
}