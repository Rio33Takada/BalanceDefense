/// <summary>
/// 山札にあるカードの順序と枚数を管理する。手札・捨て札の変更は担当しない。
/// </summary>
public sealed class CardDeck
{
    // 予定: public int Count { get; }
    // 予定: public IReadOnlyList<CardInstance> Cards { get; }

    // 予定: public void Initialize(IEnumerable<CardInstance> cards)
    // 入力カードを山札へ設定する。null 要素と重複 InstanceId の扱いを決める。

    // 予定: public void Shuffle()
    // シャッフルの乱数をテスト可能にする方法を決める。

    // 予定: public bool TryDraw(out CardInstance card)
    // 山札が空なら false を返し、カードを取り出さない。

    // 予定: public void Add(CardInstance card)
    // 再投入が必要になった場合に使用する。捨て札の再循環は未決定。
}
