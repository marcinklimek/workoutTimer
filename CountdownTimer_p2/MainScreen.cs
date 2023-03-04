using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing.Text;
using System.Media;
using System.Text;

namespace CountdownTimer_p2
{
    #region
    public partial class MainScreen : Form
    {
        private int total_work_seconds;
        private int total_rest_seconds;
        private int current_round;

        SoundPlayer? beepPlay;
        SoundPlayer? roundPlay;
        SoundPlayer? monsterPlay;
        SoundPlayer? applausePlay;
        SoundPlayer? warningPlay;
        SoundPlayer? finalPlay;

        private int total_work_seconds_half;
        private int total_rest_seconds_half;


        public MainScreen()
        {
            InitializeComponent();
        }

        private void SetupSounds()
        {
            beepPlay = new SoundPlayer(@"sounds\beep.wav");
            roundPlay = new SoundPlayer(@"sounds\Gong.wav");
            monsterPlay = new SoundPlayer(@"sounds\monster.wav");
            applausePlay = new SoundPlayer(@"sounds\applause.wav");
            warningPlay = new SoundPlayer(@"sounds\emergency.wav");
            finalPlay = new SoundPlayer(@"sounds\final.wav");
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            SetupSounds();

            for (int i = 0; i <= 10; i++)
            {
                workBox.Items.Add(i.ToString());
            }
            workBox.SelectedIndex = 2;

            for (int i = 0; i <= 10; i++)
            {
                restBox.Items.Add(i.ToString());
            }

            restBox.SelectedIndex = 2;

            for (int i = 0; i <= 10; i++)
            {
                roundBox.Items.Add(i.ToString());
            }
            roundBox.SelectedIndex = 2;


            workTimer.Interval = 75;
            restTimer.Interval = 75;

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


        private void setupWorkTimer()
        {
            total_work_seconds = getTimeInSeconds(workBox?.SelectedItem?.ToString());
            total_work_seconds_half = total_work_seconds / 2;

            roundSound();
        }

        private void setupRestTimer()
        {
            total_rest_seconds = getTimeInSeconds(restBox.SelectedItem.ToString());
            total_rest_seconds_half = total_rest_seconds / 2;
        }

        private void setupTimers()
        {
            TimerLabel.BackColor = Color.Red;

            setupWorkTimer();
            workTimer.Enabled = true;

            setupRestTimer();
            restTimer.Enabled = false;
        }

        private void setCurrentRound()
        {
            string str = roundBox.SelectedItem.ToString() ?? "0";

            current_round = int.Parse(str);
        }

        private void beepSound()
        {
            beepPlay?.Play();
        }

        private void roundSound()
        {
            roundPlay?.Play();
        }

        private void monsterSound()
        {
            monsterPlay?.Play();
        }

        private void applauseSound()
        {
            applausePlay?.Play();
        }
        private void warningSound()
        {
            warningPlay?.Play();
        }
        private void finalSound()
        {
            finalPlay?.Play();
        }

        private int GetRound()
        {
            return int.Parse(roundBox.SelectedItem.ToString() ?? "0");
        }

        private string GetRoundText()
        {
            return $" seria {(GetRound() - current_round + 1)} z {GetRound()}";
        }

        private void ResetInterface()
        {
            //todo: add code to clean everyting n the screen afte the workout
            roundDisplayLabelxx.Text = string.Empty;
        }
        #endregion

        private void startButton_Click(object sender, EventArgs e)
        {
            resetButton.Enabled = true;
            pauseButton.Enabled = true;

            setupTimers();
            setCurrentRound();

            roundDisplayLabelxx.Text = GetRoundText();
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            if (total_work_seconds > 0)
            {

                total_work_seconds--;

                SetTimerText(total_work_seconds);

                if (total_work_seconds == total_work_seconds_half)
                {
                    warningSound();
                }

                if (total_work_seconds <= 10)
                {
                    beepSound();
                }

            }
            else
            {
                if (current_round == 1) // ostatnia
                {

                    restTimer.Enabled = false;

                    TimerLabel.BackColor = Color.DeepSkyBlue;

                    TimerLabel.Text = ("FUCK");
                    roundDisplayLabelxx.Text = ("<FUCK-MORE!>");

                    applauseSound();
                }
                else
                {
                    TimerLabel.BackColor = Color.YellowGreen;

                    monsterSound();

                    workTimer.Stop();
                    restTimer.Enabled = true;
                }
            }
        }

        private void restTimer_Tick(object sender, EventArgs e)
        {
            if (total_rest_seconds > 0)
            {
                total_rest_seconds--;
                SetTimerText(total_rest_seconds);

                if (total_rest_seconds <= 10)
                {
                    beepSound();
                }

                if (total_rest_seconds == total_rest_seconds_half)
                {
                    warningSound();
                }
            }
            else
            {
                restTimer.Stop();

                current_round--;

                Debug.WriteLine($"current_round = {current_round}");

                if (current_round > 0)
                {
                    setupTimers();

                    roundDisplayLabelxx.Text = GetRoundText();

                    workTimer.Start();

                    if (current_round == 1) // przedostatnia
                        finalSound();
                    
                }
            }
        }

        private void SetTimerText(int time_seconds)
        {
            int minutes = time_seconds / 60;
            int seconds = time_seconds - (minutes * 60);

            TimerLabel.Text = $"{minutes:00} : {seconds:00}";
        }

        private void roundDisplayLabel_Click(object sender, EventArgs e)
        {
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "Pause")
            {
                workTimer.Stop();

                pauseButton.Text = "Start";

            }
            else
            {
                pauseButton.Text = "Pause";
                TimerLabel.Visible = true;

                workTimer.Enabled = true;

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            workTimer.Stop();
            restTimer.Stop();

        }
    }
}

