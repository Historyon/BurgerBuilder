using Godot;

public partial class Jim : CharacterBody2D
{
    [Export]
    public int Speed { get; set; } = 400;

    public void GetInput()
    {
        Vector2 inputDirection = new Vector2(Input.GetAxis("MoveLeft", "MoveRight"), 0f);
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }

    public void Start(Vector2 position)
    {
        Position = position;
        Show();
    }
}
