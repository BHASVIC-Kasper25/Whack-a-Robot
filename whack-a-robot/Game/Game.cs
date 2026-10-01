using Godot;
using System;

public partial class Game : Node2D
{
	private PackedScene _robotScene=GD.Load<PackedScene>("res://Robot/robot.tscn");
	private RandomNumberGenerator _rng=new RandomNumberGenerator();
	private double spawnTime=1.0f;
	private double _spawnTimer=0.0f;

	Godot.Collections.Array<int> xCoo = [360, 570, 760];
	Godot.Collections.Array<int> yCoo = [150, 330, 515];

	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if(_spawnTimer>=0)
		{
			_spawnTimer-=(float)delta;
		}
		else
		{
			_spawnTimer=spawnTime;
			spawn();

		}
	}

	public void spawn()
	{
		GD.Print("Spawn entered");
	}
}
