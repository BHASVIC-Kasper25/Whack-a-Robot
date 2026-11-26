using Godot;
using System;

public partial class PauseMenu : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Allows the code and scene to be interactable even when the game is paused
		ProcessMode = Node.ProcessModeEnum.Always;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	//Occurs when the resume button is pressed
	public void onResumePressed()
	{
		//Unpauses the game
		GetTree().Paused=!GetTree().Paused;
		//Makes the pause menu invisible
		Visible=false;
	}
}
