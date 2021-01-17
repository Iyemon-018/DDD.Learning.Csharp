namespace DDD.WinForm.ViewModels
{
    using System;
    using Domain.Entities;
    using Domain.Helpers;
    using Domain.Repositories;
    using Infrastructure;

    public class MeasureSaveViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;

        private DateTime _measureDate;

        private string _measureValue = "";

        public MeasureSaveViewModel() : this(Factories.CreateMeasureRepository())
        {
            
        }

        public MeasureSaveViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
            _measureDate            = GetDateTime();
        }

        public DateTime MeasureDate
        {
            get => _measureDate;
            // 何故か以下のコードだとテストケースが失敗する。基底クラスのバグ？
            // 原因がわからないので直接代入する形式にしている。
            //set => SetProperty(ref _measureDate, value);
            set => _measureDate = value;
        }

        public string MeasureValue
        {
            get => _measureValue;
            // 何故か以下のコードだとテストケースが失敗する。基底クラスのバグ？
            // 原因がわからないので直接代入する形式にしている。
            //set => SetProperty(ref _measureValue, value);
            set => _measureValue = value;
        }

        public string UnitLabel => Domain.ValueObjects.MeasureValue.UnitName;

        public virtual DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public void Save()
        {
            // ここでは入力した値を DB に登録するものと仮定する。
            // DB へのアクセスは Infrastructure に記述する。
            // テストコードは Infrastructure 層は対象外のため、このメソッドで保存した情報をチェックできればいい。
            Guard.IsNullOrEmptyMessage(MeasureValue, "計測値を入力してください。");

            var value  = Convert.ToSingle(MeasureValue);
            var entity = new MeasureEntity(Guid.NewGuid().ToString(), MeasureDate, value);

            _measureRepository.Save(entity);
        }
    }
}