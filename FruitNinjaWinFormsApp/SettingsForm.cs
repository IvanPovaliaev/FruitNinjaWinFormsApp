using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public partial class SettingsForm : Form
    {
        private GameDifficulties[] difficulties;
        private int currentDifficultyPosition;
        private int volumeValue;
        public SettingsForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            currentDifficultyPosition = (int)SystemSettings.Difficulty;

            difficulties = Enum.GetValues(typeof(GameDifficulties))
                .Cast<GameDifficulties>()
                .ToArray();
            ShowSelectedDifficulty();
            InitializeSoundVolumeTracker();
        }
        private void InitializeSoundVolumeTracker()
        {
            volumeSliderControl.BackColor = Color.FromArgb(100, Color.White);
            volumeSliderControl.Value = SystemSettings.SoundsVolume;
            volumeSliderControl.ValueChanged += VolumeSliderControl_ValueChanged;
            ShowCurrentVolume();
        }
        private void VolumeSliderControl_ValueChanged(object? sender, EventArgs e) => ShowCurrentVolume();
        private void rightArrowPictureBox_Click(object sender, EventArgs e)
        {
            if (currentDifficultyPosition == difficulties.Length - 1) return;
            currentDifficultyPosition++;
            ShowSelectedDifficulty();
        }
        private void leftArrowPictureBox_Click(object sender, EventArgs e)
        {
            if (currentDifficultyPosition == 0) return;
            currentDifficultyPosition--;
            ShowSelectedDifficulty();
        }
        private void ShowSelectedDifficulty()
        {
            currentDifficultyLabel.Text = difficulties[currentDifficultyPosition].ToString();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            SystemSettings.SetDifficulty(difficulties[currentDifficultyPosition]);
            SystemSettings.SoundsVolume = volumeValue;
            WinFormsProvider.OpenChildForm(new GameForm());
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            WinFormsProvider.OpenChildForm(new GameForm());
        }
        private void rightArrowPictureBox_MouseEnter(object sender, EventArgs e)
        {
            rightArrowPictureBox.Image = Properties.Resources.RightArrowHover;
        }
        private void rightArrowPictureBox_MouseLeave(object sender, EventArgs e)
        {
            rightArrowPictureBox.Image = Properties.Resources.RightArrow;
        }
        private void leftArrowPictureBox_MouseEnter(object sender, EventArgs e)
        {
            leftArrowPictureBox.Image = Properties.Resources.LeftArrowHover;
        }
        private void leftArrowPictureBox_MouseLeave(object sender, EventArgs e)
        {
            leftArrowPictureBox.Image = Properties.Resources.LeftArrow;
        }
        private void ShowCurrentVolume()
        {
            volumeValue = volumeSliderControl.Value;
            soundCurrentVolumeLabel.Text = $"{volumeValue}%";
            Invalidate();
        }
    }
}
