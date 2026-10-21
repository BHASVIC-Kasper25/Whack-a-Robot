using Godot;
using System;

public partial class HighScore : Control
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print(Global.Instance.highScore);
		if(Global.Instance.score>Global.Instance.highScore)
		{
			Global.Instance.highScore=Global.Instance.score;
		}
		GetNode<Label>("Label").Text="High Score: "+Global.Instance.highScore.ToString("D2");
		Global.Instance.score=0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
