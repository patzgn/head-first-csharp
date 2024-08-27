namespace BaseballSimulator;

public class Fan
{
    private int _pitchNumber = 0;

    public Fan(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;

    private void BallInPlayEventHandler(object? sender, EventArgs e)
    {
        _pitchNumber++;
        if (e is BallEventArgs ballEventArgs)
        {
            if ((ballEventArgs.Distance > 400) && (ballEventArgs.Angle > 30))
            {
                Console.WriteLine($"Pitch #{_pitchNumber}: Home run! I'm going for the ball!");
            }
            else
            {
                Console.WriteLine($"Pitch #{_pitchNumber}: Woo-hoo! Yeah!");
            }
        }
    }
}
