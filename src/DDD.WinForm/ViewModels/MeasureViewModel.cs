namespace DDD.WinForm.ViewModels
{
    public sealed class MeasureViewModel : ViewModelBase
    {
        private string _measureValue = "--";

        public string MeasureValue
        {
            get => _measureValue;
            set => SetProperty(ref _measureValue, value);
        }

        public void Measure()
        {
            throw new System.NotImplementedException();
        }
    }
}