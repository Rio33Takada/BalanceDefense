using UnityEngine;

[CreateAssetMenu(
    fileName = "StageData",
    menuName = "Balance Defense/Stage Data"
    )]
public sealed class StageData : ScriptableObject
{
    // ステージごとに変わらない設定だけを保持し、進行中の残り時間を置かない。
    // 予定: StageId、SurvivalDuration、EnemySpawns、Platform、Treasure、InitialDeck、CostSettings。
    // SurvivalDuration は StageSession の Duration に渡す。
    // 未作成の ScriptableObject や Prefab 参照は null を確認するにとどめる。
}
