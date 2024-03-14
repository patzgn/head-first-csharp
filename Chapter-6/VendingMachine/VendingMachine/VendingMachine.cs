﻿namespace VendingMachine;

internal class VendingMachine
{
	public virtual string Item { get; }

	protected virtual bool CheckAmount(decimal money)
	{
		return false;
	}

	public string Dispense(decimal money)
	{
		if (CheckAmount(money)) return Item;
		else return "Please enter the right amount";
	}
}
