using BullsAndCows.Core;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Form1 : Form
    {
        private readonly Game _game;
        private CancellationTokenSource _cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            _game = new Game();
        }

        private void StartButtonClicked(object sender, EventArgs e)
        {
            var numberLength = Convert.ToInt32(numberLengthInput.Value);
            _game.StartNew(numberLength);
            UpdateUIToStartState();
            StartTimer();
        }

        private void UpdateUIToStartState()
        {
            startButton.Text = "Стоп";
            guessInput.Enabled = true;
            correctCount.Text = "0";
            placedCount.Text = "0";
            guessCount.Text = "Попыток: 0";
        }

        private void StartTimer()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Timer(_cancellationTokenSource.Token);
        }

        private async Task Timer(CancellationToken token)
        {
            try
            {
                var startTime = DateTime.Now;
                while (token.IsCancellationRequested is false)
                {
                    spentTime.Text = $"Затраченное время: {_game.ElapsedInSecs} сек";
                    await Task.Delay(TimeSpan.FromSeconds(1));
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void GuessInputChanged(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar != '\r')
            {
                return;
            }

            if (int.TryParse(guessInput.Text, out var guess) is false)
                return;
            var result = _game.TryGuess(guess);
            if (result.IsCorrect)
            {
                StopGame();
            }

            correctCount.Text = result.GuessedCount.ToString();
            placedCount.Text = result.PlacedCount.ToString();
            guessCount.Text = $"Попыток: {_game.GuessCount}";

            e.Handled = true;
        }

        private void StopButtonClick(object sender, EventArgs e)
        {
            StopGame();
        }

        private void StopGame()
        {
            _game.Finish();
            _cancellationTokenSource?.Cancel();
            UpdateUIToStopState();
        }

        private void UpdateUIToStopState()
        {
            startButton.Text = "Старт";
            guessInput.Enabled = false;
        }
    }
}
