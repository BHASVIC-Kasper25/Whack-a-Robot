using Godot;
using System;

public partial class Timer : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	private void _onTimerTimeout(){
		Global.Instance._gameTime--;
		int m=(int)(Global.Instance._gameTime/60f);
		int s=Global.Instance._gameTime-m*60;
		GetNode<Label>("Label").Text="Timer: "+m.ToString("D2")+":"+s.ToString("D2");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Global.Instance._gameTime==0)
		{
			GetTree().ChangeSceneToFile("res://Main Menu/main.tscn");
		}
	}

	public void test()
	{
		GD.Print("Test");
	}
}
