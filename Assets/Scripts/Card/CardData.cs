using UnityEngine;

[CreateAssetMenu(
    fileName = "CardData",
    menuName = "Balance Defense/Card Data"
    )]
public sealed class CardData : ScriptableObject
{
    // カードの種類に共通する静的データだけを保持する。
    // 予定: CardId、Cost、Character、Icon。
    // Cost の負値や Character 未設定を許すかは未決定。
}
