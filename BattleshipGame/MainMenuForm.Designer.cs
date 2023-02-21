namespace BattleshipGame
{
    partial class MainMenuForm
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
            this.playersNameTbox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.viewGameStatsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playersNameTbox
            // 
            this.playersNameTbox.Location = new System.Drawing.Point(151, 34);
            this.playersNameTbox.Name = "playersNameTbox";
            this.playersNameTbox.Size = new System.Drawing.Size(186, 23);
            this.playersNameTbox.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(116, 112);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // viewGameStatsBtn
            // 
            this.viewGameStatsBtn.Location = new System.Drawing.Point(77, 170);
            this.viewGameStatsBtn.Name = "viewGameStatsBtn";
            this.viewGameStatsBtn.Size = new System.Drawing.Size(148, 23);
            this.viewGameStatsBtn.TabIndex = 2;
            this.viewGameStatsBtn.Text = "Previous Games Statistics";
            this.viewGameStatsBtn.UseVisualStyleBackColor = true;
            this.viewGameStatsBtn.Click += new System.EventHandler(this.viewGameStatsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your name:";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleshipGame.Properties.Resources.main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewGameStatsBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.playersNameTbox);
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox playersNameTbox;
        private Button startBtn;
        private Button viewGameStatsBtn;
        private Label label1;
    }
}