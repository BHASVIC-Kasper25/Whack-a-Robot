using Godot;
using System;

public partial class Robot : CharacterBody2D
{
	public override void _Process(double delta)
	{
		
		
	}

	public void onHitboxInputEvent(CharacterBody2D body)
	{
		//if (Input.IsActionPressed("left_click"))
		//{
		//	GD.Print("It works");
		//	body.QueueFree();
		//}
	}

}
