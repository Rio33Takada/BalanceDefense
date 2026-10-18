/// <summary>
/// いつ何枚ドローするか決める契約。具体的なタイミングはゲーム仕様で未決定。
/// </summary>
public interface ICardDrawPolicy
{
    /// <summary>今ドローする条件を満たすとき true を返す。</summary>
    bool ShouldDraw();

    /// <summary>今回のドロー枚数を返す。0 以下の値をどう扱うかは実装時に決める。</summary>
    int GetDrawCount();
}
