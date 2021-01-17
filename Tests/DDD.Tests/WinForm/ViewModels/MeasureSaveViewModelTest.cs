namespace DDD.Tests.WinForm.ViewModels
{
    using ChainingAssertion;
    using DDD.Domain.Entities;
    using DDD.Domain.Helpers;
    using DDD.Domain.Repositories;
    using DDD.WinForm.ViewModels;
    using Moq;
    using Xunit;

    public class MeasureSaveViewModelTest
    {
        [Fact]
        public void Test_計測登録_シナリオ()
        {
            var measureMock   = new Mock<IMeasureRepository>();
            var viewModelMock = new Mock<MeasureSaveViewModel>(measureMock.Object);
            viewModelMock.Setup(x => x.GetDateTime()).Returns("2017/01/03 13:00:00".ToDate());
            var viewModel = viewModelMock.Object;
            viewModel.MeasureDate.Is("2017/01/03 13:00:00".ToDate());
            viewModel.MeasureValue.Is("");
            viewModel.UnitLabel.Is("m/s");

            // ユーザーがテキストボックスに値を入力したことをシミュレートする。
            viewModel.MeasureDate  = "2017/01/03 12:50:00".ToDate();
            viewModel.MeasureValue = "1.23456";

            // IMeasureRepository.Save() のテストを行っている。
            // Mock の .Callback を呼び出すことで上記で入力した値が
            // 期待したとおり、呼ばれているかテストすることができる。
            measureMock.Setup(x => x.Save(It.IsAny<MeasureEntity>()))
                       .Callback<MeasureEntity>(saveValue =>
                                                {
                                                    //saveValue.Id.Is("?");     // 今回のケースでは GUID はテストしないのでコメントアウトしている。
                                                    saveValue.Date.Value.Is("2017/01/03 12:50:00".ToDate());
                                                    saveValue.Value.Value.Is(1.23456f);
                                                });
            viewModel.Save();

            // Mock<T>.VerifyAll() を呼び出すことで .SetUp で定義したモックメソッドが全て呼び出されたかどうかを判定できる。
            // 一つでも呼ばれていないメソッドがあれば、この時点で Mock.MockException がスローされる。
            // エラーメッセージには呼び出されていないメソッドも記載される。
            measureMock.VerifyAll();
        }

        [Fact]
        public void Test_計測登録_シナリオ_エラーチェック()
        {
            var measureMock   = new Mock<IMeasureRepository>();
            var viewModelMock = new Mock<MeasureSaveViewModel>(measureMock.Object);

            viewModelMock.Setup(x => x.GetDateTime()).Returns("2017/01/03 03:00:00".ToDate);

            var viewModel = viewModelMock.Object;
            var ex        = Record.Exception(() => viewModel.Save());

            ex.Message.Is("計測値を入力してください。");
        }
    }
}