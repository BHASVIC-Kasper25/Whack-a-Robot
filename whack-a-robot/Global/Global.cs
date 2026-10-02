using Godot;
using System;

public partial class Global : Node2D
{
	// Called when the node enters the scene tree for the first time.
	
	public static Global Instance {get; private set;}

	public override void _Ready()
	{
		Instance=this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
