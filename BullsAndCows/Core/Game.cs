using System;
using System.Diagnostics;
using System.Linq;

namespace BullsAndCows.Core
{
    public class Game
    {
        private int _guessedNumber;
        private Stopwatch _stopwatch;

        public int GuessCount { get; private set; }

        public bool InProgress { get; private set; }

        public int ElapsedInSecs => Convert.ToInt32(_stopwatch.Elapsed.TotalSeconds);

        public void StartNew(int numberLength)
        {
            GuessNewNumber(numberLength);
            _stopwatch = Stopwatch.StartNew();
            GuessCount = 0;
            InProgress = true;
        }

        private void GuessNewNumber(int numberLength)
        {
            var random = new Random();
            var minValue = Convert.ToInt32(Math.Pow(10, numberLength - 1));
            var maxValue = Convert.ToInt32(Math.Pow(10, numberLength));
            _guessedNumber = random.Next(minValue, maxValue);
        }

        public GuessResult TryGuess(int number)
        {
            var isCorrect = _guessedNumber == number;
            if (isCorrect)
                Finish();

            (var guessedCount, var placedCount) = GetNumberState(number);
            GuessCount++;
            return new GuessResult(isCorrect, guessedCount, placedCount);
        }

        public void Finish()
        {
            InProgress = false;
            _stopwatch.Stop();
        }

        private (int, int) GetNumberState(int number)
        {
            var guessedCount = 0;
            var correctPlaceCount = 0;

            var guessedNumberString = _guessedNumber.ToString();
            var numberString = number.ToString();
            for (int i = 0; i < Math.Min(numberString.Length, guessedNumberString.Length); i++)
            {
                if (guessedNumberString.Contains(numberString[i]))
                    guessedCount++;

                if (guessedNumberString[i] == numberString[i])
                    correctPlaceCount++;
            }

            return (guessedCount, correctPlaceCount);
        }

    }
}
