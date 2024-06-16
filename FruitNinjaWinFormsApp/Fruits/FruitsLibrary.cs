using FruitNinjaWinFormsApp.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace FruitNinjaWinFormsApp
{
    public static class FruitsLibrary
    {
        public static List<Image> GetAll()
        {
            var images = new List<Image>()
            {
                Resources.Watermelon,
                Resources.Pineapple,
                Resources.Lemon,
                Resources.Green_Apple,
                Resources.Red_Apple,
                Resources.Coconut,
                Resources.Strawberry
            };
            return images;
        }
    }
}
