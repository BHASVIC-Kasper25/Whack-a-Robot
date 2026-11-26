using Godot;
using System;

public partial class Main : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	//Played when the start button is pressed and changes the scene to the game
	public void onStartPressed()
	{
		//Changes the scene to Game
		GetTree().ChangeSceneToFile("res://Game/game.tscn");
	}

	//Played when the quit button is pressed and closes the game
	public void onQuitPressed()
	{
		//Quits the game
		GetTree().Quit();
	}
}
