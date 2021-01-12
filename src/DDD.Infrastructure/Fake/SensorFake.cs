namespace DDD.Infrastructure.Fake
{
    using System;
    using Domain.Repositories;
    using Domain.Helpers;
    using Domain.ValueObjects;

    /// <summary>
    /// <see cref="ISensorRepository"/> の具象クラス
    /// このクラスは何らかのセンサーの値を取得する目的で作られた、仮想のセンサークラスです。
    /// </summary>
    /// <remarks>
    /// アクセス修飾子は internal にして外部プロジェクトから参照できないようにする。
    /// インスタンスの生成には <see cref="Factories"/> を使用する。
    ///
    /// こうしなければ、アプリケーションロジック（UI 層）が知識を持ってしまう。
    /// 例えば、実際にドライバーのセンサーを取得するようなコードが後々作られた場合、アプリケーションロジックでは以下のようなコードが書かれる可能性がある。
    /// <code><![CDATA[
    /// ISensorRepository repository;
    /// if (Configuration.IsFake)       // 仮に外部ファイルなどから擬似クラスを使用するかどうかを判定するものとする。
    /// {
    ///     repository = new SensorFake();
    /// } else {
    ///     repository = new SensorDriver();
    /// }
    ///
    /// var viewModel = new MeasureViewModel(repository);
    /// ]]></code>
    ///
    /// これでは、<see cref="ISensorRepository"/> のインスタンス生成を実行している各所で似たようなロジックが散らばってしまう。
    /// システムを安定させるためにはインスタンスの生成は一箇所で行い、アプリケーション全体でそのルールを遵守しなければならない。
    /// </remarks>
    internal sealed class SensorFake : ISensorRepository
    {
        private readonly Random _random = new Random();

        public MeasureValue GetData()
        {
            return new MeasureValue(_random.Next(0, 3) + _random.NextDouble().ToSingle());
        }
    }
}