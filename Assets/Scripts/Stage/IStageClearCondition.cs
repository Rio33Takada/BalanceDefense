/// <summary>
/// ステージをクリアできるか判定する契約。時間以外の条件を追加しても呼び出し側を変えない。
/// </summary>
public interface IStageClearCondition
{
    /// <summary>現在の状態でクリア条件を満たすとき true を返す。</summary>
    bool IsSatisfied();
}
