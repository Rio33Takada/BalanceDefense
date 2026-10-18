/// <summary>
/// ダメージを受ける対象の契約。キャラクターは敵からのダメージを受けない仕様。
/// </summary>
public interface IDamageable
{
    /// <summary>生存している場合だけ true を返す。</summary>
    bool IsAlive { get; }

    /// <summary>ダメージを受け、対象自身が HP と生存状態を更新する。</summary>
    void TakeDamage(DamageInfo damage);
}
