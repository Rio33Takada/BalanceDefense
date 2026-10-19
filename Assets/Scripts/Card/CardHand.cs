using System.Collections.Generic;
using System.Linq;


/// <summary>
/// 手札のカードと枚数上限を管理する。山札から引く判断は担当しない。
/// </summary>
public sealed class CardHand
{
    // 予定: public int Count { get; }
    public int Count => _cards.Count;

    // 予定: public int MaximumCount { get; }
    private int _maximumCount;

    public int MaximumCount => _maximumCount;

    // 予定: public IReadOnlyList<CardInstance> Cards { get; }
    private List<CardInstance> _cards;
    public IReadOnlyList<CardInstance> Cards => _cards;

    // 予定: public bool CanAdd()
    public bool CanAdd()
    {
        return Count < MaximumCount;
    }

    // 予定: public bool Contains(CardInstance card)
    public bool Contains(CardInstance card)
    {
        return Cards.Contains(card);
    }

    // 予定: public bool TryAdd(CardInstance card)
    // 上限を超える場合は false を返し、手札を変更しない。
    public bool TryAdd(CardInstance card)
    {
        if (!CanAdd())
        {
            return false;
        }

        _cards.Add(card);
        return true;
    }

    // 予定: public bool Remove(CardInstance card)
    // 見つからない場合は false を返す案。

    // 予定: public void Clear()
    // 取り除いたカードの移動先は呼び出し側が決める。
}
