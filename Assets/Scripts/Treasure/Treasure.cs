using UnityEngine;

/// <summary>
/// 防衛対象の HP と生存状態を管理する。敗北判定は TreasureDestroyedCondition に委ねる。
/// </summary>
public sealed class Treasure : MonoBehaviour
{
    // 予定: public bool IsAlive { get; }
    // 予定: public float CurrentHealth { get; }
    // 予定: public float MaximumHealth { get; }

    // 予定: public void Initialize(TreasureData data)
    // data の null を確認し、最大 HP と現在 HP を設定する。

    // 予定: public void TakeDamage(DamageInfo damage)
    // HP を 0 未満にしない案。0 ダメージや負のダメージの扱いを決める。
    // 実装時に IDamageable を実装する。
}
