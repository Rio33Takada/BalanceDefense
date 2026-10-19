using UnityEngine;

[CreateAssetMenu(
    fileName = "CostSetting",
    menuName = "BalanceDefence/Cost/CostSettings")]

/// <summary>
/// ステージ開始時のコストと最大値、自然回復速度を設定する静的データ。
/// </summary>
public sealed class CostSettings : ScriptableObject
{
    // Asset を Inspector から作る段階で CreateAssetMenu の設定を追加する。
    // 予定: InitialCost、MaximumCost、RecoveryPerSecond。
    // 0 未満や初期値が最大値を超える設定をどう扱うか決める。
    // Inspector で編集する値と外部に公開する値を分ける。
    public int InitialCost;

    public int MaximumCost;

    public float RecoveryPerSecond;
}
