using Godot;
using System;

public partial class introduction : Control
{
	private int visible_characters = 0;
	private RichTextLabel label;
	private AudioStreamPlayer audioPlayer;
	private AnimationPlayer animPlayer;
	
	public override void _Ready()
	{
		label = GetNode<RichTextLabel>("RichTextLabel");
		audioPlayer = GetNode<AudioStreamPlayer>("AudioStreamPlayer");
		animPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		
		animPlayer.Play("typewriter");
		audioPlayer.Play();
	}
	
	public void BackgroundClick(){
		GetTree().ChangeSceneToFile("res://scenes/main_menu.tscn");
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
