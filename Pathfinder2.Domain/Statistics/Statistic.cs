namespace Pathfinder2.Domain;

public class Statistic
{
    public string? Name { get; init; }
    public Ability Ability { get; init; }
    public Training Training { get; set; }
    public Player? Player { get; init; }
    public int Proficiency => Training.GetModifier() + Player?.Level ?? 0;
    public int AbilityModifier => (Player?.GetAbilityScore(Ability) ?? 0 - 10) / 2;
    public int? Value => CalculateValue();
    
    // Overrideable Methods
    protected virtual int? CalculateValue()
    {
        return AbilityModifier + Proficiency;
    }
}