using UnityEngine;

/// <summary>
/// 配置されたキャラクターの構成窓口。物理挙動と攻撃挙動は専用コンポーネントへ委ねる。
/// </summary>
public sealed class Character : MonoBehaviour
{
    // 予定: public CharacterData Data { get; }
    // 予定: public CharacterPhysics2D Physics { get; }
    // 予定: public AutoAttackController Attack { get; }
    // 攻撃コンポーネントを追加する段階で型と依存関係を確定する。

    // 予定: public void Initialize(CharacterData data)
    // null と必要コンポーネントの欠落を確認する。代替オブジェクトは生成しない。
}
