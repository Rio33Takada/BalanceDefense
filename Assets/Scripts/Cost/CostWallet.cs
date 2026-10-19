using System;
/// <summary>
/// 現在のコストを保持し、消費と回復の境界を管理する。
/// 時間経過による回復量の計算は CostRegenerator に委ねる。
/// </summary>
public sealed class CostWallet
{
    private readonly CostSettings _settings;

    // 予定: public float CurrentCost { get; }
    private float _currentCost;

    public float CurrentCost => _currentCost;

    // 予定: public float MaximumCost { get; }
    private float _maximumCost;

    public float MaximumCost => _maximumCost;
    // 外部から残高を直接変更できない形にする。

    public CostWallet(CostSettings settings)
    {
        _settings = settings
            ?? throw new ArgumentNullException(
                nameof(settings));
    }

    // 予定: public bool CanSpend(float amount)
    public bool CanSpend(float amount)
    {
        if (float.IsNaN(amount))
        {
            return false;
        }

        return amount <= _currentCost;
    }

    // 予定: public bool TrySpend(float amount)
    // 残高不足なら false を返して残高を変えない。負の amount の扱いを決める。
    public bool TrySpend(float amount)
    {
        if (float.IsInfinity(amount)
            || float.IsNaN(amount)
            || amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                "コスト消費量は正の有限値である必要があります。");
        }

        if (CanSpend(amount))
        {
            _currentCost -= amount;
            return true;
        }

        return false;
    }

    // 予定: public void Restore(float amount)
    // 最大値を超えないよう回復する。負の amount の扱いを決める。
    public void Restore(float amount)
    {
        if (float.IsInfinity(amount)
            || float.IsNaN(amount)
            || amount < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                "コスト回復量は正の有限値である必要があります。");
        }

        _currentCost = Math.Max(CurrentCost + amount, MaximumCost);
    }

    // 予定: public void Reset()
    // CostSettings の初期値へ戻す。設定は生成時に受け取る案。
    public void Reset()
    {
        _currentCost = _settings.InitialCost;
        _maximumCost = _settings.MaximumCost;
    }
}
