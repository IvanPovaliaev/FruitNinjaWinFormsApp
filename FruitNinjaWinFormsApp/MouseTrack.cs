using System.Drawing;

namespace FruitNinjaWinFormsApp
{
    public class MouseTrack
    {
        public Point Position { get; private set; }
        public MouseTrack(Point point)
        {
            Position = point;
        }
    }
}
