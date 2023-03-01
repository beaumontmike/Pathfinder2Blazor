// using System.Collections;
//
// namespace Pathfinder2.Domain.Tests;
//
// public class PlayerData : IEnumerable<object[]>
// {
//     private struct PlayerDataContainer 
//     {
//         public Player Player { get; set; }
//         public Results Results { get; set; }
//     }
//     private List<PlayerDataContainer> Players { get; set; }
//     
//     public PlayerData()
//     {
//         Players = new List<PlayerDataContainer>
//         {
//             new () {
//                 Player = new Player
//                 {
//                     Level = 3,
//
//                     Strength = 14,
//                     Dexterity = 16,
//                     Constitution = 16,
//                     Intelligence = 12,
//                     Wisdom = 12,
//                     Charisma = 8,
//                     ArmorClass =
//                     {
//                         Training = Training.Untrained
//                     },
//                     EquippedArmor = new Armor() { ArmorBonus = 2, DexCap = 3 },
//                     EquippedShield = new Shield() { ArmorBonus = 1, Hardness = 5, HitPoints = 20 },
//                     EquippedShieldRaised = true
//                 },
//                 Results = new Results
//                 {
//                     StrengthModifier = 2,
//                     DexterityModifier = 3,
//                     ConstitutionModifier = 3,
//                     IntelligenceModifier = 1,
//                     WisdomModifier = 1,
//                     CharismaModifier = -1,
//
//                     ArmorClass_Proficiency = 0,
//                     ArmorClass_Value = 17,
//                 }
//             },
//             new () {
//                 Player = new Player
//                 {
//                     Level = 5,
//
//                     Strength = 14,
//                     Dexterity = 16,
//                     Constitution = 16,
//                     Intelligence = 12,
//                     Wisdom = 12,
//                     Charisma = 8,
//                     ArmorClass =
//                     {
//                         Training = Training.Trained
//                     },
//                     EquippedArmor = new Armor() { ArmorBonus = 2, DexCap = 3 },
//                     EquippedShield = new Shield() { ArmorBonus = 1, Hardness = 5, HitPoints = 10 },
//                     EquippedShieldRaised = false
//                 },
//                 Results = new Results
//                 {
//                     StrengthModifier = 2,
//                     DexterityModifier = 3,
//                     ConstitutionModifier = 3,
//                     IntelligenceModifier = 1,
//                     WisdomModifier = 1,
//                     CharismaModifier = -1,
//
//                     ArmorClass_Proficiency = 7,
//                     ArmorClass_Value = 22,
//                 }
//             }
//         };
//     }
//     
//     public IEnumerator<object[]> GetEnumerator()
//     {
//         var index = 0;
//
//         while (index < Players.Count)
//         {
//             yield return new object[] { Players[index].Player, Players[index].Results };
//             index++;
//         }
//     }
//
//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return GetEnumerator();
//     }
// }