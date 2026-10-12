using Godot;
using System;

public partial class Global : Node2D
{
	// Called when the node enters the scene tree for the first time.
	
	public static Global Instance {get; private set;}
	public Godot.Collections.Array<bool> xClear {get; set;} = [true, true, true];
	public Godot.Collections.Array<bool> yClear {get; set;} = [true, true, true];
	public int robotX {get; set;} =0;
	public int robotY {get; set;} =0;

	public override void _Ready()
	{
		Instance=this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
