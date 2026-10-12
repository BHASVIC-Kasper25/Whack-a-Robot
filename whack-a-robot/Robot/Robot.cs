using Godot;
using System;

public partial class Robot : CharacterBody2D
{
	private double killTime=1.5;
	private double _killTimer=1.5; 
	
	private bool onRobot=false;
	private int thisHoleNumX=0;
	private int thisHoleNumY=0;
	
	public override void _Ready()
	{
		thisHoleNumX=Global.Instance.robotX;
		thisHoleNumY=Global.Instance.robotY;
	}
	
	
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("left_click") && onRobot==true)
		{
			Global.Instance.xClear[thisHoleNumX]=true;
			Global.Instance.yClear[thisHoleNumY]=true;
			QueueFree();
		}

		if(_killTimer>0)
		{
			_killTimer-=delta;
		}
		else
		{
			_killTimer=killTime;
			GD.Print("Self deletion");
			Global.Instance.xClear[thisHoleNumX]=true;
			Global.Instance.yClear[thisHoleNumY]=true;
			QueueFree();
		}
		
	}

	public void onHitboxMouseEntered()
	{
		onRobot=true;
		
	}

	public void onHitboxMouseExited()
	{
		onRobot=false;
	}

}
