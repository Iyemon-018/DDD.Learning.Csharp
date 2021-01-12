namespace DDD.WinForm.ViewModels
{
    using System;
    using Domain.Repositories;
    using Infrastructure;

    public sealed class LatestViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;

        private string _measureDate;

        private string _measureValue;

        public LatestViewModel() : this(Factories.CreateMeasureRepository())
        {
            
        }

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;

            var entity = _measureRepository.GetLatest();
            MeasureDate  = entity.Date.ToString("yyyy/MM/dd HH:mm:ss");
            MeasureValue = Math.Round(entity.Value, 2) + " m/s";
        }

        public string MeasureDate
        {
            get => _measureDate;
            set => SetProperty(ref _measureDate, value);
        }

        public string MeasureValue
        {
            get => _measureValue;
            set => SetProperty(ref _measureValue, value);
        }
    }
}