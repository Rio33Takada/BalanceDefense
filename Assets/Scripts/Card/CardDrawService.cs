/// <summary>
/// ドロー方針に従い、山札から手札への移動を調整する。
/// 山札・手札・ドロー方針の個別処理はそれぞれに委ねる。
/// </summary>
public sealed class CardDrawService
{
    // 予定: CardDeck、CardHand、ICardDrawPolicy を生成時に受け取る。

    // 予定: public bool CanDraw()
    // 山札残数、手札上限、ドロー方針を確認する。

    // 予定: public bool TryDraw()
    // 1 枚移動できた場合だけ成功とする案。失敗時に山札の枚数を変えない。

    // 予定: public int Draw(int count)
    // 実際に移した枚数を返す案。山札切れと手札上限の境界を確認する。
    // 捨て札の再シャッフルはゲーム仕様で未決定。
}
