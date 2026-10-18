using UnityEngine;

[CreateAssetMenu(
    fileName = "DeckData",
    menuName = "Balance Defense/Deck Data"
    )]
public sealed class DeckData : ScriptableObject
{
    // ステージ開始時のカード構成と手札容量を設定する。
    // 予定: Cards、InitialHandSize、MaximumHandSize。
    // 初期手札枚数が上限やカード総数を超える場合の扱いは未決定。
}
