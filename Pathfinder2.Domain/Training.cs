using System.Diagnostics;

namespace Pathfinder2.Domain;

public enum Training
{
    Untrained, Trained, Expert, Master, Legendary
}

public static class TrainingExtensions
{
    public static int GetModifier(this Training Training)
    {
        return Training switch
        {
            Training.Untrained => 0,
            Training.Trained => 2,
            Training.Expert => 4,
            Training.Master => 6,
            Training.Legendary => 8,
            _ => 0
        };
    }
}