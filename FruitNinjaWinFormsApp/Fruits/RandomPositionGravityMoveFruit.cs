using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public class RandomPositionGravityMoveFruit : GravityMoveFruit
    {
        public RandomPositionGravityMoveFruit(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
        }
    }
}
