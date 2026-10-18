/// <summary>
/// 手札のカードと枚数上限を管理する。山札から引く判断は担当しない。
/// </summary>
public sealed class CardHand
{
    // 予定: public int Count { get; }
    // 予定: public int MaximumCount { get; }
    // 予定: public IReadOnlyList<CardInstance> Cards { get; }

    // 予定: public bool CanAdd()
    // 予定: public bool Contains(CardInstance card)
    // 予定: public bool TryAdd(CardInstance card)
    // 上限を超える場合は false を返し、手札を変更しない。

    // 予定: public bool Remove(CardInstance card)
    // 見つからない場合は false を返す案。

    // 予定: public void Clear()
    // 取り除いたカードの移動先は呼び出し側が決める。
}
