using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Text;
using System.Text;
using System.Timers;

namespace WorkoutTimer
{
    public partial class MainScreen : Form
    {
        private Sounds sounds;
        private WorkoutManager manager;


        public MainScreen(WorkoutManager wm)
        {
            InitializeComponent();

            manager = wm;
            sounds = new Sounds();
           

            manager.OnLastRound += ManagerOnLastRound;
            manager.OnLastTenSeconds += ManagerOnLastTenSeconds;
            manager.OnHalfTime += ManagerOnHalfTime;
            manager.OnNextRound += ManagerOnNextRound;
            manager.OnRestStart += ManagerOnRestStart;

            manager.OnRestTimerTick += ManagerOnRestTimerTick;
            manager.OnWorkTimerTick += ManagerOnWorkTimerTick;

            manager.OnStart += ManagerOnNextRound; // to samo co nastepna runda
            manager.OnFinish += ManagerOnFinish;
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
            return $" seria {(manager.Rounds - manager.CurrentRound + 1)} z {manager.Rounds}";
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
            
            var wp = new WorkoutParameters
            {
                workout = getTimeInSeconds(workBox?.SelectedItem?.ToString()),
                rest = getTimeInSeconds(restBox?.SelectedItem?.ToString()),
                rounds = GetRound()
            };

            manager.SetupWorkout(wp);
            manager.Start();

            roundDisplayLabelxx.Text = GetRoundText();

            TimerLabel.BackColor = Color.Red;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "Pause")
            {
                manager.Stop();

                pauseButton.Text = "Start";

            }
            else
            {
                manager.Pause();

                pauseButton.Text = "Pause";
                TimerLabel.Visible = true;
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            manager.Reset();

            roundDisplayLabelxx.Text = GetRoundText();

            TimerLabel.BackColor = Color.Gray;

            TimerLabel.Text = "";
            roundDisplayLabelxx.Text = "";
        }
        #endregion

        #region Handle Events from Workout manager


        private void ManagerOnWorkTimerTick(object? sender, WorkoutManager.SecondsEventArgs e)
        {
            BeginInvoke(() =>
            {
                SetTimerText(e.Seconds);
            });
        }

        private void ManagerOnRestTimerTick(object? sender, WorkoutManager.SecondsEventArgs e)
        {
            BeginInvoke( () =>
            {
                 SetTimerText(e.Seconds);
            });
        }

        private void ManagerOnNextRound(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                roundDisplayLabelxx.Text = GetRoundText();
                TimerLabel.BackColor = Color.Red;
                sounds.round();
            });
        }

        private void ManagerOnHalfTime(object? sender, EventArgs e)
        {
            sounds.warning();
        }

        private void ManagerOnLastTenSeconds(object? sender, EventArgs e)
        {
            sounds.beep();
        }

        private void ManagerOnLastRound(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                roundDisplayLabelxx.Text = GetRoundText();
                TimerLabel.BackColor = Color.Red;
                sounds.final();
            });
        }

        private void ManagerOnRestStart(object? sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                sounds.monster();
                TimerLabel.BackColor = Color.YellowGreen; 
            });
        }

        private void ManagerOnFinish(object? sender, EventArgs e)
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

