namespace DDD.WinForm.Views
{
    using ViewModels;

    public partial class LatestView : BaseForm
    {
        public LatestView()
        {
            InitializeComponent();

            var viewModel = new LatestViewModel();
            DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureDate));
            MeasureValueLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
        }
    }
}
