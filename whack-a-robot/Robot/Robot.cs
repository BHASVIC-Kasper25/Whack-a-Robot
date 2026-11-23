using Godot;
using System;

public partial class Robot : CharacterBody2D
{
	//Initialises values that are used later on
	private double _killTimer=1.5; 
	//Used to detect if the mouse is on top of robot 
	private bool onRobot=false;

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
		//Checks if the robot has been clicked and that the mouse is hovering over the robot
		if (Input.IsActionPressed("left_click") && onRobot==true)
		{
			robotClicked();
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
			failClicked();
		}
		
	}

	public void onHitboxMouseEntered()
	{
		//Subroutine played when the mouse is hovering over robot
		onRobot=true;
		
	}

	public void onHitboxMouseExited()
	{
		//Subroutine played when the mouse is stops hovering over robot
		onRobot=false;
	}

	public void robotClicked()
	{
		//This subroutine will increase the score by 5 multiplied by the current multiplier plus 1.
		//The reason why it is done like this is because the variable multiplier is used for both frames, which uses base 0, and being used to multiply score
		Global.Instance.score=Global.Instance.score+(5*(Global.Instance.multiplier+1));
		Global.Instance.multiplier++;
		clearValues();
	}

	public void failClicked()
	{
		//Sets the multiplier to 0, when the player fails to click a robot in time
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
