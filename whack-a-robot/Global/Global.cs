using Godot;
using System;

public partial class Global : Node2D
{
	
	//Creates variables that need to be accessed in multiple scenes
	public Godot.Collections.Array<bool> xClear {get; set;} = [true, true, true];
	public Godot.Collections.Array<bool> yClear {get; set;} = [true, true, true];
	public int robotX {get; set;} =0;
	public int robotY {get; set;} =0;
	public int score {get; set;} =0;
	public int highScore {get; set;} =0;
	public int _gameTime {get; set;} =0;
	public int multiplier {get; set;} =0;

	//Creates a variable that allows the variables created in this file to be accessed in other files
	public static Global Instance {get; private set;}

	public override void _Ready()
	{
		Instance=this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Checks if the multiplier goes above 15 so no errors are created when accessing frames
		if(multiplier>15)
		{
			multiplier=15;
		}
	}
}
