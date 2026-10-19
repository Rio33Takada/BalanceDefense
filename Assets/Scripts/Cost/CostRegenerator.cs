using System;

/// <summary>
/// 経過時間からコストの回復量を求め、CostWallet に反映する。
/// 残高の保持や UI 表示は担当しない。
/// </summary>
public sealed class CostRegenerator
{
    // 予定: public float RecoveryRate { get; }
    // 回復速度と CostWallet を生成時に受け取る案。
    public float RecoveryRate { get; }

    public CostRegenerator(CostWallet wallet)
    {
        if (wallet == null)
        {
            throw new ArgumentNullException(
                nameof(wallet));
        }
    }

    // 予定: public void Tick(float deltaTime)
    // 回復量は RecoveryRate と deltaTime から求める。
    // 負の経過時間と上限到達時の扱いを確認する。
    public void Tick(float deltaTime)
    {
        // CostSettingsのRecoveryPerSecondが必要?.
    }
}
