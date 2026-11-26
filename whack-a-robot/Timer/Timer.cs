using Godot;
using System;

public partial class Timer : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	//Subroutine runs at the end of each second
	private void _onTimerTimeout(){
		//Decreases the value of _gameTime by 1 every second
		Global.Instance._gameTime--;
		//Creates two new varibles to store the values of minutes left and seconds left
		int m=(int)(Global.Instance._gameTime/60f);
		int s=Global.Instance._gameTime-m*60;
		//Outputs both minutes and seconds within the game scene as text
		GetNode<Label>("Label").Text="Timer: "+m.ToString("D2")+":"+s.ToString("D2");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Checks if _gameTime is equal to zero, so when the timer runs out there is a scene switch to main
		if(Global.Instance._gameTime==0)
		{
			GetTree().ChangeSceneToFile("res://Main Menu/main.tscn");
		}
	}
}
