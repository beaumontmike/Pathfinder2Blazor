namespace Pathfinder2.Domain;

public class Player
{
    public int Level { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public ArmorClass ArmorClass { get; set; }
    public Armor? EquippedArmor { get; set; }

    public Player()
    {
        ArmorClass = new ArmorClass(this)
             { Name = nameof(ArmorClass), Ability = Ability.Dexterity, Training = Training.Untrained };   
    }
    
    public int GetAbilityScore(Ability Ability) => Ability switch
    {
        Ability.Strength => Strength,
        Ability.Dexterity => Dexterity,
        Ability.Constitution => Constitution,
        Ability.Intelligence => Intelligence,
        Ability.Wisdom => Wisdom,
        Ability.Charisma => Charisma,
        _ => 0
    };
}