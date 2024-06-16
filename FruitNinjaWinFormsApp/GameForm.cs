using BallGame.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public partial class GameForm : Form
    {
        private System.Timers.Timer throwTimer;
        private System.Timers.Timer slowDownTimer;
        private Timer refreshTimer;
        private LinkedList<Fruit> fruits;
        private bool isMouseLeftButtonPressed;
        private int startThrowInterval;
        private int endThrowInterval;
        private int deltaThrowInterval;
        private int score;
        private int slowDownBanana;
        private int slowDownCoefficient = 3;
        private int slowDownTime;
        private bool isSlowedDown;
        private int lifes;
        private List<PictureBox> lifesList;
        private Queue<MouseTrack> mouseTrackQueue;
        public GameForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
        }
        private void GameForm_Load(object sender, EventArgs e) => SetGameSettings();
        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseLeftButtonPressed)
            {
                _ = Task.Run(() =>
                {
                    AddMouseTrack(e.Location);
                    DoActionForEachFruit((currentFruit) =>
                    {
                        var currentFruitBounds = currentFruit.Value.GetBounds();

                        if (currentFruitBounds.Contains(e.Location))
                        {
                            currentFruit.Value.Stop();
                            _ = AudioProvider.PlaySoundAsync(currentFruit.Value.SliceSoundPath, SystemSettings.SoundsVolume);

                            if (currentFruit.Value is RandomPositionGravityMoveBomb)
                            {
                                lifes = -1;
                                EndGame("Вы задели бомбу! Игра окончена!");
                            }
                            else
                            {
                                if (currentFruit.Value is RandomPositionGravityMoveBanana) SlowAll();
                                BeginInvoke(() => IncreaseScore());
                            }
                        }
                    });
                });
            }
        }
        private void GameForm_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(@"Cursors\Pointer.cur");
            isMouseLeftButtonPressed = false;
            mouseTrackQueue?.Clear();
        }
        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(@"Cursors\Katana.cur");
            isMouseLeftButtonPressed = true;
        }
        private void startButton_Click(object sender, EventArgs e) => StartGame();
        private void settingsButton_Click(object sender, EventArgs e) => WinFormsProvider.OpenChildForm(new SettingsForm());
        private void InitializeRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 5;
            refreshTimer.Tick += Refresh_Tick;
            refreshTimer.Start();
        }
        private void Refresh_Tick(object? sender, EventArgs e) => Invalidate();
        private void AddMouseTrack(Point mouseLocation)
        {
            if (mouseTrackQueue.Count > 4) mouseTrackQueue.Dequeue();
            mouseTrackQueue.Enqueue(new MouseTrack(mouseLocation));
        }
        private void InitializeThrowFruitTimer()
        {
            throwTimer = new System.Timers.Timer();
            throwTimer.Interval = startThrowInterval;
            throwTimer.Elapsed += ThrowNewFruit_Tick;
            throwTimer.Start();
        }
        private void ThrowNewFruit_Tick(object? sender, EventArgs e)
        {
            var fruit = GetRandomFruit();
            _ = AudioProvider.PlaySoundAsync(fruit.ThrowSoundPath, SystemSettings.SoundsVolume);
            fruits.AddLast(fruit);

            if (isSlowedDown) fruit.SlowDown(slowDownCoefficient);

            fruit.AddDissapearEvent((sender, e) =>
            {
                if (fruit is not RandomPositionGravityMoveBomb && fruit.FullyOutForm() && lifes > 0) DecreaseHeart();

                fruits.Remove(fruit);
            });

            fruit.Start();            

            var newInterval = throwTimer.Interval - deltaThrowInterval;
            throwTimer.Interval = Math.Max(newInterval, endThrowInterval);
            return;
        }
        private void DecreaseHeart()
        {
            lifes--;

            lifesList[lifes].Image = Properties.Resources.EmptyHeart;

            lifesList.RemoveAt(lifes);

            if (lifes == 0) EndGame($"Вы пропустили {SystemSettings.Lifes} фрукта! Игра окончена!");
        }
        private void InitializeSlowDownTimer()
        {
            slowDownTimer = new System.Timers.Timer();
            slowDownTimer.Interval = 1000;

            slowDownTimer.Elapsed += (sender, e) =>
            {
                slowDownTime--;
                ShowSlowDownTimeLeft();

                if (slowDownTime == 0)
                {
                    ResetMovement();
                    slowDownTimer.Dispose();
                    Invoke(() => slowDownLabel.Hide());
                }
            };
            slowDownTimer.Start();
        }
        private void ResetMovement()
        {
            throwTimer.Interval /= slowDownCoefficient;
            deltaThrowInterval *= slowDownCoefficient;

            DoActionForEachFruit((currentFruit) => currentFruit.Value.SpeedUp(slowDownCoefficient));

            slowDownTime = 0;
            isSlowedDown = false;
        }
        private void SlowAll()
        {
            slowDownTime += slowDownBanana;
            ShowSlowDownTimeLeft();

            if (!isSlowedDown)
            {
                Invoke(() => slowDownLabel.Show());
                throwTimer.Interval *= slowDownCoefficient;
                deltaThrowInterval /= slowDownCoefficient;

                DoActionForEachFruit((currentFruit) => currentFruit.Value.SlowDown(slowDownCoefficient));

                isSlowedDown = true;

                InitializeSlowDownTimer();
            }
        }
        private void StartGame()
        {
            Cursor = new Cursor(@"Cursors\Pointer.cur");

            startButton.Hide();
            settingsButton.Hide();
            slowDownLabel.Hide();
            isMouseLeftButtonPressed = false;

            fruits = new LinkedList<Fruit>();
            mouseTrackQueue = new Queue<MouseTrack>();

            MouseMove += GameForm_MouseMove;

            InitializeLifes();
            InitializeRefreshTimer();
            InitializeThrowFruitTimer();

            score = -1;
            IncreaseScore();
        }
        private void SetGameSettings()
        {
            startThrowInterval = SystemSettings.FruitsStartThrowInterval;
            endThrowInterval = SystemSettings.FruitsEndThrowInterval;
            deltaThrowInterval = SystemSettings.FruitsDeltaThrowInterval;
            slowDownBanana = SystemSettings.SlowDownTime;            
            difficultyLabel.Text = $"Сложность: {SystemSettings.Difficulty}";            
        }
        private void InitializeLifes()
        {
            lifes = SystemSettings.Lifes;
            lifesList = [firstHeartPictureBox, secondHeartPictureBox, thirdHeartPictureBox];
            for (int i = 0; i < lifes; i++) lifesList[i].Image = Properties.Resources.FullHeart;
        }
        private void EndGame(string endMessage)
        {
            ActiveControl = null;
            MouseMove -= GameForm_MouseMove;
            DoActionForEachFruit((currentFruit) => currentFruit.Value.Stop());
            if (isSlowedDown) ResetMovement();

            throwTimer.Dispose();
            refreshTimer.Dispose();
            slowDownTimer?.Dispose();

            mouseTrackQueue.Clear();

            Invoke(() =>
            {
                Invalidate();
                slowDownLabel.Hide();
                startButton.Show();
                startButton.Text = "Restart";
                settingsButton.Show();
            });

            fruits.Clear();

            MessageBox.Show(endMessage);
        }
        private void IncreaseScore()
        {
            score++;
            countLabel.Text = $"Счёт: {score}";
        }
        private void ShowSlowDownTimeLeft() => Invoke(() => slowDownLabel.Text = $"Замедление: {slowDownTime} сек.");
        private Fruit GetRandomFruit()
        {
            var chance = new Random().Next(1, 101);
            if (chance <= 5) return new RandomPositionGravityMoveBomb(this);
            if (chance <= 10) return new RandomPositionGravityMoveBanana(this);
            return new RandomPositionGravityMoveFruit(this);
        }
        private void DoActionForEachFruit(Action<LinkedListNode<Fruit>> action)
        {
            var currentFruit = fruits?.First;
            for (int i = 0; i < fruits?.Count; i++)
            {
                if (currentFruit is null) break;

                action(currentFruit);

                currentFruit = currentFruit.Next;
            }
        }
        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            DoActionForEachFruit((currentFruit) => e.Graphics.DrawImage(currentFruit.Value.GetImage(), currentFruit.Value.GetBounds()));
            if (isMouseLeftButtonPressed)
            {
                var path = mouseTrackQueue.Select(point => point.Position).ToArray();
                if (path.Length < 2) return;
                var brush = new SolidBrush(Color.LightGray);
                var pen = new Pen(brush, 10f);
                e.Graphics.DrawCurve(pen, path);          
            }
        }
    }
}
