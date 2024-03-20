namespace BeehiveManagementSystem;

static class HoneyVault
{
	public const float NECTAR_CONVERSION_RATIO = .19f;
	public const float LOW_LEVEL_WARNING = 10f;

	private static float honey = 25f;
	private static float nectar = 100f;

	public static string StatusReport
	{
		get
		{
			string status = $"{honey:0.0} units of honey\n" +
				$"{nectar:0.0} units of nectar";
			string warnings = "";
			if (honey < LOW_LEVEL_WARNING)
			{
				warnings += "\nLOW HONEY - ADD A HONEY MANUFACTURER";
			}
			if (nectar < LOW_LEVEL_WARNING)
			{
				warnings += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
			}
			return status + warnings;
		}
	}

	public static void CollectNectar(float amount)
	{
		if (amount > 0)
		{
			nectar += amount;
		}
	}

	public static void ConvertNectarToHoney(float amount)
	{
		if (amount > nectar)
		{
			nectar = 0;
			honey += nectar * NECTAR_CONVERSION_RATIO;
		}
		else
		{
			nectar -= amount;
			honey += amount * NECTAR_CONVERSION_RATIO;
		}
	}

	public static bool ConsumeHoney(float amount)
	{
		if (amount > honey)
		{
			return false;
		}

		honey -= amount;
		return true;
	}
}
