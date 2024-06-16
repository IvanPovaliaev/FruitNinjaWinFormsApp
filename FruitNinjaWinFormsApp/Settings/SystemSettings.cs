namespace FruitNinjaWinFormsApp
{
    public static class SystemSettings
    {
        public static GameDifficulties Difficulty { get; private set; } = GameDifficulties.Normal;
        public static int FruitsStartThrowInterval { get; private set; } = 2000;
        public static int FruitsEndThrowInterval { get; private set; } = 250;
        public static int FruitsDeltaThrowInterval { get; private set; } = 50;
        public static int SlowDownTime { get; private set; } = 3;
        public static int Lifes { get; private set; } = 3;
        public static int SoundsVolume = 20;

        public static void SetDifficulty(GameDifficulties difficulty)
        {
            Difficulty = difficulty;
            switch (difficulty)
            {
                case GameDifficulties.Easy:
                    FruitsStartThrowInterval = 4000;
                    FruitsEndThrowInterval = 500;
                    FruitsDeltaThrowInterval = 25;
                    SlowDownTime = 5;
                    Lifes = 3;
                    break;
                case GameDifficulties.Normal:
                    FruitsStartThrowInterval = 2000;
                    FruitsEndThrowInterval = 250;
                    FruitsDeltaThrowInterval = 50;
                    SlowDownTime = 3;
                    Lifes = 3;
                    break;
                case GameDifficulties.Hard:
                    FruitsStartThrowInterval = 1250;
                    FruitsEndThrowInterval = 150;
                    FruitsDeltaThrowInterval = 50;
                    SlowDownTime = 2;
                    Lifes = 2;
                    break;
            }
        }
    }
}