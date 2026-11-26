using Godot;
using System;

public partial class HighScore : Control
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Checks if your new score is higher than highscore
		if(Global.Instance.score>Global.Instance.highScore)
		{
			//If it is higher highscore becomes your current score
			Global.Instance.highScore=Global.Instance.score;
		}
		//Outputs highscore in main
		GetNode<Label>("Label").Text="High Score: "+Global.Instance.highScore.ToString("D2");
		//Resets score to zero so it will start at zero at the start at every round
		Global.Instance.score=0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
