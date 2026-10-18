using UnityEngine;

/// <summary>
/// 防衛対象の最大 HP と Prefab を設定する静的データ。
/// </summary>
public sealed class TreasureData : ScriptableObject
{
    // Asset を Inspector から作る段階で CreateAssetMenu の設定を追加する。
    // 予定: MaximumHealth、Prefab。
    // 最大 HP が 0 以下の設定をどう扱うか決める。
    // 宝箱の物理的位置はゲーム仕様で未決定。
}
