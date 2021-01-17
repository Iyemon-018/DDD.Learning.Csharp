namespace DDD.WinForm.Views
{
    using ViewModels;

    public partial class MeasureSaveView : BaseForm
    {
        public MeasureSaveView()
        {
            InitializeComponent();

            var viewModel = new MeasureSaveViewModel();
            MeasureDateTextBox.DataBindings.Add("Value", viewModel, nameof(viewModel.MeasureDate));
            MeasureValueTextBox.DataBindings.Add("Text", viewModel, nameof(viewModel.MeasureValue));
            UnitLabel.DataBindings.Add("Text", viewModel, nameof(viewModel.UnitLabel));
            SaveButton.Click += (sender, args) => viewModel.Save();
        }
    }
}
