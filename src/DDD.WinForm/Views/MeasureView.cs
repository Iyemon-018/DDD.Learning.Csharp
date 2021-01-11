namespace DDD.WinForm.Views
{
    using ViewModels;

    public partial class MeasureView : BaseForm
    {
        public MeasureView()
        {
            InitializeComponent();

            var viewModel = new MeasureViewModel();
            MeasureValueLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
            MeasureButton.Click += (sender, args) => viewModel.Measure();
        }
    }
}
