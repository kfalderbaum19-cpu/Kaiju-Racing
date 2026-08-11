using Godot;

public partial class CarController : CharacterBody2D
{
	[Export] public float Speed = 600f;
	[Export] public float TurnSpeed = 3f;

	public override void _PhysicsProcess(double delta)
	{
		float dt = (float)delta;

		float forward = 0f;
		if (Input.IsKeyPressed(Key.W)) forward = 1f;
		if (Input.IsKeyPressed(Key.S)) forward = -1f;

		float turn = 0f;
		if (Input.IsKeyPressed(Key.D)) turn = 1f;
		if (Input.IsKeyPressed(Key.A)) turn = -1f;

		Rotation += turn * TurnSpeed * dt;
		Velocity = Vector2.Up.Rotated(Rotation) * forward * Speed;
		MoveAndSlide();
	}
}
