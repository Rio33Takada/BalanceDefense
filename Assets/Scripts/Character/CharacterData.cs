using UnityEngine;

/// <summary>
/// キャラクターの能力値と参照する Prefab をまとめる静的データ。
/// 実行中の位置や攻撃待ち時間は保持しない。
/// </summary>
public sealed class CharacterData : ScriptableObject
{
    // Asset を Inspector から作る段階で CreateAssetMenu の設定を追加する。
    // 予定: CharacterId、Mass、AttackDamage、AttackRange、AttackInterval、Projectile、Prefab。
    // 物理値と攻撃値の有効範囲を決める。未作成の Prefab は null を確認する。
}
