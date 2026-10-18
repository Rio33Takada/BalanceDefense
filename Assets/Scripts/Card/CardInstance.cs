/// <summary>
/// 山札・手札・捨て札を移動するカード 1 枚の識別情報を保持する。
/// 種類に共通する値は CardData に置き、この型へ重複させない。
/// </summary>
public sealed class CardInstance
{
    // 予定: public string InstanceId { get; }
    // 予定: public CardData Data { get; }
    // 同じ CardData から作られたカードも InstanceId で区別する。
}
