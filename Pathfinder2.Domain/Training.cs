using System.Diagnostics;

namespace Pathfinder2.Domain
{
    public enum Training
    {
        Untrained, Trained, Expert, Master, Legendary
    }

    public static class TrainingExtensions
    {
        public static int GetModifier(this Training Training, Statistic Level)
        {
            return Training switch
            {
                Training.Untrained => 0,
                Training.Trained => 2 + Level.Value,
                Training.Expert => 4 + Level.Value,
                Training.Master => 6 + Level.Value,
                Training.Legendary => 8 + Level.Value,
                _ => 0
            };
        }
    }
}