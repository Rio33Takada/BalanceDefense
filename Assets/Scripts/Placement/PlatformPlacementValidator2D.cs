/// <summary>
/// 2D 足場上への配置可否を判定する。ドラッグ中の UI 表示や生成は担当しない。
/// </summary>
public sealed class PlatformPlacementValidator2D
{
    // 予定: PlatformPhysics2D と配置対象の CharacterData を使用する。

    // 予定: public bool CanPlace(CharacterData data, Vector2 position)
    // ドラッグ終了時点の足場の位置・角度で判定する案。
    // Collider2D がない場合は null を確認して配置を拒否する。
    // 具体的な接触範囲と足場が複数の場合の選択方法は未決定。
    // 実装時に IPlacementValidator を実装する。
}
