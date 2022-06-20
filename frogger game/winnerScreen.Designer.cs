namespace frogger_game
{
    partial class winnerScreen
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
            this.winnerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.rMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.winnerLabel.Location = new System.Drawing.Point(232, 130);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(43, 13);
            this.winnerLabel.TabIndex = 0;
            this.winnerLabel.Text = "you win";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(407, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rMainMenuButton
            // 
            this.rMainMenuButton.Location = new System.Drawing.Point(191, 213);
            this.rMainMenuButton.Name = "rMainMenuButton";
            this.rMainMenuButton.Size = new System.Drawing.Size(75, 52);
            this.rMainMenuButton.TabIndex = 2;
            this.rMainMenuButton.Text = "return to main menu";
            this.rMainMenuButton.UseVisualStyleBackColor = true;
            this.rMainMenuButton.Click += new System.EventHandler(this.rMainMenuButton_Click);
            // 
            // winnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rMainMenuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.winnerLabel);
            this.Name = "winnerScreen";
            this.Size = new System.Drawing.Size(903, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button rMainMenuButton;
    }
}
