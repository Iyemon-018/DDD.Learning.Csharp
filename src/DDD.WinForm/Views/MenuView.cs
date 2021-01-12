using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void MeasureButton_Click(object sender, System.EventArgs e)
        {
            using var f = new MeasureView();
            f.ShowDialog();
        }

        private void LatestButton_Click(object sender, System.EventArgs e)
        {
            using var f = new LatestView();
            f.ShowDialog();
        }
    }
}
