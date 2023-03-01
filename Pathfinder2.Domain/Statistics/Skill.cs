namespace Pathfinder2.Domain;

public class Skill
{
    public string? Name { get; init; }
    public Ability Ability { get; init; }
    public Training Training { get; set; }
    public Player Player { get; set; } = new ();
    public int Proficiency => Training == Training.Untrained ? 0 : Training.GetModifier() + Player.Level;
    public int AbilityModifier => Player.GetAbilityModifier(Ability);
    public int? Value => CalculateValue();

    public List<Bonus> Bonuses { get; set; } = new ();
    public List<Penalty> Penalties { get; set; } = new ();

    // Overrideable Methods
    protected virtual int? CalculateValue()
    {
        return AbilityModifier + Proficiency;
    }

    protected virtual int GetNetBonuses()
    {
        return Bonuses.Sum(b => b.Value) + Penalties.Sum(p => p.Value);
    }
}