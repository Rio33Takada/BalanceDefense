using UnityEngine;

/// <summary>
/// 配置判定が通った場合にキャラクター生成を依頼する。
/// カードの消費やコストの変更は CardUseService に委ねる。
/// </summary>
public sealed class PlacementService
{
    // 予定: IPlacementValidator と ICharacterSpawner を生成時に受け取る。

    // 予定: public bool CanPlace(CharacterData data, Vector2 position)
    // 判定専用とし、キャラクターを生成しない。

    // 予定: public bool TryPlace(CharacterData data, Vector2 position)
    // 最終判定に成功した場合だけ生成する。生成失敗時は false にする案。
    // 足場の移動でプレビュー時と結果が異なるケースを確認する。
}
