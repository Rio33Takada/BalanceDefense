using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// 山札にあるカードの順序と枚数を管理する。手札・捨て札の変更は担当しない。
/// </summary>
public sealed class CardDeck
{
    // 予定: public int Count { get; }
    public int Count => _cards.Count;

    // 予定: public IReadOnlyList<CardInstance> Cards { get; }
    private List<CardInstance> _cards = new();

    public IReadOnlyList<CardInstance> Cards => _cards.AsReadOnly();

    // 予定: public void Initialize(IEnumerable<CardInstance> cards)
    // 入力カードを山札へ設定する。null 要素と重複 InstanceId の扱いを決める。
    public void Initialize(IEnumerable<CardInstance> cards)
    {
        if (cards == null)
        {
            throw new ArgumentNullException(
                nameof(cards));
        }

        List<CardInstance> copiedCards = new();

        foreach (CardInstance card in cards)
        {
            if (card == null)
            {
                throw new ArgumentException(
                    "カードインスタンス一覧にnullを含めることはできません。",
                    nameof(cards));
            }

            copiedCards.Add(card);
        }

        _cards = copiedCards;
    }

    // 予定: public void Shuffle()
    // シャッフルの乱数をテスト可能にする方法を決める。
    public void Shuffle()
    {

    }

    // 予定: public bool TryDraw(out CardInstance card)
    // 山札が空なら false を返し、カードを取り出さない。
    public bool TryDraw(out CardInstance card)
    {
        if (Count == 0)
        {
            card = null;
            return false;
        }

        card = _cards.FirstOrDefault();
        _cards.RemoveAt(0);

        return true;
    }

    // 予定: public void Add(CardInstance card)
    // 再投入が必要になった場合に使用する。捨て札の再循環は未決定。
    public void Add(CardInstance card)
    {
        if (card == null)
        {
            throw new ArgumentNullException(
                nameof(card));
        }

        _cards.Add(card);
    }

    public void Add(IEnumerable<CardInstance> cards)
    {
        if (cards == null)
        {
            throw new ArgumentNullException(
                nameof(cards));
        }

        List<CardInstance> copiedCards = cards.ToList();

        if (copiedCards.Any(card => card == null))
        {
            throw new ArgumentException(
                "追加するカード一覧にnullを含めることはできません。",
                nameof(cards));
        }

        _cards.AddRange(cards);
    }
}
