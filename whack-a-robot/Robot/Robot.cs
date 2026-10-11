using Godot;
using System;

public partial class Robot : CharacterBody2D
{
	private bool onRobot=false;
	
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("left_click") && onRobot==true)
		{
			GD.Print("It works");
			QueueFree();
		}
		
	}

	public void onHitboxMouseEntered()
	{
		onRobot=true;
		
	}

	public void onHitboxMouseExited()
	{
		onRobot=false;
	}

}
