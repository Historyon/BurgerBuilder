using Godot;

public partial class Main : Node
{
    private Jim _jim => GetNode<Jim>("Jim");
    private Customer _customer => GetNode<Customer>("Customer");
    private Marker2D _jimStartPosition => GetNode<Marker2D>("JimStartPosition");

    public override void _Ready()
    {
        _jim.Hide();
        _customer.Hide();
        var screenSize = GetViewport().GetVisibleRect().Size;
        _jimStartPosition.Position = new Vector2(screenSize.X / 2, screenSize.Y - 100);
        _customer.Position = new(100f, _jimStartPosition.Position.Y);

        // TODO: Remove later when their is a button
        NewGame();
    }

    public void NewGame()
    {
        _jim.Start(_jimStartPosition.Position);
        _customer.Show();
    }
}
