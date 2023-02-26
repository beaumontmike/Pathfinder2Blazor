namespace Pathfinder2.Domain.Tests;

public class Tests
{
    [Theory]
    [InlineData(Ability.Strength, Training.Untrained, 1, 1, 0, 1)]
    [InlineData(Ability.Dexterity, Training.Trained, 1, 3, 1, 4)]
    [InlineData(Ability.Constitution, Training.Expert, 1, 5, 2, 7)]
    [InlineData(Ability.Intelligence, Training.Master, 1, 7, 3, 10)]
    [InlineData(Ability.Wisdom, Training.Legendary, 1, 9, 4, 13)]
    [InlineData(Ability.Charisma, Training.Untrained, 5, 5, 5, 10)]
    [InlineData(Ability.Charisma, Training.Master, 7, 13, 5, 18)]
    public void Statistic_Calculations(Ability Ability, Training Training, int Level, int Proficiency, int AbilityModifier, int Value)
    {
        var player = new Player { Level = Level, Strength = 10, Dexterity = 12, Constitution = 14, Intelligence = 16, Wisdom = 18, Charisma = 20};
        var sut = new Statistic(player) { Ability = Ability, Training = Training};

        Assert.Equal(Proficiency, sut.Proficiency);
        Assert.Equal(AbilityModifier, sut.AbilityModifier);
        Assert.Equal(Value, sut.Value);
    }

    [Theory]
    [InlineData(Training.Trained, 10, 10, 3, 3, 25)]
    [InlineData(Training.Trained, 10, 12, 3, 3, 26)]
    [InlineData(Training.Trained, 10, 14, 3, 3, 27)]
    [InlineData(Training.Trained, 10, 16, 3, 3, 28)]
    [InlineData(Training.Trained, 10, 18, 3, 3, 28)]
    [InlineData(Training.Trained, 10, 20, 3, 3, 28)]
    public void ArmorClass_Calculation(Training training, int level, int dexterity, int armorBonus, int dexCap, int result)
    {
        var player = new Player { Level = level, Strength = 10, Dexterity = dexterity, Constitution = 14, Intelligence = 16, Wisdom = 18, Charisma = 20,
            EquippedArmor = new Armor() { ArmorBonus = armorBonus, DexCap = dexCap },
        };

        player.ArmorClass.Training = training;
        
        Assert.Equal(result, player.ArmorClass.Value);
    }
}