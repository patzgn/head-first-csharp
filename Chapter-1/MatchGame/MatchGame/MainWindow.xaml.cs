using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace MatchGame;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	DispatcherTimer timer = new DispatcherTimer();
	int tenthsOfSecondsElapsed;
	int matchesFound;

	int bestScore = int.MaxValue;

	private readonly int BoardSize = 16;

	public MainWindow()
	{
		InitializeComponent();

		timer.Interval = TimeSpan.FromSeconds(.1);
		timer.Tick += Timer_Tick;

		bestScoreTextBlock.Text = "Play";

		SetUpGame();
	}

	private void Timer_Tick(object? sender, EventArgs e)
	{
		tenthsOfSecondsElapsed++;
		timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");

		if (matchesFound == 8)
		{
			timer.Stop();
			timeTextBlock.Text = timeTextBlock.Text + " - Play again?";

			if (bestScore > tenthsOfSecondsElapsed)
			{
				bestScore = tenthsOfSecondsElapsed;
				bestScoreTextBlock.Text = "Best time: " + (bestScore / 10F).ToString("0.0s");
			}
		}
	}

	private void SetUpGame()
	{
		List<string> animalEmoji = GenerateAnimalEmojiList();

		Random random = new Random();

		foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
		{
			if (textBlock.Name != "timeTextBlock" && textBlock.Name != "bestScoreTextBlock")
			{
				textBlock.Visibility = Visibility.Visible;
				int index = random.Next(animalEmoji.Count);
				string nextEmoji = animalEmoji[index];
				textBlock.Text = nextEmoji;
				animalEmoji.RemoveAt(index);
			}
		}

		timer.Start();
		tenthsOfSecondsElapsed = 0;
		matchesFound = 0;
	}

	private List<string> GenerateAnimalEmojiList()
	{
		List<string> animals = new List<string>()
		{
			"🐙", "🐒",
			"🐡", "🦇",
			"🐘", "🦊",
			"🐳", "🐕",
			"🐪", "🦏",
			"🦕", "🦍",
			"🦘", "🐱",
			"🦔", "🦌",
		};

		List<string> result = new List<string>();

		Random random = new Random();

		for (int i = 0; i < BoardSize / 2; i++)
		{
			int index = random.Next(animals.Count);
			result.Add(animals[index]);
			result.Add(animals[index]);
			animals.RemoveAt(index);
		}

		return result;
	}

	TextBlock lastTextBlockClicked;
	bool findingMatch = false;

	private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
	{
		TextBlock textBlock = sender as TextBlock;
		if (findingMatch == false)
		{
			textBlock.Visibility = Visibility.Hidden;
			lastTextBlockClicked = textBlock;
			findingMatch = true;
		}
		else if (textBlock.Text == lastTextBlockClicked.Text)
		{
			matchesFound++;
			textBlock.Visibility = Visibility.Hidden;
			findingMatch = false;
		}
		else
		{
			lastTextBlockClicked.Visibility = Visibility.Visible;
			findingMatch = false;
		}
	}

	private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
	{
		if (matchesFound == 8)
		{
			SetUpGame();
		}
	}
}
