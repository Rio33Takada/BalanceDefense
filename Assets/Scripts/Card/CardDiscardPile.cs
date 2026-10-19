using System;
using System.Collections.Generic;


/// <summary>
/// 使用後のカードを保持する。山札へ戻す時期はドロー方針側で決める。
/// </summary>
public sealed class CardDiscardPile
{
    // 予定: public int Count { get; }
    public int Count => _cards.Count;

    // 予定: public IReadOnlyList<CardInstance> Cards { get; }
    private IReadOnlyList<CardInstance> _cards;

    public IReadOnlyList<CardInstance> Cards => _cards;

    // 予定: public void Add(CardInstance card)
    // null と同一インスタンスの重複登録をどう扱うか決める。
    public void Add(CardInstance card)
    {
        if (card == null)
        {
            throw new ArgumentNullException(nameof(card));
        }

        List<CardInstance> copiedCards = new();

        foreach (CardInstance listCard in Cards)
        {
            if (ReferenceEquals(
                listCard,
                card))
            {
                throw new ArgumentException(
                    "捨て札には重複するカードインスタンスを含めることはできません。",
                    nameof(card));
            }

            copiedCards.Add(listCard);
        }

        copiedCards.Add(card);

        _cards = copiedCards.AsReadOnly();
    }

    // 予定: public IReadOnlyList<CardInstance> TakeAll()
    // 全件取り出した後は捨て札を空にする。返す一覧の所有権を明確にする。
    public IReadOnlyList<CardInstance> TakeAll()
    {
        List<CardInstance> copiedCards = new();

        foreach (CardInstance card in Cards)
        {
            copiedCards.Add(card);
        }

        Clear();

        return copiedCards.AsReadOnly();
    }

    // 予定: public void Clear()
    public void Clear()
    {
        _cards = new List<CardInstance>().AsReadOnly();
    }
}
