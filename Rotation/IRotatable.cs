namespace SpaceBattle
{
    public interface IRotatable
    {
        double angleVelocty { get; }
        Angle Direction { get; set; }
    }
}