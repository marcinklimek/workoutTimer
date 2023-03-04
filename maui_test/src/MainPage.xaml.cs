namespace WorkoutTimer;
using System.Timers;

public partial class MainPage : ContentPage
{
    private static Timer _timer;
    private DateTime _startTime;

	public MainPage()
	{
		InitializeComponent();

        // Create a timer and set a two second interval.
        _timer = new System.Timers.Timer();
        _timer.Interval = 1000;

        // Hook up the Elapsed event for the timer. 
        _timer.Elapsed += OnTimedEvent;

        // Have the timer fire repeated events (true is the default)
        _timer.AutoReset = true;
	}

	private void OnCounterClicked(object sender, EventArgs e)
    {
        _startTime = DateTime.Now;
        _timer.Enabled = true;
	}

    private void UpdateTimer()
    {
        var delta = DateTime.Now - _startTime;
        TimeLabel.Text = delta.ToString(@"mm\:ss");
    }

    private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        if (MainThread.IsMainThread)
            UpdateTimer();
        else
            MainThread.BeginInvokeOnMainThread(UpdateTimer);


    }
}

