using System.Media;

namespace WorkoutTimer;

public class Sounds
{
    private SoundPlayer? beepPlay;
    private SoundPlayer? roundPlay;
    private SoundPlayer? monsterPlay;
    
    private List<SoundPlayer?> applausePlay;

    private SoundPlayer? warningPlay;
    private SoundPlayer? finalPlay;

    private Random randObj;

    public Sounds()
    {
        randObj = new Random(42);

        beepPlay = new SoundPlayer(@"sounds\beep.wav");
        roundPlay = new SoundPlayer(@"sounds\Gong.wav");
        monsterPlay = new SoundPlayer(@"sounds\monster.wav");
        
        warningPlay = new SoundPlayer(@"sounds\emergency.wav");
        finalPlay = new SoundPlayer(@"sounds\final.wav");

        applausePlay = new List<SoundPlayer>();
        applausePlay.Add(new SoundPlayer(@"sounds\applause.wav") );
        applausePlay.Add(new SoundPlayer(@"sounds\applause.wav"));
        applausePlay.Add(new SoundPlayer(@"sounds\applause.wav"));
        applausePlay.Add(new SoundPlayer(@"sounds\applause.wav"));
        applausePlay.Add(new SoundPlayer(@"sounds\applause.wav"));
    }

    public void beep()
    {
        beepPlay?.Play();
    }

    public void round()
    {
        roundPlay?.Play();
    }

    public void monster()
    {
        monsterPlay?.Play();
    }

    public void applause()
    {
        int randomNumber = randObj.Next(applausePlay.Count); 
        applausePlay[randomNumber]?.Play();
    }

    public void warning()
    {
        warningPlay?.Play();
    }
    public void final()
    {
        finalPlay?.Play();
    }
}