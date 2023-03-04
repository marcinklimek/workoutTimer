using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text;
using System.Timers;

namespace CountdownTimer_p2
{
    public partial class MainScreen : Form
    {
        private Sounds sounds;
        private WorkoutManager wm;


        public MainScreen()
        {
            InitializeComponent();

            sounds = new Sounds();
            wm = new WorkoutManager();

            wm.OnLastRound += Wm_OnLastRound;
            wm.OnLastTenSeconds += Wm_OnLastTenSeconds;
            wm.OnHalfTime += Wm_OnHalfTime;
            wm.OnNextRound += Wm_OnNextRound;
            wm.OnRestStart += Wm_OnRestStart;

            wm.OnRestTimerTick += Wm_OnRestTimerTick;
            wm.OnWorkTimerTick += Wm_OnWorkTimerTick;

            wm.OnStart += Wm_OnNextRound; // to samo co nastepna runda
            wm.OnFinish += Wm_OnFinish;
        }


        private void MainScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                workBox.Items.Add(i.ToString());
            }
            workBox.SelectedIndex = 1;

            for (int i = 0; i <= 10; i++)
            {
                restBox.Items.Add(i.ToString());
            }

            restBox.SelectedIndex = 1;

            for (int i = 0; i <= 10; i++)
            {
                roundBox.Items.Add(i.ToString());
            }
            roundBox.SelectedIndex = 1;


            resetButton.Enabled = false;
            pauseButton.Enabled = false;

            ResetInterface();
        }

        private int getTimeInSeconds(string? time)
        {
            if ((time == null) || (time.Length == 0))
            {
                return 0;
            }

            int minutes = int.Parse(time);
            int seconds = minutes / 60;
            
            return  minutes * 60 + seconds;
        }


        private int GetRound()
        {
            return int.Parse(roundBox.SelectedItem.ToString() ?? "0");
        }

        private string GetRoundText()
        {
            return $" seria {(wm.Rounds - wm.CurrentRound + 1)} z {wm.Rounds}";
        }

        private void ResetInterface()
        {
            //todo: add code to clean everyting n the screen afte the workout
            roundDisplayLabelxx.Text = string.Empty;
        }

        private void SetTimerText(int time_seconds)
        {
            int minutes = time_seconds / 60;
            int seconds = time_seconds - (minutes * 60);

            TimerLabel.Text = $"{minutes:00} : {seconds:00}";
        }

        #region Handle UI events
        private void startButton_Click(object sender, EventArgs e)
        {
            resetButton.Enabled = true;
            pauseButton.Enabled = true;
            
            var workS = getTimeInSeconds(workBox?.SelectedItem?.ToString());
            var restS = getTimeInSeconds(restBox?.SelectedItem?.ToString());

            wm.SetupWorkout(workS, restS, GetRound());
            wm.Start();

            roundDisplayLabelxx.Text = GetRoundText();

            TimerLabel.BackColor = Color.Red;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "Pause")
            {
                wm.Stop();

                pauseButton.Text = "Start";

            }
            else
            {
                wm.Pause();

                pauseButton.Text = "Pause";
                TimerLabel.Visible = true;
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            wm.Reset();

            roundDisplayLabelxx.Text = GetRoundText();

            TimerLabel.BackColor = Color.Gray;

            TimerLabel.Text = "";
            roundDisplayLabelxx.Text = "";
        }
        #endregion

        #region Handle Events from Workout manager


        private void Wm_OnWorkTimerTick(object? sender, WorkoutManager.SecondsEventArgs e)
        {
            BeginInvoke(() =>
            {
                SetTimerText(e.Seconds);
            });
        }

        private void Wm_OnRestTimerTick(object? sender, WorkoutManager.SecondsEventArgs e)
        {
            BeginInvoke( () =>
            {
                 SetTimerText(e.Seconds);
            });
        }

        private void Wm_OnNextRound(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                roundDisplayLabelxx.Text = GetRoundText();
                TimerLabel.BackColor = Color.Red;
                sounds.round();
            });
        }

        private void Wm_OnHalfTime(object? sender, EventArgs e)
        {
            sounds.warning();
        }

        private void Wm_OnLastTenSeconds(object? sender, EventArgs e)
        {
            sounds.beep();
        }

        private void Wm_OnLastRound(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                roundDisplayLabelxx.Text = GetRoundText();
                TimerLabel.BackColor = Color.Red;
                sounds.final();
            });
        }

        private void Wm_OnRestStart(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                TimerLabel.BackColor = Color.YellowGreen; 
            });
        }

        private void Wm_OnFinish(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                sounds.applause();

                roundDisplayLabelxx.Text = GetRoundText();

                TimerLabel.BackColor = Color.DeepSkyBlue;

                TimerLabel.Text = ("FUCK");
                roundDisplayLabelxx.Text = ("<FUCK-MORE!>");
            });
        }

#endregion
    }
}

