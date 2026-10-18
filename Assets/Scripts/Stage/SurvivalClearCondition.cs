/// <summary>
/// 規定時間を守り抜いたか判定する。時間を進める責務は StageSession に残す。
/// </summary>
public sealed class SurvivalClearCondition
{
    // 予定: StageSession を受け取るコンストラクター。
    // null の場合の扱いを決め、依存先を差し替えられるようにする。

    // 予定: public bool IsSatisfied()
    // ElapsedTime が Duration に達したとき true を返す案。
    // 境界の直前・到達時・到達後を確認する。
    // 実装時に IStageClearCondition を実装する。
}
