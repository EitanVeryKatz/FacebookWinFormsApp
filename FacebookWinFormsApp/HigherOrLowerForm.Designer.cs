namespace BasicFacebookFeatures
{
    partial class HigherOrLowerForm
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
            this.nextGroupOrProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.currentGroupOrProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.higherBtn = new System.Windows.Forms.Button();
            this.lowerBtn = new System.Windows.Forms.Button();
            this.startNewGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.nextPostOrGroupNameLabel = new System.Windows.Forms.Label();
            this.currentPostOrGroupNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nextGroupOrProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGroupOrProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nextGroupOrProfilePictureBox
            // 
            this.nextGroupOrProfilePictureBox.Location = new System.Drawing.Point(613, 111);
            this.nextGroupOrProfilePictureBox.Name = "nextGroupOrProfilePictureBox";
            this.nextGroupOrProfilePictureBox.Size = new System.Drawing.Size(244, 231);
            this.nextGroupOrProfilePictureBox.TabIndex = 0;
            this.nextGroupOrProfilePictureBox.TabStop = false;
            // 
            // currentGroupOrProfilePictureBox
            // 
            this.currentGroupOrProfilePictureBox.Location = new System.Drawing.Point(74, 111);
            this.currentGroupOrProfilePictureBox.Name = "currentGroupOrProfilePictureBox";
            this.currentGroupOrProfilePictureBox.Size = new System.Drawing.Size(244, 231);
            this.currentGroupOrProfilePictureBox.TabIndex = 1;
            this.currentGroupOrProfilePictureBox.TabStop = false;
            // 
            // higherBtn
            // 
            this.higherBtn.Enabled = false;
            this.higherBtn.Location = new System.Drawing.Point(404, 111);
            this.higherBtn.Name = "higherBtn";
            this.higherBtn.Size = new System.Drawing.Size(127, 73);
            this.higherBtn.TabIndex = 2;
            this.higherBtn.Text = "Higher";
            this.higherBtn.UseVisualStyleBackColor = true;
            this.higherBtn.Click += new System.EventHandler(this.higherBtn_Click);
            // 
            // lowerBtn
            // 
            this.lowerBtn.Enabled = false;
            this.lowerBtn.Location = new System.Drawing.Point(404, 269);
            this.lowerBtn.Name = "lowerBtn";
            this.lowerBtn.Size = new System.Drawing.Size(127, 73);
            this.lowerBtn.TabIndex = 3;
            this.lowerBtn.Text = "Lower";
            this.lowerBtn.UseVisualStyleBackColor = true;
            this.lowerBtn.Click += new System.EventHandler(this.lowerBtn_Click);
            // 
            // startNewGameBtn
            // 
            this.startNewGameBtn.Location = new System.Drawing.Point(284, 433);
            this.startNewGameBtn.Name = "startNewGameBtn";
            this.startNewGameBtn.Size = new System.Drawing.Size(124, 59);
            this.startNewGameBtn.TabIndex = 4;
            this.startNewGameBtn.Text = "Start New Game";
            this.startNewGameBtn.UseVisualStyleBackColor = true;
            this.startNewGameBtn.Click += new System.EventHandler(this.startNewGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Or";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(454, 454);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 16);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score: ";
            // 
            // rulesBtn
            // 
            this.rulesBtn.Location = new System.Drawing.Point(12, 487);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(105, 35);
            this.rulesBtn.TabIndex = 9;
            this.rulesBtn.Text = "How To Play";
            this.rulesBtn.UseVisualStyleBackColor = true;
            // 
            // nextPostOrGroupNameLabel
            // 
            this.nextPostOrGroupNameLabel.AutoSize = true;
            this.nextPostOrGroupNameLabel.Location = new System.Drawing.Point(725, 359);
            this.nextPostOrGroupNameLabel.Name = "nextPostOrGroupNameLabel";
            this.nextPostOrGroupNameLabel.Size = new System.Drawing.Size(0, 16);
            this.nextPostOrGroupNameLabel.TabIndex = 10;
            // 
            // currentPostOrGroupNameLabel
            // 
            this.currentPostOrGroupNameLabel.AutoSize = true;
            this.currentPostOrGroupNameLabel.Location = new System.Drawing.Point(167, 359);
            this.currentPostOrGroupNameLabel.Name = "currentPostOrGroupNameLabel";
            this.currentPostOrGroupNameLabel.Size = new System.Drawing.Size(0, 16);
            this.currentPostOrGroupNameLabel.TabIndex = 11;
            // 
            // HigherOrLowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 534);
            this.Controls.Add(this.currentPostOrGroupNameLabel);
            this.Controls.Add(this.nextPostOrGroupNameLabel);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startNewGameBtn);
            this.Controls.Add(this.lowerBtn);
            this.Controls.Add(this.higherBtn);
            this.Controls.Add(this.currentGroupOrProfilePictureBox);
            this.Controls.Add(this.nextGroupOrProfilePictureBox);
            this.Name = "HigherOrLowerForm";
            this.Text = "HigherOrLowerForm";
            ((System.ComponentModel.ISupportInitialize)(this.nextGroupOrProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGroupOrProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nextGroupOrProfilePictureBox;
        private System.Windows.Forms.PictureBox currentGroupOrProfilePictureBox;
        private System.Windows.Forms.Button higherBtn;
        private System.Windows.Forms.Button lowerBtn;
        private System.Windows.Forms.Button startNewGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Label nextPostOrGroupNameLabel;
        private System.Windows.Forms.Label currentPostOrGroupNameLabel;
    }
}