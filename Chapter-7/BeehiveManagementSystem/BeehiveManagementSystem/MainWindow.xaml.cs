using System.Windows;
using System.Windows.Threading;

namespace BeehiveManagementSystem;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private Queen queen;
	private DispatcherTimer timer = new();

	public MainWindow()
	{
		InitializeComponent();
		queen = Resources["queen"] as Queen;
		timer.Tick += Timer_Tick;
		timer.Interval = TimeSpan.FromSeconds(1.5);
		timer.Start();
	}

	private void Timer_Tick(object sender, EventArgs e)
	{
		WorkShift_Click(this, new RoutedEventArgs());
	}

	private void AssignJob_Click(object sender, RoutedEventArgs e)
	{
		queen.AssignBee(jobSelector.Text);
	}

	private void WorkShift_Click(object sender, RoutedEventArgs e)
	{
		queen.WorkTheNextShift();
	}
}
