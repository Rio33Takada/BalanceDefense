/// <summary>
/// 1 ステージの経過時間と残り時間を保持する。勝敗の判定や画面表示は担当しない。
/// 最初に実装すると、Scene を用意せず EditMode で時間の進行を確認できる。
/// </summary>
public sealed class StageSession
{
    // 予定: StageSession(float duration)
    // duration はステージの制限時間。0 以下の値をどう扱うか決めてから検証する。

    // 予定: public float Duration { get; }
    // 予定: public float ElapsedTime { get; }
    // 予定: public float RemainingTime { get; }
    // 予定: public bool IsRunning { get; }
    // 残り時間は 0 未満にならないようにする案。時間切れ時に自動停止するかは未決定。

    // 予定: public void Start()
    // 経過時間の初期化と計測開始を担当する。再度呼んだ場合の扱いを決める。

    // 予定: public void Tick(float deltaTime)
    // 計測中だけ経過時間を進める。負の deltaTime の扱いを決める。
    // 時間は呼び出し側から渡し、ITimeProvider との依存の重複を避ける案。

    // 予定: public void Stop()
    // 計測を止める。停止後の Tick では時間が進まないことを確認する。
}
