using UnityEngine;

/// <summary>
/// キャラクター生成の契約。配置処理が具体的な Prefab 生成方法へ依存しないようにする。
/// </summary>
public interface ICharacterSpawner
{
    /// <summary>指定した種類を指定位置に生成する。失敗時の扱いは実装時に決める。</summary>
    Character Spawn(CharacterData data, Vector2 position);
}
