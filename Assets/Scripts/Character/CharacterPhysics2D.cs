using UnityEngine;

/// <summary>
/// Rigidbody2D を使うキャラクターの質量と物理状態を扱う。
/// 足場から落ちた後の扱いは別の担当に委ね、現時点では未決定とする。
/// </summary>
public sealed class CharacterPhysics2D : MonoBehaviour
{
    // 予定: public Rigidbody2D Rigidbody { get; }
    // 予定: public float Mass { get; }

    // 予定: public void Initialize(float mass)
    // Rigidbody2D の参照を確認し、質量を適用する。無効な質量の扱いを決める。

    // 予定: public void EnablePhysics()
    // 予定: public void DisablePhysics()
    // 物理状態を切り替えた後の速度・接触状態の扱いを確認する。
}
