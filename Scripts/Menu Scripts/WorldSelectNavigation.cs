using Godot;
using System;

public class WorldSelectNavigation : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	private void _on_BackButton_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.MainMenu);
	}


	private void _on_World1Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World1Select);
	}


	private void _on_World2Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World2Select);
	}


	private void _on_World3Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World3Select);
	}


	private void _on_World4Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4Select);
	}
}



