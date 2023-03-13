using Godot;

public partial class Customer : Area2D
{
    public void OnBodyEntered(PhysicsBody2D body)
    {
        GD.Print(body.Name);
    }
}
