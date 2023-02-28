using System.Collections;

namespace Pathfinder2.Domain.Tests;

public class PlayerData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] 
        {
            new Player
            {
                Level = 1,
                
                Strength = 10,
                Dexterity = 12,
                Constitution = 14,
                Intelligence = 16,
                Wisdom = 18,
                Charisma = 20,
                ArmorClass = new ArmorClass() { Name = "ArmorClass", Training = Training.Trained } 
            },
            
            // Expected Modifiers
            (
                StrengthMod: 0, 
                DexterityMod: 1, 
                ConstitutionMod: 2,
                IntelligenceMod: 3,
                WisdomMod: 4,
                Charisma: 5
            ),
            
            // Expected Armor Class
            (Proficiency: 1, AbilityBonus: 1, Value: 13)
            
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}