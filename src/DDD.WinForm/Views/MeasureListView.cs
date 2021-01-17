using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    using ViewModels;

    public partial class MeasureListView : BaseForm
    {
        public MeasureListView()
        {
            InitializeComponent();

            var viewModel = new MeasureListViewModel();
            MeasureDataGrid.DataBindings.Add("DataSource", viewModel, nameof(viewModel.Measures));
        }
    }
}
