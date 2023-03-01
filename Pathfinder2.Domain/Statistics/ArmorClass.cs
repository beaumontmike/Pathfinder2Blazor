namespace Pathfinder2.Domain;

public class ArmorClass : Skill
{

    public ArmorClass()
    {
        Ability = Ability.Dexterity;
    }
    
    protected override int? CalculateValue()
    {
        var cappedModifier = Math.Min(AbilityModifier, Player.EquippedArmor?.DexCap ?? 0);
        var shieldValue = Player.EquippedShieldRaised ? Player.EquippedShield?.ArmorBonus ?? 0 : 0;
        return 10 + cappedModifier + shieldValue + (Player.EquippedArmor?.ArmorBonus ?? 0) + Proficiency +
               GetNetBonuses();
    }
}