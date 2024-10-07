using Godot;
using System;

public class MainMenu : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export] public eSceneNames mySceneName;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	private void _on_PlayButton_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.WorldSelect);
	}
}
