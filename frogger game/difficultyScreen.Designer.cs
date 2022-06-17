namespace frogger_game
{
    partial class difficultyScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.extremeHardButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(349, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "choose your difficulty ";
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(331, 170);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(223, 42);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Easy ";
            this.easyButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(331, 254);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(223, 53);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(331, 357);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(223, 51);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            // 
            // extremeHardButton
            // 
            this.extremeHardButton.Location = new System.Drawing.Point(367, 435);
            this.extremeHardButton.Name = "extremeHardButton";
            this.extremeHardButton.Size = new System.Drawing.Size(149, 29);
            this.extremeHardButton.TabIndex = 4;
            this.extremeHardButton.Text = "True frog mode";
            this.extremeHardButton.UseVisualStyleBackColor = true;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(13, 460);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.mainMenuButton.TabIndex = 5;
            this.mainMenuButton.Text = "main menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // difficultyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::frogger_game.Properties.Resources.frog;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.extremeHardButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.label1);
            this.Name = "difficultyScreen";
            this.Size = new System.Drawing.Size(903, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button extremeHardButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button button1;
    }
}
