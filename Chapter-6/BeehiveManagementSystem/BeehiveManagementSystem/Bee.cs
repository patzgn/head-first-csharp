namespace BeehiveManagementSystem;

abstract class Bee
{
	public abstract float CostPerShift { get; }
	public string Job { get; private set; }

	public Bee(string job)
	{
		Job = job;
	}

	public void WorkTheNextShift()
	{
		if (HoneyVault.ConsumeHoney(CostPerShift))
		{
			DoJob();
		}
	}

	protected abstract void DoJob();
}
