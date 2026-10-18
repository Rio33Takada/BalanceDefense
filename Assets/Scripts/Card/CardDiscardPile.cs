/// <summary>
/// 使用後のカードを保持する。山札へ戻す時期はドロー方針側で決める。
/// </summary>
public sealed class CardDiscardPile
{
    // 予定: public int Count { get; }
    // 予定: public IReadOnlyList<CardInstance> Cards { get; }

    // 予定: public void Add(CardInstance card)
    // null と同一インスタンスの重複登録をどう扱うか決める。

    // 予定: public IReadOnlyList<CardInstance> TakeAll()
    // 全件取り出した後は捨て札を空にする。返す一覧の所有権を明確にする。

    // 予定: public void Clear()
}
