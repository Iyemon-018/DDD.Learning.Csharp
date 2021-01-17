namespace DDD.WinForm.ViewModels
{
    using Domain.Entities;

    public sealed class MeasureListViewModelMeasure
    {
        private readonly MeasureEntity _entity;

        public MeasureListViewModelMeasure(MeasureEntity entity)
        {
            _entity = entity;
        }

        public string MeasureDate => _entity.Date.DisplayValue;

        public string MeasureValue => _entity.Value.DisplayValue;
    }
}