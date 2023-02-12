namespace BattleshipGame
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enemysFieldPbox = new System.Windows.Forms.PictureBox();
            this.playersFieldPbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemysFieldPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersFieldPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // enemysFieldPbox
            // 
            this.enemysFieldPbox.Image = global::BattleshipGame.Properties.Resources.battlefield1;
            this.enemysFieldPbox.Location = new System.Drawing.Point(72, 12);
            this.enemysFieldPbox.Name = "enemysFieldPbox";
            this.enemysFieldPbox.Size = new System.Drawing.Size(377, 377);
            this.enemysFieldPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemysFieldPbox.TabIndex = 0;
            this.enemysFieldPbox.TabStop = false;
            this.enemysFieldPbox.Click += new System.EventHandler(this.enemysFieldPbox_Click);
            this.enemysFieldPbox.Paint += new System.Windows.Forms.PaintEventHandler(this.enemysFieldPbox_Paint);
            this.enemysFieldPbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enemysFieldPbox_MouseClick);
            this.enemysFieldPbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.enemysFieldPbox_MouseMove);
            // 
            // playersFieldPbox
            // 
            this.playersFieldPbox.Image = global::BattleshipGame.Properties.Resources.battlefield2;
            this.playersFieldPbox.Location = new System.Drawing.Point(539, 12);
            this.playersFieldPbox.Name = "playersFieldPbox";
            this.playersFieldPbox.Size = new System.Drawing.Size(377, 377);
            this.playersFieldPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playersFieldPbox.TabIndex = 1;
            this.playersFieldPbox.TabStop = false;
            this.playersFieldPbox.Paint += new System.Windows.Forms.PaintEventHandler(this.playersFieldPbox_Paint);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 487);
            this.Controls.Add(this.playersFieldPbox);
            this.Controls.Add(this.enemysFieldPbox);
            this.Name = "GameForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.enemysFieldPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersFieldPbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox enemysFieldPbox;
        private PictureBox playersFieldPbox;
    }
}