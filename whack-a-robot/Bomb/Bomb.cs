using Godot;
using System;

public partial class Bomb : CharacterBody2D
{
	private double killTime=1.5;
	private double _killTimer=1.5; 
	
	private bool onBomb=false;
	private int thisHoleNumX=0;
	private int thisHoleNumY=0;
	
	public override void _Ready()
	{
		thisHoleNumX=Global.Instance.robotX;
		thisHoleNumY=Global.Instance.robotY;
	}
	
	
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("left_click") && onBomb==true)
		{
			Global.Instance._gameTime-=5;
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
			Global.Instance.xClear[thisHoleNumX]=true;
			Global.Instance.yClear[thisHoleNumY]=true;
			QueueFree();
		}
		
	}

	public void onBombHitboxMouseEntered()
	{
		onBomb=true;
		
	}

	public void onBombHitboxMouseExited()
	{
		onBomb=false;
	}

}
