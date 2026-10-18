public enum GameState
{
    StageSelect,
    // クラス設計シートでは Preparation。実装修正時に既存参照を確認して綴りを統一する。
    Preparetion,
    Playing,
    Cleared,
    Failed,
}
