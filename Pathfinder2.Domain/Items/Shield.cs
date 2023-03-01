namespace Pathfinder2.Domain;

public class Shield : Item
{
    public int ArmorBonus { get; set; } = 0;
    public int Hardness { get; set; } = 0;
    public int HitPoints { get; set; } = 0;
    
    public int BreakThreshold => HitPoints / 2;
}