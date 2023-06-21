namespace BullsAndCows.Core
{
    public class GuessResult
    {
        public bool IsCorrect { get; private set; }

        public int GuessedCount { get; private set; }

        public int PlacedCount { get; private set; }

        public GuessResult(bool isCorrect, int guessedCount, int placedCount)
        {
            IsCorrect = isCorrect;
            GuessedCount = guessedCount;
            PlacedCount = placedCount;
        }
    }
}
