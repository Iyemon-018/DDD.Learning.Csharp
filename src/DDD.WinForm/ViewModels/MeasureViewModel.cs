namespace DDD.WinForm.ViewModels
{
    using System;
    using Domain.Repositories;
    using Infrastructure;

    public sealed class MeasureViewModel : ViewModelBase
    {
        private readonly ISensorRepository _sensorRepository;

        private string _measureValue = "--";

        public MeasureViewModel() : this(Factories.CreateSensorRepository())
        {

        }

        public MeasureViewModel(ISensorRepository sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }

        public string MeasureValue
        {
            get => _measureValue;
            set => SetProperty(ref _measureValue, value);
        }

        public void Measure()
        {
            var value = _sensorRepository.GetData();
            MeasureValue = value.DisplayValue;
        }
    }
}