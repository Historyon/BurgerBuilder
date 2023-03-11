using Godot;

public partial class Main : Node
{
    private Jim _jim => GetNode<Jim>("Jim");
    private Marker2D _jimStartPosition => GetNode<Marker2D>("JimStartPosition");

    public override void _Ready()
    {
        _jim.Hide();
        var screenSize = GetViewport().GetVisibleRect().Size;
        _jimStartPosition.Position = new Vector2(screenSize.X / 2, screenSize.Y - 200);

        // TODO: Remove later when their is a button
        NewGame();
    }

    public void NewGame()
    {
        _jim.Start(_jimStartPosition.Position);
    }
}
