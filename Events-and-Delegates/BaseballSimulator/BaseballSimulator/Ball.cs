namespace BaseballSimulator;

public class Ball
{
    public event EventHandler? BallInPlay;
    public void OnBallInPlay(BallEventArgs e) => BallInPlay?.Invoke(this, e);
}
