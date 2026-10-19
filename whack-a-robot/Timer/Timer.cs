using Godot;
using System;

public partial class Timer : Control
{
	private int _gameTime=10;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	private void _onTimerTimeout(){
		_gameTime--;
		int m=(int)(_gameTime/60f);
		int s=_gameTime-m*60;
		GetNode<Label>("Label").Text=m.ToString("D2")+":"+s.ToString("D2");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(_gameTime==0)
		{
			GetTree().ChangeSceneToFile("res://Main Menu/main.tscn");
		}
	}
}
