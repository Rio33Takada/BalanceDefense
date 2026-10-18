using UnityEngine;

/// <summary>
/// キャラクターを指定位置へ置けるか判断する契約。
/// </summary>
public interface IPlacementValidator
{
    /// <summary>現在の足場状態で配置可能な場合だけ true を返す。</summary>
    bool CanPlace(CharacterData data, Vector2 position);
}
