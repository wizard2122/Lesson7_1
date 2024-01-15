public class EmptyCoin : Coin
{
    protected override void AddCoins(ICoinPicker coinPicker) => coinPicker.Add(0);
}
