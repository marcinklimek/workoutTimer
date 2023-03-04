namespace WorkoutTimer;

public class WorkoutManager
{
    public int WorkSeconds { get; private set; }
    public int RestSeconds { get; private set; }
    public int Rounds { get; private set; }

    private int currentWorkSeconds;
    private int currentRestSeconds;
    public int CurrentRound { get; private set; }


    private int workSecondsHalf;
    private int restSecondsHalf;

    private System.Timers.Timer workTimer;
    private System.Timers.Timer restTimer;

    public class SecondsEventArgs : EventArgs
    {
        public SecondsEventArgs(int totalSeconds)
        {
            Seconds = totalSeconds;
        }

        public int Seconds { get; set; }
    }

    public event EventHandler<EventArgs> OnHalfTime;
    public event EventHandler<EventArgs> OnLastTenSeconds;
    public event EventHandler<SecondsEventArgs> OnWorkTimerTick;
    public event EventHandler<SecondsEventArgs> OnRestTimerTick;
    public event EventHandler<EventArgs> OnLastRound;
    public event EventHandler<EventArgs> OnNextRound;

    public event EventHandler<EventArgs> OnStart;
    public event EventHandler<EventArgs> OnFinish;

    public event EventHandler<EventArgs> OnRestStart;

    public WorkoutManager()
    {
        workTimer = new System.Timers.Timer(500);
        restTimer = new System.Timers.Timer(500);

        workTimer.Elapsed += workTimer_Tick;
        workTimer.AutoReset = true;

        restTimer.Elapsed += restTimer_Tick;
        restTimer.AutoReset = true;
    }


    public void SetupWorkout(int workoutSeconds, int restSeconds, int numRounds)
    {
        WorkSeconds = workoutSeconds;
        currentWorkSeconds = workoutSeconds;
        workSecondsHalf = currentWorkSeconds / 2;

        RestSeconds = restSeconds;
        currentRestSeconds = restSeconds;
        restSecondsHalf = currentRestSeconds / 2;

        Rounds = numRounds;
        CurrentRound = Rounds;
    }

    private void workTimer_Tick(object sender, EventArgs e)
    {
        if (currentWorkSeconds > 0)
        {
            currentWorkSeconds--;

            OnWorkTimerTick(this, new SecondsEventArgs(currentWorkSeconds));

            if (currentWorkSeconds == workSecondsHalf)
                OnHalfTime(this, EventArgs.Empty);

            if (currentWorkSeconds <= 10)
                OnLastTenSeconds(this, EventArgs.Empty);
        }
        else
        {
            if (CurrentRound == 1) // ostatnia
            {
                OnFinish(this, EventArgs.Empty);

                restTimer.Enabled = false;
                workTimer.Enabled = false;
                restTimer.Stop();
                workTimer.Stop();

            }
            else
            {
                workTimer.Stop();
                restTimer.Start();
                restTimer.Enabled = true;

                OnRestStart(this, EventArgs.Empty);
            }
        }
    }

    private void restTimer_Tick(object sender, EventArgs e)
    {
        if (currentRestSeconds > 0)
        {
            currentRestSeconds--;
            OnRestTimerTick(this, new SecondsEventArgs(currentRestSeconds));

            if (currentRestSeconds <= 10)
            {
                OnLastTenSeconds(this, EventArgs.Empty);
            }

            if (currentRestSeconds == restSecondsHalf)
            {
                OnHalfTime(this, EventArgs.Empty);
            }
        }
        else
        {
            restTimer.Stop();

            CurrentRound--;

            if (CurrentRound > 0)
            {
                currentWorkSeconds = WorkSeconds;
                currentRestSeconds = RestSeconds;

                workTimer.Enabled = true;
                restTimer.Enabled = false;

                workTimer.Start();
                    

                if (CurrentRound == 1) // przedostatnia
                    OnLastRound(this, EventArgs.Empty);
                else
                    OnNextRound(this, EventArgs.Empty);

            }
        }
    }

    public void Start()
    {
        workTimer.Start();
        restTimer.Stop();

        OnStart(this, EventArgs.Empty);
    }

    public void Stop()
    {
        workTimer.Stop();
        restTimer.Stop();
    }

    public void Pause()
    {
        Stop();
    }

    public void Reset()
    {
        Stop();
    }
}