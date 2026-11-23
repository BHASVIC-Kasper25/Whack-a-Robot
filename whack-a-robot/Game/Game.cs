using Godot;
using System;

public partial class Game : Node2D
{
	//Loads the scenes for robot and bomb so they can later be spawned
	private PackedScene _robotScene=GD.Load<PackedScene>("res://Robot/robot.tscn");
	private PackedScene _bombScene=GD.Load<PackedScene>("res://Bomb/bomb.tscn");
	
	//Loads the pauseMenu scene so it can be used
	private CanvasLayer pauseMenu;

	//Creates a random rumber generator
	private RandomNumberGenerator _rng=new RandomNumberGenerator();

	//Creates values that are used as a timer to spawn enemies
	private double spawnTime=1.0f;
	private double _spawnTimer=1.0f;

	//Creates two arrays that contains the x and y coordiantes of each hole
	Godot.Collections.Array<int> xCoo = [360, 570, 760];
	Godot.Collections.Array<int> yCoo = [150, 330, 515];

	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//Loads the pause menu into game and sets it to be invisible
		pauseMenu=GetNode<CanvasLayer>("CanvasLayer");
		pauseMenu.Visible=false;

		//Sets the _gameTime to one minute and resets the multiplier to 0
		Global.Instance._gameTime=60;
		Global.Instance.multiplier=0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Checks if the _spawnTimer is above 0 and if it is not an object will be spawned
		if(_spawnTimer>=0)
		{
			//decrease _spawnTimer by delta, converted to a float.
			//delta has the value of the time elapsed during a frame.
			_spawnTimer-=(float)delta;
		}
		else
		{
			//resets _spawnTimer and the enters the spawn() subroutine
			_spawnTimer=spawnTime;
			spawn();

		}

		if(Input.IsActionPressed("tab_pressed"))
		{
			//Enters the togglePause subroutine when the tab key is pressed
			togglePause();
		}

	}

	public void spawn()
	{
		//Loads the required logic to allow robot and bomb to be spawned
		CharacterBody2D robotTemp=_robotScene.Instantiate<CharacterBody2D>();
		CharacterBody2D bombTemp=_bombScene.Instantiate<CharacterBody2D>();
		
		int holeNumX=_rng.RandiRange(0,2);
		int holeNumY=_rng.RandiRange(0,2);
		int type=_rng.RandiRange(0,2);

		while(Global.Instance.xClear[holeNumX]==false && Global.Instance.yClear[holeNumY]==false)
		{
			holeNumX=_rng.RandiRange(0,2);
			holeNumY=_rng.RandiRange(0,2);
		}
		Global.Instance.xClear[holeNumX]=false;
		Global.Instance.yClear[holeNumY]=false;
		Global.Instance.robotX=holeNumX;
		Global.Instance.robotY=holeNumX;
		if(type==1)
		{
			bombTemp.Position=new Vector2(xCoo[holeNumX],yCoo[holeNumY]);
			AddChild(bombTemp);
		}
		else
		{
			robotTemp.Position=new Vector2(xCoo[holeNumX],yCoo[holeNumY]);
			AddChild(robotTemp);
		}
	}

	public void togglePause()
	{
		GetTree().Paused=!GetTree().Paused;
		pauseMenu.Visible=true;
	}

}
