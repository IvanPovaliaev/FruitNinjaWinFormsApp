using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public class RandomPositionGravityMoveBomb : RandomPositionGravityMoveFruit
    {
        public RandomPositionGravityMoveBomb(Form form) : base(form)
        {
            image = Properties.Resources.Bomb;
            width = image.Width;
            height = image.Height;
        }
        protected override void InitializeSoundsPaths()
        {
            SliceSoundPath = @"Sounds/Bomb_Explode.wav";
            ThrowSoundPath = @"Sounds/Throw_Bomb.wav";
        }
    }
}
