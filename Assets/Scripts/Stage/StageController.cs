/// <summary>
/// ステージの開始、進行、停止を調整する。時間・敵出現・勝敗判定の処理は各担当へ委ねる。
/// </summary>
public sealed class StageController
{
    // 予定: public StageData CurrentStage { get; }
    // 現在のステージ設定を公開する。未初期化時の値は未決定。

    // 予定: public void Initialize(StageData stageData)
    // StageSession と敵出現、勝敗条件に設定を渡す。stageData が null の場合を扱う。

    // 予定: public void Start()
    // 予定: public void Tick(float deltaTime)
    // 予定: public void Stop()
    // 各担当の呼び出し順と、クリア・失敗が同時に成立した場合の優先順位は未決定。
}
