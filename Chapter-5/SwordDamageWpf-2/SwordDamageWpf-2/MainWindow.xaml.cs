using System.Windows;

namespace SwordDamageWpf_2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	Random random = new();
	SwordDamage swordDamage;

	public MainWindow()
	{
		InitializeComponent();
		swordDamage = new(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
		DisplayDamage();
	}

	public void RollDice()
	{
		swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
		DisplayDamage();
	}

	void DisplayDamage()
	{
		damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		RollDice();
	}

	private void Flaming_Checked(object sender, RoutedEventArgs e)
	{
		swordDamage.Flaming = true;
		DisplayDamage();
	}

	private void Flaming_Unchecked(object sender, RoutedEventArgs e)
	{
		swordDamage.Flaming = false;
		DisplayDamage();
	}

	private void Magic_Checked(object sender, RoutedEventArgs e)
	{
		swordDamage.Magic = true;
		DisplayDamage();
	}

	private void Magic_Unchecked(object sender, RoutedEventArgs e)
	{
		swordDamage.Magic = false;
		DisplayDamage();
	}
}
