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
            this.components = new System.ComponentModel.Container();
            this.enemysFieldPbox = new System.Windows.Forms.PictureBox();
            this.playersFieldPbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.battlelogRTbox = new System.Windows.Forms.RichTextBox();
            this.whosTurnLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundNumLabel = new System.Windows.Forms.Label();
            this.newGameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTakenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemysFieldPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersFieldPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // enemysFieldPbox
            // 
            this.enemysFieldPbox.Image = global::BattleshipGame.Properties.Resources.battlefield1;
            this.enemysFieldPbox.Location = new System.Drawing.Point(48, 139);
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
            this.playersFieldPbox.Location = new System.Drawing.Point(526, 139);
            this.playersFieldPbox.Name = "playersFieldPbox";
            this.playersFieldPbox.Size = new System.Drawing.Size(377, 377);
            this.playersFieldPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playersFieldPbox.TabIndex = 1;
            this.playersFieldPbox.TabStop = false;
            this.playersFieldPbox.Paint += new System.Windows.Forms.PaintEventHandler(this.playersFieldPbox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(11, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Α";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Β";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(11, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Γ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(11, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Δ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(11, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ε";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(11, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ζ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(11, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Η";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(11, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Θ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(11, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ι";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(11, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Κ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(81, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 32);
            this.label11.TabIndex = 12;
            this.label11.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(113, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 32);
            this.label12.TabIndex = 13;
            this.label12.Text = "2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(145, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 32);
            this.label13.TabIndex = 14;
            this.label13.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(177, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 32);
            this.label14.TabIndex = 15;
            this.label14.Text = "4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(209, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 32);
            this.label15.TabIndex = 16;
            this.label15.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(241, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 32);
            this.label16.TabIndex = 17;
            this.label16.Text = "6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(273, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 32);
            this.label17.TabIndex = 18;
            this.label17.Text = "7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label18.Location = new System.Drawing.Point(305, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 32);
            this.label18.TabIndex = 19;
            this.label18.Text = "8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Location = new System.Drawing.Point(336, 104);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 32);
            this.label19.TabIndex = 20;
            this.label19.Text = "9";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(361, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 32);
            this.label20.TabIndex = 21;
            this.label20.Text = "10";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(490, 454);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 32);
            this.label21.TabIndex = 31;
            this.label21.Text = "Κ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(490, 422);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 32);
            this.label22.TabIndex = 30;
            this.label22.Text = "Ι";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(490, 390);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 32);
            this.label23.TabIndex = 29;
            this.label23.Text = "Θ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(490, 358);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 32);
            this.label24.TabIndex = 28;
            this.label24.Text = "Η";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(490, 326);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 32);
            this.label25.TabIndex = 27;
            this.label25.Text = "Ζ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(490, 294);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 32);
            this.label26.TabIndex = 26;
            this.label26.Text = "Ε";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(490, 262);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 32);
            this.label27.TabIndex = 25;
            this.label27.Text = "Δ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(490, 230);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 32);
            this.label28.TabIndex = 24;
            this.label28.Text = "Γ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(490, 198);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 32);
            this.label29.TabIndex = 23;
            this.label29.Text = "Β";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.Location = new System.Drawing.Point(490, 166);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 32);
            this.label30.TabIndex = 22;
            this.label30.Text = "Α";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label31.Location = new System.Drawing.Point(836, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 32);
            this.label31.TabIndex = 41;
            this.label31.Text = "10";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label32.Location = new System.Drawing.Point(811, 104);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(28, 32);
            this.label32.TabIndex = 40;
            this.label32.Text = "9";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label33.Location = new System.Drawing.Point(780, 104);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 32);
            this.label33.TabIndex = 39;
            this.label33.Text = "8";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label34.Location = new System.Drawing.Point(748, 104);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(28, 32);
            this.label34.TabIndex = 38;
            this.label34.Text = "7";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label35.Location = new System.Drawing.Point(716, 104);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 32);
            this.label35.TabIndex = 37;
            this.label35.Text = "6";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label36.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label36.Location = new System.Drawing.Point(684, 104);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(28, 32);
            this.label36.TabIndex = 36;
            this.label36.Text = "5";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label37.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label37.Location = new System.Drawing.Point(652, 104);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 32);
            this.label37.TabIndex = 35;
            this.label37.Text = "4";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label38.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label38.Location = new System.Drawing.Point(620, 104);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(28, 32);
            this.label38.TabIndex = 34;
            this.label38.Text = "3";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label39.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label39.Location = new System.Drawing.Point(588, 104);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(28, 32);
            this.label39.TabIndex = 33;
            this.label39.Text = "2";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label40.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label40.Location = new System.Drawing.Point(556, 104);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(28, 32);
            this.label40.TabIndex = 32;
            this.label40.Text = "1";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label41.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label41.Location = new System.Drawing.Point(663, 40);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(113, 45);
            this.label41.TabIndex = 42;
            this.label41.Text = "Player";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label42.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label42.Location = new System.Drawing.Point(154, 40);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(170, 45);
            this.label42.TabIndex = 43;
            this.label42.Text = "Computer";
            // 
            // battlelogRTbox
            // 
            this.battlelogRTbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.battlelogRTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.battlelogRTbox.ForeColor = System.Drawing.SystemColors.Control;
            this.battlelogRTbox.Location = new System.Drawing.Point(48, 639);
            this.battlelogRTbox.Name = "battlelogRTbox";
            this.battlelogRTbox.Size = new System.Drawing.Size(855, 163);
            this.battlelogRTbox.TabIndex = 44;
            this.battlelogRTbox.Text = "";
            // 
            // whosTurnLabel
            // 
            this.whosTurnLabel.AutoSize = true;
            this.whosTurnLabel.BackColor = System.Drawing.Color.Transparent;
            this.whosTurnLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.whosTurnLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.whosTurnLabel.Location = new System.Drawing.Point(385, 551);
            this.whosTurnLabel.Name = "whosTurnLabel";
            this.whosTurnLabel.Size = new System.Drawing.Size(0, 45);
            this.whosTurnLabel.TabIndex = 45;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.roundLabel.Location = new System.Drawing.Point(375, 519);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(127, 45);
            this.roundLabel.TabIndex = 46;
            this.roundLabel.Text = "Round:";
            // 
            // roundNumLabel
            // 
            this.roundNumLabel.AutoSize = true;
            this.roundNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundNumLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundNumLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.roundNumLabel.Location = new System.Drawing.Point(490, 519);
            this.roundNumLabel.Name = "roundNumLabel";
            this.roundNumLabel.Size = new System.Drawing.Size(0, 45);
            this.roundNumLabel.TabIndex = 47;
            // 
            // newGameLabel
            // 
            this.newGameLabel.AutoSize = true;
            this.newGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.newGameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newGameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.newGameLabel.Location = new System.Drawing.Point(361, 579);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(220, 45);
            this.newGameLabel.TabIndex = 48;
            this.newGameLabel.Text = "↺ New Game";
            this.newGameLabel.Visible = false;
            this.newGameLabel.Click += new System.EventHandler(this.newGameLabel_Click);
            this.newGameLabel.MouseEnter += new System.EventHandler(this.newGameLabel_MouseEnter);
            this.newGameLabel.MouseLeave += new System.EventHandler(this.newGameLabel_MouseLeave);
            this.newGameLabel.MouseHover += new System.EventHandler(this.newGameLabel_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timeLabel.Location = new System.Drawing.Point(48, 591);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(199, 45);
            this.timeLabel.TabIndex = 49;
            this.timeLabel.Text = "Time Taken:";
            this.timeLabel.Visible = false;
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakenLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeTakenLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timeTakenLabel.Location = new System.Drawing.Point(241, 591);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(0, 45);
            this.timeTakenLabel.TabIndex = 50;
            this.timeTakenLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleshipGame.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 831);
            this.Controls.Add(this.timeTakenLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.newGameLabel);
            this.Controls.Add(this.roundNumLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.whosTurnLabel);
            this.Controls.Add(this.battlelogRTbox);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playersFieldPbox);
            this.Controls.Add(this.enemysFieldPbox);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemysFieldPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersFieldPbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox enemysFieldPbox;
        private PictureBox playersFieldPbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private RichTextBox battlelogRTbox;
        private Label whosTurnLabel;
        private Label roundLabel;
        private Label roundNumLabel;
        private Label newGameLabel;
        private System.Windows.Forms.Timer timer1;
        private Label timeLabel;
        private Label timeTakenLabel;
    }
}