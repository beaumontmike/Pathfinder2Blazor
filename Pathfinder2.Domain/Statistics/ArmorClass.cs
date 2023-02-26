namespace Pathfinder2.Domain;

public class ArmorClass : Statistic
{
    protected override int? CalculateValue()
    {
        var cappedModifier = Math.Min(AbilityModifier, Player.EquippedArmor?.DexCap ?? 0);
        return 10 + cappedModifier + (Player.EquippedArmor?.ArmorBonus ?? 0) + Proficiency +
               GetNetBonuses();
    } 

    public ArmorClass(Player InPlayer) : base(InPlayer)
    {
    }
}