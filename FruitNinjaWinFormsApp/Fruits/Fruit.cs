using BallGame.Common;
using System;
using System.Windows.Forms;
using WMPLib;

namespace FruitNinjaWinFormsApp
{
    public class Fruit : MoveImageRectangle
    {
        protected Random random = new Random();
        public string SliceSoundPath { get; protected set; }
        public string ThrowSoundPath { get; protected set; }

        public Fruit(Form form) : base(form)
        {
            var fruits = FruitsLibrary.GetAll();
            var randomIndex = random.Next(0, fruits.Count);

            image = fruits[randomIndex];
            width = image.Width;
            height = image.Height;

            centerY = form.ClientSize.Height;

            InitializeSoundsPaths();
        }
        public void SlowDown(int coefficient) => timer.Interval *= coefficient;
        public void SpeedUp(int coefficient) => timer.Interval /= coefficient;
        public bool FullyOutForm()
        {
            return centerX + width < LeftSide() || centerX - width > RightSide() || centerY + height < TopSide() || centerY - height > DownSide();
        }
        protected virtual void InitializeSoundsPaths()
        {
            SliceSoundPath = @"Sounds/SliceSound.wav";
            ThrowSoundPath = @"Sounds/Throw_Fruit.wav";
        }
        protected override void Move_Tick(object? sender, EventArgs e)
        {
            Move();
            if (FullyOutForm()) Stop();
        }         
    }
}
