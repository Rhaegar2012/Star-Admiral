namespace Star_Admiral_V0._0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fireButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerShipAtk = new System.Windows.Forms.Label();
            this.playerShipDef = new System.Windows.Forms.Label();
            this.playerShipHlt = new System.Windows.Forms.Label();
            this.enemyShipAtk = new System.Windows.Forms.Label();
            this.enemyShipDef = new System.Windows.Forms.Label();
            this.enemyShipHlt = new System.Windows.Forms.Label();
            this.playerShipName = new System.Windows.Forms.Label();
            this.enemyShipName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.pass_Button = new System.Windows.Forms.Button();
            this.ProxAlert = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fireButton
            // 
            this.fireButton.Location = new System.Drawing.Point(1376, 257);
            this.fireButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(167, 59);
            this.fireButton.TabIndex = 2;
            this.fireButton.Text = "FIRE!";
            this.fireButton.UseVisualStyleBackColor = true;
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1163, 802);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "YOUR SHIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1317, 802);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENEMY SHIP";
            // 
            // playerShipAtk
            // 
            this.playerShipAtk.AutoSize = true;
            this.playerShipAtk.Location = new System.Drawing.Point(1163, 702);
            this.playerShipAtk.Name = "playerShipAtk";
            this.playerShipAtk.Size = new System.Drawing.Size(63, 17);
            this.playerShipAtk.TabIndex = 5;
            this.playerShipAtk.Text = "Attack: 0";
            // 
            // playerShipDef
            // 
            this.playerShipDef.AutoSize = true;
            this.playerShipDef.Location = new System.Drawing.Point(1163, 737);
            this.playerShipDef.Name = "playerShipDef";
            this.playerShipDef.Size = new System.Drawing.Size(77, 17);
            this.playerShipDef.TabIndex = 6;
            this.playerShipDef.Text = "Defense: 0";
            // 
            // playerShipHlt
            // 
            this.playerShipHlt.AutoSize = true;
            this.playerShipHlt.Location = new System.Drawing.Point(1163, 770);
            this.playerShipHlt.Name = "playerShipHlt";
            this.playerShipHlt.Size = new System.Drawing.Size(65, 17);
            this.playerShipHlt.TabIndex = 7;
            this.playerShipHlt.Text = "Health: 0";
            // 
            // enemyShipAtk
            // 
            this.enemyShipAtk.AutoSize = true;
            this.enemyShipAtk.Location = new System.Drawing.Point(1317, 702);
            this.enemyShipAtk.Name = "enemyShipAtk";
            this.enemyShipAtk.Size = new System.Drawing.Size(63, 17);
            this.enemyShipAtk.TabIndex = 8;
            this.enemyShipAtk.Text = "Attack: 0";
            // 
            // enemyShipDef
            // 
            this.enemyShipDef.AutoSize = true;
            this.enemyShipDef.Location = new System.Drawing.Point(1317, 737);
            this.enemyShipDef.Name = "enemyShipDef";
            this.enemyShipDef.Size = new System.Drawing.Size(77, 17);
            this.enemyShipDef.TabIndex = 9;
            this.enemyShipDef.Text = "Defense: 0";
            // 
            // enemyShipHlt
            // 
            this.enemyShipHlt.AutoSize = true;
            this.enemyShipHlt.Location = new System.Drawing.Point(1317, 770);
            this.enemyShipHlt.Name = "enemyShipHlt";
            this.enemyShipHlt.Size = new System.Drawing.Size(65, 17);
            this.enemyShipHlt.TabIndex = 10;
            this.enemyShipHlt.Text = "Health: 0";
            // 
            // playerShipName
            // 
            this.playerShipName.AutoSize = true;
            this.playerShipName.Location = new System.Drawing.Point(1163, 655);
            this.playerShipName.Name = "playerShipName";
            this.playerShipName.Size = new System.Drawing.Size(53, 17);
            this.playerShipName.TabIndex = 11;
            this.playerShipName.Text = "Name: ";
            // 
            // enemyShipName
            // 
            this.enemyShipName.AutoSize = true;
            this.enemyShipName.Location = new System.Drawing.Point(1317, 655);
            this.enemyShipName.Name = "enemyShipName";
            this.enemyShipName.Size = new System.Drawing.Size(49, 17);
            this.enemyShipName.TabIndex = 12;
            this.enemyShipName.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playerPictureBox.Image")));
            this.playerPictureBox.Location = new System.Drawing.Point(365, 770);
            this.playerPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(83, 49);
            this.playerPictureBox.TabIndex = 22;
            this.playerPictureBox.TabStop = false;
            this.playerPictureBox.Click += new System.EventHandler(this.playerPictureBox_Click);
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemyPictureBox.BackgroundImage")));
            this.enemyPictureBox.Location = new System.Drawing.Point(191, 36);
            this.enemyPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(63, 69);
            this.enemyPictureBox.TabIndex = 23;
            this.enemyPictureBox.TabStop = false;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(1376, 161);
            this.UpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(167, 60);
            this.UpButton.TabIndex = 24;
            this.UpButton.Text = "UP";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(1165, 257);
            this.LeftButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(157, 59);
            this.LeftButton.TabIndex = 25;
            this.LeftButton.Text = "LEFT";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(1577, 256);
            this.RightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(163, 60);
            this.RightButton.TabIndex = 26;
            this.RightButton.Text = "RIGHT";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(1376, 345);
            this.DownButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(172, 60);
            this.DownButton.TabIndex = 27;
            this.DownButton.Text = "DOWN";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // pass_Button
            // 
            this.pass_Button.Enabled = false;
            this.pass_Button.Location = new System.Drawing.Point(1167, 345);
            this.pass_Button.Margin = new System.Windows.Forms.Padding(4);
            this.pass_Button.Name = "pass_Button";
            this.pass_Button.Size = new System.Drawing.Size(156, 60);
            this.pass_Button.TabIndex = 28;
            this.pass_Button.Text = "PASS";
            this.pass_Button.UseVisualStyleBackColor = true;
            this.pass_Button.Click += new System.EventHandler(this.pass_Button_Click);
            // 
            // ProxAlert
            // 
            this.ProxAlert.AutoSize = true;
            this.ProxAlert.Location = new System.Drawing.Point(1165, 545);
            this.ProxAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProxAlert.Name = "ProxAlert";
            this.ProxAlert.Size = new System.Drawing.Size(0, 17);
            this.ProxAlert.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 846);
            this.Controls.Add(this.ProxAlert);
            this.Controls.Add(this.pass_Button);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemyShipName);
            this.Controls.Add(this.playerShipName);
            this.Controls.Add(this.enemyShipHlt);
            this.Controls.Add(this.enemyShipDef);
            this.Controls.Add(this.enemyShipAtk);
            this.Controls.Add(this.playerShipHlt);
            this.Controls.Add(this.playerShipDef);
            this.Controls.Add(this.playerShipAtk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fireButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Star Admiral V0.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerShipAtk;
        private System.Windows.Forms.Label playerShipDef;
        private System.Windows.Forms.Label playerShipHlt;
        private System.Windows.Forms.Label enemyShipAtk;
        private System.Windows.Forms.Label enemyShipDef;
        private System.Windows.Forms.Label enemyShipHlt;
        private System.Windows.Forms.Label playerShipName;
        private System.Windows.Forms.Label enemyShipName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button pass_Button;
        private System.Windows.Forms.Label ProxAlert;
        private System.Windows.Forms.Timer timer1;
    }
}

