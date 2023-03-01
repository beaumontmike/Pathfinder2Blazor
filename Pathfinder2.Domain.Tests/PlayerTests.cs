namespace Pathfinder2.Domain.Tests;

public class PlayerTests
{
    [Theory]
    [InlineData(Ability.Strength, Training.Untrained, 1, 0, 0, 0)]
    [InlineData(Ability.Dexterity, Training.Trained, 1, 3, 1, 4)]
    [InlineData(Ability.Constitution, Training.Expert, 1, 5, 2, 7)]
    [InlineData(Ability.Intelligence, Training.Master, 1, 7, 3, 10)]
    [InlineData(Ability.Wisdom, Training.Legendary, 1, 9, 4, 13)]
    [InlineData(Ability.Charisma, Training.Untrained, 5, 0, 5, 5)]
    [InlineData(Ability.Charisma, Training.Master, 7, 13, 5, 18)]
    public void Statistic_Calculations(Ability Ability, Training Training, int Level, int Proficiency,
        int AbilityModifier, int Value)
    {
        var player = new Player
        {
            Level = Level, Strength = 10, Dexterity = 12, Constitution = 14, Intelligence = 16, Wisdom = 18,
            Charisma = 20
        };
        var sut = new Skill { Player = player, Ability = Ability, Training = Training };
    
        Assert.Equal(Proficiency, sut.Proficiency);
        Assert.Equal(AbilityModifier, sut.AbilityModifier);
        Assert.Equal(Value, sut.Value);
    }
    
    // [Theory]
    // [ClassData(typeof(PlayerData))]
    // public void CheckModifiers(Player Player, Results Results)
    // {
    //     Assert.Equal(Results.StrengthModifier, Player.GetAbilityModifier(Ability.Strength));
    //     Assert.Equal(Results.DexterityModifier, Player.GetAbilityModifier(Ability.Dexterity));
    //     Assert.Equal(Results.ConstitutionModifier, Player.GetAbilityModifier(Ability.Constitution));
    //     Assert.Equal(Results.IntelligenceModifier, Player.GetAbilityModifier(Ability.Intelligence));
    //     Assert.Equal(Results.WisdomModifier, Player.GetAbilityModifier(Ability.Wisdom));
    //     Assert.Equal(Results.CharismaModifier, Player.GetAbilityModifier(Ability.Charisma));
    // }
    //
    // [Theory]
    // [ClassData(typeof(PlayerData))]
    // public void CheckArmorClass(Player Player, Results Results)
    // {
    //     Assert.Equal(Results.ArmorClass_Proficiency, Player.ArmorClass.Proficiency);
    //     Assert.Equal(Results.ArmorClass_Value, Player.ArmorClass.Value);
    // }
}