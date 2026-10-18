/// <summary>
/// ステージの敗北条件を判定する契約。敗北理由ごとの処理を分離する。
/// </summary>
public interface IStageFailureCondition
{
    /// <summary>現在の状態で敗北条件を満たすとき true を返す。</summary>
    bool IsSatisfied();
}
