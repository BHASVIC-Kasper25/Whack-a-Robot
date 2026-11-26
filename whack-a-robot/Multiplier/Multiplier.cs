using Godot;
using System;
using System.Threading.Tasks;

public partial class Multiplier : CharacterBody2D
{
	private AnimatedSprite2D _animatedSprite;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Gives variable the properties of AnimatedSprite2D
		_animatedSprite=GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Sets the sprite to be the same value of the multiplier
		_animatedSprite.Frame=Global.Instance.multiplier;
		//GD.Print(Global.Instance.multiplier);
	}

}
