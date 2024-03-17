namespace WeaponDamage_2;

internal class ArrowDamage : WeaponDamage
{
	public const decimal BASE_MULTIPLIER = 0.35M;
	public const decimal MAGIC_MULTIPLIER = 2.5M;
	public const decimal FLAME_DAMAGE = 1.25M;

	public ArrowDamage(int startingRoll) : base(startingRoll) { }

	protected override void CalculateDamage()
	{
		decimal baseDamage = Roll * BASE_MULTIPLIER;
		if (Magic) baseDamage *= MAGIC_MULTIPLIER;
		if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
		else Damage = (int)Math.Ceiling(baseDamage);
	}
}
