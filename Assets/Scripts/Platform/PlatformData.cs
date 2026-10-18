using UnityEngine;

/// <summary>
/// 足場の質量、回転範囲、摩擦材、Prefab を設定する静的データ。
/// </summary>
public sealed class PlatformData : ScriptableObject
{
    // Asset を Inspector から作る段階で CreateAssetMenu の設定を追加する。
    // 予定: Mass、AngularDrag、MinimumAngle、MaximumAngle、SurfaceMaterial、Prefab。
    // 角度の大小関係と物理値の有効範囲を決める。
    // 足場の個数・構造はゲーム仕様で未決定。
}
