namespace FruitNinjaWinFormsApp
{
    partial class SettingsForm
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
            currentDifficultyLabel = new System.Windows.Forms.Label();
            leftArrowPictureBox = new System.Windows.Forms.PictureBox();
            rightArrowPictureBox = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            acceptButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            soundCurrentVolumeLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            volumeSliderControl = new BallGame.Common.SliderControl();
            ((System.ComponentModel.ISupportInitialize)leftArrowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArrowPictureBox).BeginInit();
            SuspendLayout();
            // 
            // currentDifficultyLabel
            // 
            currentDifficultyLabel.BackColor = System.Drawing.Color.Transparent;
            currentDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            currentDifficultyLabel.ForeColor = System.Drawing.Color.White;
            currentDifficultyLabel.Location = new System.Drawing.Point(301, 145);
            currentDifficultyLabel.Name = "currentDifficultyLabel";
            currentDifficultyLabel.Size = new System.Drawing.Size(189, 50);
            currentDifficultyLabel.TabIndex = 0;
            currentDifficultyLabel.Text = "currentDifficulty";
            currentDifficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftArrowPictureBox
            // 
            leftArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            leftArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            leftArrowPictureBox.Image = Properties.Resources.LeftArrow;
            leftArrowPictureBox.InitialImage = null;
            leftArrowPictureBox.Location = new System.Drawing.Point(235, 145);
            leftArrowPictureBox.Name = "leftArrowPictureBox";
            leftArrowPictureBox.Size = new System.Drawing.Size(60, 50);
            leftArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            leftArrowPictureBox.TabIndex = 1;
            leftArrowPictureBox.TabStop = false;
            leftArrowPictureBox.Click += leftArrowPictureBox_Click;
            leftArrowPictureBox.MouseEnter += leftArrowPictureBox_MouseEnter;
            leftArrowPictureBox.MouseLeave += leftArrowPictureBox_MouseLeave;
            // 
            // rightArrowPictureBox
            // 
            rightArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            rightArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            rightArrowPictureBox.Image = Properties.Resources.RightArrow;
            rightArrowPictureBox.InitialImage = null;
            rightArrowPictureBox.Location = new System.Drawing.Point(496, 145);
            rightArrowPictureBox.Name = "rightArrowPictureBox";
            rightArrowPictureBox.Size = new System.Drawing.Size(60, 50);
            rightArrowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            rightArrowPictureBox.TabIndex = 1;
            rightArrowPictureBox.TabStop = false;
            rightArrowPictureBox.Click += rightArrowPictureBox_Click;
            rightArrowPictureBox.MouseEnter += rightArrowPictureBox_MouseEnter;
            rightArrowPictureBox.MouseLeave += rightArrowPictureBox_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(221, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(347, 50);
            label1.TabIndex = 0;
            label1.Text = "Выберите сложность";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = System.Drawing.Color.Transparent;
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            acceptButton.ForeColor = System.Drawing.Color.White;
            acceptButton.Location = new System.Drawing.Point(646, 397);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new System.Drawing.Size(126, 52);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "Принять";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = System.Drawing.Color.Transparent;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            cancelButton.ForeColor = System.Drawing.Color.White;
            cancelButton.Location = new System.Drawing.Point(496, 397);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(126, 52);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // soundCurrentVolumeLabel
            // 
            soundCurrentVolumeLabel.AutoSize = true;
            soundCurrentVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            soundCurrentVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            soundCurrentVolumeLabel.ForeColor = System.Drawing.Color.White;
            soundCurrentVolumeLabel.Location = new System.Drawing.Point(496, 312);
            soundCurrentVolumeLabel.Name = "soundCurrentVolumeLabel";
            soundCurrentVolumeLabel.Size = new System.Drawing.Size(48, 24);
            soundCurrentVolumeLabel.TabIndex = 5;
            soundCurrentVolumeLabel.Text = "30%";
            soundCurrentVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(221, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(347, 50);
            label2.TabIndex = 0;
            label2.Text = "Громкость звуков";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeSliderControl
            // 
            volumeSliderControl.BackColor = System.Drawing.Color.White;
            volumeSliderControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            volumeSliderControl.Location = new System.Drawing.Point(235, 288);
            volumeSliderControl.Name = "volumeSliderControl";
            volumeSliderControl.Size = new System.Drawing.Size(321, 21);
            volumeSliderControl.SliderColor = System.Drawing.Color.FromArgb(242, 196, 141);
            volumeSliderControl.TabIndex = 6;
            volumeSliderControl.Value = 20;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImage = Properties.Resources.SettingsBackGround;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(volumeSliderControl);
            Controls.Add(soundCurrentVolumeLabel);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(rightArrowPictureBox);
            Controls.Add(leftArrowPictureBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(currentDifficultyLabel);
            MaximumSize = new System.Drawing.Size(800, 500);
            MinimumSize = new System.Drawing.Size(800, 500);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Настройки";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)leftArrowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArrowPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label currentDifficultyLabel;
        private System.Windows.Forms.PictureBox leftArrowPictureBox;
        private System.Windows.Forms.PictureBox rightArrowPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label soundCurrentVolumeLabel;
        private System.Windows.Forms.Label label2;
        private BallGame.Common.SliderControl volumeSliderControl;
    }
}