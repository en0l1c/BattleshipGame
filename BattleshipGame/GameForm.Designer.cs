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
            ((System.ComponentModel.ISupportInitialize)(this.enemysFieldPbox)).BeginInit();
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
            this.enemysFieldPbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enemysFieldPbox_MouseClick);
            this.enemysFieldPbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.enemysFieldPbox_MouseMove);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 487);
            this.Controls.Add(this.enemysFieldPbox);
            this.Name = "GameForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.enemysFieldPbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox enemysFieldPbox;
    }
}