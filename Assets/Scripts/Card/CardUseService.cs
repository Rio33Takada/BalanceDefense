using UnityEngine;

/// <summary>
/// カード使用時の手札・コスト・配置・捨て札の整合性を調整する。
/// 個々の残高管理や配置判定は担当しない。
/// </summary>
public sealed class CardUseService
{
    // 予定: CardHand、CostWallet、PlacementService、CardDiscardPile を受け取る。

    // 予定: public bool CanUse(CardInstance card, Vector2 position)
    // 手札内の存在、コスト、配置可否を確認する。

    // 予定: public bool TryUse(CardInstance card, Vector2 position)
    // 配置に失敗した場合、コストと手札を変えないことを確認する。
    // 配置、コスト消費、捨て札移動の順序と失敗時の戻し方は実装前に決める。
}
