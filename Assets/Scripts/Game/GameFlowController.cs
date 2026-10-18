/// <summary>
/// ゲーム全体の状態遷移を管理する。ステージの時間計測や UI 表示は担当しない。
/// </summary>
public sealed class GameFlowController
{
    public GameState CurrentState { get; }

    // 予定: public void StartStage(StageData stageData)
    // ステージを初期化し、準備またはプレイ状態へ移す。引数が null の場合を扱う。

    // 予定: public void CompleteStage()
    // クリア条件成立後に呼ぶ。不正な現在状態からの遷移をどう扱うか決める。

    // 予定: public void FailStage()
    // 敗北条件成立後に呼ぶ。クリアとの同時成立時の優先順位は未決定。

    // 予定: public void ReturnToStageSelect()
    // ステージ選択へ戻るときの StageController 停止と状態更新を調整する。
}
