namespace frogger_game
{
    partial class mainMenu
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
            this.difficultyButton = new System.Windows.Forms.Button();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.menuFroggerLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // difficultyButton
            // 
            this.difficultyButton.Location = new System.Drawing.Point(386, 142);
            this.difficultyButton.Name = "difficultyButton";
            this.difficultyButton.Size = new System.Drawing.Size(128, 43);
            this.difficultyButton.TabIndex = 0;
            this.difficultyButton.Text = "Start";
            this.difficultyButton.UseVisualStyleBackColor = true;
            // 
            // tutorialButton
            // 
            this.tutorialButton.Location = new System.Drawing.Point(386, 240);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(128, 43);
            this.tutorialButton.TabIndex = 1;
            this.tutorialButton.Text = "Tutorial";
            this.tutorialButton.UseVisualStyleBackColor = true;
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(386, 330);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(128, 43);
            this.exitButton1.TabIndex = 2;
            this.exitButton1.Text = "Exit";
            this.exitButton1.UseVisualStyleBackColor = true;
            // 
            // menuFroggerLogo
            // 
            this.menuFroggerLogo.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFroggerLogo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.menuFroggerLogo.Location = new System.Drawing.Point(250, 33);
            this.menuFroggerLogo.Name = "menuFroggerLogo";
            this.menuFroggerLogo.Size = new System.Drawing.Size(486, 69);
            this.menuFroggerLogo.TabIndex = 3;
            this.menuFroggerLogo.Text = "Frogger main menu";
            this.menuFroggerLogo.Click += new System.EventHandler(this.menuFroggerLogo_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::frogger_game.Properties.Resources.red_eyed_tree_frog;
            this.Controls.Add(this.menuFroggerLogo);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.difficultyButton);
            this.Name = "mainMenu";
            this.Size = new System.Drawing.Size(903, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button difficultyButton;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button exitButton1;
        private System.Windows.Forms.Label menuFroggerLogo;
    }
}
