namespace frogger_game
{
    partial class gameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
 
            this.timer.Location = new System.Drawing.Point(820, 27);

            this.timer.Location = new System.Drawing.Point(831, 14);

            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(53, 26);
            this.timer.TabIndex = 0;
            this.timer.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
 
            this.livesLabel.Location = new System.Drawing.Point(36, 26);

            this.livesLabel.Location = new System.Drawing.Point(25, 13);
 
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(80, 27);
            this.livesLabel.TabIndex = 2;
            this.livesLabel.Text = "0";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer);
            this.DoubleBuffered = true;
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(910, 510);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label livesLabel;
    }
}
