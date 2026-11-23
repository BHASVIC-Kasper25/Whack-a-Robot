using Godot;
using System;

public partial class Bomb : CharacterBody2D
{
	//Initialises values that are used later on
	private double _killTimer=1.5; 
	//Used to detect if the mouse is on top of
	private bool onBomb=false;

	private int thisHoleNumX=0;
	private int thisHoleNumY=0;
	
	public override void _Ready()
	{
		//thisHoleNumX/Y are use instead of robotX/Y because those two change each time a new object is spawned
		thisHoleNumX=Global.Instance.robotX;
		thisHoleNumY=Global.Instance.robotY;
	}
	
	
	public override void _Process(double delta)
	{
		//Checks if the bomb has been clicked and that the mouse is hovering over the robot
		if (Input.IsActionPressed("left_click") && onBomb==true)
		{
			bombClicked();
		}

		//Checks if the _killTimer is greater than zero		
		if(_killTimer>0)
		{
			//decreases _killTimer by delta, which is the time a single frame runs
			_killTimer-=delta;
		}
		else
		{
			//This subroutine is entered when _killTime equals zero
			clearValues();
		}
		
	}

	public void onBombHitboxMouseEntered()
	{
		//Subroutine played when the mouse is hovering over bomb
		onBomb=true;
		
	}

	public void onBombHitboxMouseExited()
	{
		//Subroutine played when the mouse is stops hovering over bomb
		onBomb=false;
	}

	public void bombClicked()
	{
		//This subroutine will decrease the in game timer by 5 seconds and resets the multiplier to 0
		Global.Instance._gameTime-=5;
		Global.Instance.multiplier=0;
		clearValues();
	}

	public void clearValues()
	{
		//Changes the value of both xClear and yClear to true to allow objects to spawn at those coordinates
		Global.Instance.xClear[thisHoleNumX]=true;
		Global.Instance.yClear[thisHoleNumY]=true;
		QueueFree();
	}

}
