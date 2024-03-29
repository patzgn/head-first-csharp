﻿using System.Windows;

namespace SwordDamageWpf_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	Random random = new();
	SwordDamage swordDamage = new();

	public MainWindow()
	{
		InitializeComponent();
		swordDamage.SetMagic(false);
		swordDamage.SetFlaming(false);
		RollDice();
	}

	public void RollDice()
	{
		swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
		swordDamage.SetFlaming(flaming.IsChecked.Value);
		swordDamage.SetMagic(magic.IsChecked.Value);
		DisplayDamage();
	}

	void DisplayDamage()
	{
		damage.Text = "Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP";
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		RollDice();
	}

	private void Flaming_Checked(object sender, RoutedEventArgs e)
	{
		swordDamage.SetFlaming(true);
		DisplayDamage();
	}

	private void Flaming_Unchecked(object sender, RoutedEventArgs e)
	{
		swordDamage.SetFlaming(false);
		DisplayDamage();
	}

	private void Magic_Checked(object sender, RoutedEventArgs e)
	{
		swordDamage.SetMagic(true);
		DisplayDamage();
	}

	private void Magic_Unchecked(object sender, RoutedEventArgs e)
	{
		swordDamage.SetMagic(false);
		DisplayDamage();
	}
}
