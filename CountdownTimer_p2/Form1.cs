using Microsoft.VisualBasic;
using System.Configuration;
using System.Drawing.Text;
using System.Media;
using System.Text;

namespace CountdownTimer_p2
{
    #region
    public partial class Form1 : Form
    {
        private int totalwSeconds;
        private int totalrSeconds;
        private int currentRound;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            roundBox.SelectedIndex = 3;

            
            workTimer.Interval = 1000;
            restTimer.Interval = 1000;

            resetButton.Enabled = false;
            pauseButton.Enabled = false;

            ResetInterface();
        }

        private void setupWorkTimer()
        {
            string t = workBox.SelectedItem.ToString();

            int minutes = int.Parse(t);
            int seconds = minutes / 60;

            totalwSeconds = (minutes * 60) + seconds;
            roundSound();

            

            

            

        }

        private void setupRestTimer()
        {
            string t = restBox.SelectedItem.ToString();

            int minutes = int.Parse(t);
            int seconds = minutes / 60;

            totalrSeconds = (minutes * 60) + seconds;

           

        }

        private void setupTimers()
        {
            setupWorkTimer();
            workTimer.Enabled = true;

            setupRestTimer();
            restTimer.Enabled = false;
        }

        private void setCurrentRound()
        {
            string t = roundBox.SelectedItem.ToString();

            int runda = int.Parse(t);
            currentRound = runda;
        }


        private void beepSound()
        {
            SoundPlayer beepPlay = new SoundPlayer(@"e:\Sounds\beep.wav");
            beepPlay.Play();


        }

        private void roundSound()
        {
            SoundPlayer roundPlay = new SoundPlayer(@"e:\Sounds\Gong.wav");
            roundPlay.Play();
        }

        private void monsterSound()
        {
            SoundPlayer monsterPlay = new SoundPlayer(@"E:\Sounds\monster.wav");
            monsterPlay.Play();
        }

        private void applauseSound()
        {
            SoundPlayer applausePlay = new SoundPlayer(@"E:\Sounds\applause.wav");
            applausePlay.Play();
        }
        private void warningSound()
        {
            SoundPlayer warningPlay = new SoundPlayer(@"e:\Sounds\emergency.wav");
            warningPlay.Play();
        }

        private int GetRound()
        {
            return int.Parse(roundBox.SelectedItem.ToString());
        }

        private string GetRoundText()
        {
            return $" seria {(GetRound() - currentRound + 1)} z {GetRound()}";
        }

        private void ResetInterface()
        {
            //todo: add code to clean everyting n the screen afte the workout
            roundDisplayLabelxx.Text = string.Empty;
        }
        #endregion

        private async void startButton_Click(object sender, EventArgs e)
        {
            resetButton.Enabled = false;
            pauseButton.Enabled = false;

            setupTimers();
            setCurrentRound();

            roundDisplayLabelxx.Text = GetRoundText();
        }

        private void workTimer_Tick(object sender, EventArgs e)
        {
            resetButton.Enabled = true;
            pauseButton.Enabled = true;

            TimerLabel.BackColor = Color.Red;
            if (totalwSeconds > 0)
            {

                totalwSeconds--;
                int minutes = totalwSeconds / 60;
                int seconds = totalwSeconds - (minutes * 60);

                // TimerLabel.Text = String.Format("{0:D2} : {1:D2}", minutes, seconds);
                // TimerLabel.Text = string.Format("{0:00} : {1:00}", minutes, seconds);
                TimerLabel.Text = $"{minutes:00} : {seconds:00}";


                if (totalwSeconds <= 10)
                {
                    beepSound();
                }


            }
            else
            {
                monsterSound();
                workTimer.Stop();
                restTimer.Enabled = true;

                //todo: Check if it's the last round and do not start the restTimer
                if (currentRound > 1)
                {
                    //todo: clear the interface
                    //      play music
                    //      fuck


                }
                else
                {
                    restTimer.Enabled = false;
                    TimerLabel.BackColor = Color.DeepSkyBlue;
                    TimerLabel.Text = ("FUCK");
                    roundDisplayLabelxx.Text = ("<FUCK-MORE!>");
                    applauseSound();
                }
            }
        }

        private void restTimer_Tick(object sender, EventArgs e)
        {
            TimerLabel.BackColor = Color.YellowGreen;



            if (totalrSeconds > 0)
            {
                totalrSeconds--;
                int minutes = totalrSeconds / 60;
                int seconds = totalrSeconds - (minutes * 60);
                // TimerLabel.Text = String.Format("{0:D2} : {1:D2}", minutes, seconds);
                // TimerLabel.Text = string.Format("{0:00} : {1:00}", minutes, seconds);
                TimerLabel.Text = $"{minutes:00} : {seconds:00}";



                    if (totalrSeconds <= 10)
                {
                    beepSound();
                }
            }


            else
            {

                restTimer.Stop();

                currentRound--;
                if (currentRound > 0)
                {
                    setupTimers();

                    roundDisplayLabelxx.Text = GetRoundText();

                    workTimer.Start();
                }
            }
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
    }
}

