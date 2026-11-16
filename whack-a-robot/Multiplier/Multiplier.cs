using Godot;
using System;

public partial class Multiplier : Node2D
{
	// Called when the node enters the scene tree for the first time.
	private int multiplier=1;
	public override void _Ready()
	{
		this.GetNode<AnimatedSprite2D>("multiplier").Frame=2;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
