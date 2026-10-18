/// <summary>
/// 現在のコストを保持し、消費と回復の境界を管理する。
/// 時間経過による回復量の計算は CostRegenerator に委ねる。
/// </summary>
public sealed class CostWallet
{
    // 予定: public float CurrentCost { get; }
    // 予定: public float MaximumCost { get; }
    // 外部から残高を直接変更できない形にする。

    // 予定: public bool CanSpend(float amount)
    // 予定: public bool TrySpend(float amount)
    // 残高不足なら false を返して残高を変えない。負の amount の扱いを決める。

    // 予定: public void Restore(float amount)
    // 最大値を超えないよう回復する。負の amount の扱いを決める。

    // 予定: public void Reset()
    // CostSettings の初期値へ戻す。設定は生成時に受け取る案。
}
