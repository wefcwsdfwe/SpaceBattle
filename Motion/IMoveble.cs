namespace SpaceBattle
{   
    public interface IMovable 
    {
        Vector position { get; set; }
        Vector velocity { get; }
    }
}