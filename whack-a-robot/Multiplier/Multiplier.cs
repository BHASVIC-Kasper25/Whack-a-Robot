using Godot;
using System;
using System.Threading.Tasks;

public partial class Multiplier : CharacterBody2D
{
	private AnimatedSprite2D _animatedSprite;
	
	private int multiplier=0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_animatedSprite=GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public int readWriteMultiplier
	{
		get { return multiplier; }
		set 
		{ 
			GD.Print(value);
			multiplier=value;
		}
	}
}
