using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public static class WinFormsProvider
    {
        public static void OpenChildForm(Form childForm)
        {
            if (StaticData.ActiveForm != null && !StaticData.ActiveForm.IsDisposed) StaticData.ActiveForm.Close();

            StaticData.ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            StaticData.ChildFormPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
