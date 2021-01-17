namespace DDD.WinForm.ViewModels
{
    using System.ComponentModel;
    using Domain.Repositories;
    using Infrastructure;

    public sealed class MeasureListViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;

        public MeasureListViewModel() : this(Factories.CreateMeasureRepository())
        {
            
        }

        public MeasureListViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;

            foreach (var entity in _measureRepository.GetData())
            {
                Measures.Add(new MeasureListViewModelMeasure(entity));
            }
        }

        public BindingList<MeasureListViewModelMeasure> Measures { get; set; } = new BindingList<MeasureListViewModelMeasure>();
    }
}