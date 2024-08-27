namespace BaseballSimulator;

public class Pitcher
{
    private int _pitchNumber = 0;

    public Pitcher(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;

    private void BallInPlayEventHandler(object? sender, EventArgs e)
    {
        _pitchNumber++;
        if (e is BallEventArgs ballEventArgs)
        {
            if ((ballEventArgs.Distance < 95) && (ballEventArgs.Angle < 60))
            {
                Console.WriteLine($"Pitch #{_pitchNumber}: I caught the ball");
            }
            else
            {
                Console.WriteLine($"Pitch #{_pitchNumber}: I covered first base");
            }
        }
    }
}
