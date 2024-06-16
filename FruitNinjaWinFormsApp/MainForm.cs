using BallGame.Common;

namespace FruitNinjaWinFormsApp
{
    public partial class MainForm : DoubleBufferedForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            StaticData.MainForm = this;
            StaticData.ChildFormPanel = childFormPanel;
            WinFormsProvider.OpenChildForm(new GameForm());
        }
    }
}
