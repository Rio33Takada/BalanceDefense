/// <summary>
/// 防衛対象の破壊を敗北条件として判定する。宝箱の HP 更新は担当しない。
/// </summary>
public sealed class TreasureDestroyedCondition
{
    // 予定: Treasure を受け取るコンストラクター。
    // 参照が null の場合は判定前に確認する。

    // 予定: public bool IsSatisfied()
    // 宝箱の生存状態を読み取る。HP が 0 以下で敗北とする案はゲーム仕様では設計案。
    // 実装時に IStageFailureCondition を実装する。
}
