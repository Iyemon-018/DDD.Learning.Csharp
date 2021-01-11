namespace DDD.WinForm.ViewModels
{
    using System;
    using Domain.Repositories;

    public sealed class MeasureViewModel : ViewModelBase
    {
        private ISensorRepository _sensorRepository;

        private string _measureValue = "--";

        public string MeasureValue
        {
            get => _measureValue;
            set => SetProperty(ref _measureValue, value);
        }

        public void Measure()
        {
            var value = _sensorRepository.GetData();
            MeasureValue = Math.Round(value, 2) + "m/s";
        }
    }
}