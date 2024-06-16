using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public class RandomPositionGravityMoveBanana : RandomPositionGravityMoveFruit
    {
        public RandomPositionGravityMoveBanana(Form form) : base(form)
        {
            image = Properties.Resources.Banana;
            width = image.Width;
            height = image.Height;
        }
    }
}
