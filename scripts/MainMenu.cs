using Godot;
using System;

public partial class MainMenu : Control
{
	
	public override void _Ready()
	{
		
	}
	
	private void PlayButtonPressed()
	{
		GetTree().ChangeSceneToFile("res://scenes/introduction.tscn");
	}
	
	private void ExitButtonPressed()
	{
		GetTree().Quit();
	}
}
