using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
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
            infoLabel = new Label();
            countLabel = new Label();
            startButton = new Button();
            slowDownLabel = new Label();
            firstHeartPictureBox = new PictureBox();
            secondHeartPictureBox = new PictureBox();
            thirdHeartPictureBox = new PictureBox();
            difficultyLabel = new Label();
            settingsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)firstHeartPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondHeartPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thirdHeartPictureBox).BeginInit();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.BackColor = Color.Transparent;
            infoLabel.Dock = DockStyle.Top;
            infoLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            infoLabel.ForeColor = SystemColors.Control;
            infoLabel.Location = new Point(0, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(784, 30);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Держи ЛКМ и разрезай фрукты";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countLabel
            // 
            countLabel.BackColor = Color.Transparent;
            countLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            countLabel.ForeColor = SystemColors.Control;
            countLabel.Location = new Point(562, 30);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(222, 30);
            countLabel.TabIndex = 1;
            countLabel.Text = "Счёт: 0";
            countLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.BackgroundImageLayout = ImageLayout.None;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(333, 202);
            startButton.Name = "startButton";
            startButton.Size = new Size(130, 50);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // slowDownLabel
            // 
            slowDownLabel.BackColor = Color.Transparent;
            slowDownLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            slowDownLabel.ForeColor = SystemColors.Control;
            slowDownLabel.Location = new Point(248, 30);
            slowDownLabel.Name = "slowDownLabel";
            slowDownLabel.Size = new Size(308, 30);
            slowDownLabel.TabIndex = 1;
            slowDownLabel.Text = "Замедление: 0 сек.";
            slowDownLabel.TextAlign = ContentAlignment.MiddleCenter;
            slowDownLabel.Visible = false;
            // 
            // firstHeartPictureBox
            // 
            firstHeartPictureBox.BackColor = Color.Transparent;
            firstHeartPictureBox.Image = Properties.Resources.EmptyHeart;
            firstHeartPictureBox.Location = new Point(12, 0);
            firstHeartPictureBox.Name = "firstHeartPictureBox";
            firstHeartPictureBox.Size = new Size(40, 40);
            firstHeartPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            firstHeartPictureBox.TabIndex = 3;
            firstHeartPictureBox.TabStop = false;
            // 
            // secondHeartPictureBox
            // 
            secondHeartPictureBox.BackColor = Color.Transparent;
            secondHeartPictureBox.Image = Properties.Resources.EmptyHeart;
            secondHeartPictureBox.Location = new Point(58, 0);
            secondHeartPictureBox.Name = "secondHeartPictureBox";
            secondHeartPictureBox.Size = new Size(40, 40);
            secondHeartPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            secondHeartPictureBox.TabIndex = 3;
            secondHeartPictureBox.TabStop = false;
            // 
            // thirdHeartPictureBox
            // 
            thirdHeartPictureBox.BackColor = Color.Transparent;
            thirdHeartPictureBox.Image = Properties.Resources.EmptyHeart;
            thirdHeartPictureBox.Location = new Point(104, 0);
            thirdHeartPictureBox.Name = "thirdHeartPictureBox";
            thirdHeartPictureBox.Size = new Size(40, 40);
            thirdHeartPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            thirdHeartPictureBox.TabIndex = 3;
            thirdHeartPictureBox.TabStop = false;
            // 
            // difficultyLabel
            // 
            difficultyLabel.BackColor = Color.Transparent;
            difficultyLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            difficultyLabel.ForeColor = SystemColors.Control;
            difficultyLabel.Location = new Point(562, 0);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(222, 30);
            difficultyLabel.TabIndex = 1;
            difficultyLabel.Text = "Сложность: Easy";
            difficultyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settingsButton
            // 
            settingsButton.Anchor = AnchorStyles.Bottom;
            settingsButton.BackColor = Color.Transparent;
            settingsButton.BackgroundImageLayout = ImageLayout.None;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            settingsButton.ForeColor = Color.White;
            settingsButton.Location = new Point(293, 399);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(210, 50);
            settingsButton.TabIndex = 2;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            BackgroundImage = Properties.Resources.Wiki_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(thirdHeartPictureBox);
            Controls.Add(secondHeartPictureBox);
            Controls.Add(firstHeartPictureBox);
            Controls.Add(settingsButton);
            Controls.Add(startButton);
            Controls.Add(slowDownLabel);
            Controls.Add(difficultyLabel);
            Controls.Add(countLabel);
            Controls.Add(infoLabel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(784, 461);
            MinimizeBox = false;
            MinimumSize = new Size(784, 461);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FruitNinja";
            Load += GameForm_Load;
            Paint += GameForm_Paint;
            MouseDown += GameForm_MouseDown;
            MouseUp += GameForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)firstHeartPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondHeartPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thirdHeartPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label infoLabel;
        private Label countLabel;
        private Button startButton;
        private Label slowDownLabel;
        private PictureBox firstHeartPictureBox;
        private PictureBox secondHeartPictureBox;
        private PictureBox thirdHeartPictureBox;
        private Label difficultyLabel;
        private Button settingsButton;
    }
}
