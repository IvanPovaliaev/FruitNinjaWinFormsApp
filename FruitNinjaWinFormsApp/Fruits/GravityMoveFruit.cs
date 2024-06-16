using System;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public class GravityMoveFruit : Fruit
    {
        protected float g = 0.4f;
        public GravityMoveFruit(Form form) : base(form)
        {
            vx = random.Next(-2,3);
            var vyLowerLimit = -Convert.ToInt32(Math.Sqrt(1.6 * form.ClientSize.Height * g));

            vy = random.Next(vyLowerLimit, 4 * vyLowerLimit / 5);
        }
        protected override void Go()
        {
            vy += g;
            base.Go();
        }
    }
}
