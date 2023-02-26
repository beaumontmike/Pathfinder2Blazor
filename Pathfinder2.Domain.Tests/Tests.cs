using System;
using Xunit;

namespace Pathfinder2.Domain.Tests
{
    public class Tests
    {
        [Fact]
        public void Statistic_Tests()
        {
            var sut = new Statistic { Ability = Ability.Strength, };

            var prof = sut.GetProficiency(new Player { Level = new Statistic { Base = 1 } });
            
            Assert.Equal(2, prof);
        }
    }
}