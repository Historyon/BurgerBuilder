using Godot;

public partial class Jim : CharacterBody2D
{
    [Export]
    public int Speed { get; set; } = 400;

    private Vector2 _screenSize;

    public override void _Ready()
    {
        _screenSize = GetViewportRect().Size;
    }

    public void GetInput()
    {
        Vector2 inputDirection = new Vector2(Input.GetAxis("MoveLeft", "MoveRight"), 0f);
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        var collision = MoveAndCollide(Velocity * (float)delta);
        Position = new(
            x: Mathf.Clamp(Position.X, 0, _screenSize.X),
            y: Position.Y 
        );
    }

    public void Start(Vector2 position)
    {
        Position = position;
        Show();
    }
}
