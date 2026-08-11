using Godot;

public partial class TrackManager : Node2D
{
	private int lapCount = 0;

	private void _on_finish_line_trigger_body_entered(Node2D body)
	{
		if (body is CharacterBody2D)
		{
			lapCount++;
			GD.Print($"Lap: {lapCount}");
		}
	}
}
