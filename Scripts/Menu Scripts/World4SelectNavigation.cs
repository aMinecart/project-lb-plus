using Godot;
using System;

public class World4SelectNavigation : Node2D
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
		SceneManager.instance.ChangeScene(eSceneNames.WorldSelect);
	}


	private void _on_L1Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L1);
	}


	private void _on_L2Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L2);
	}


	private void _on_L3Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L3);
	}


	private void _on_L4Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L4);
	}


	private void _on_L5Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L5);
	}


	private void _on_L6Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L6);
	}


	private void _on_L7Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L7);
	}


	private void _on_L8Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L8);
	}


	private void _on_L9Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L9);
	}


	private void _on_L10Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L10);
	}


	private void _on_L11Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L11);
	}


	private void _on_L12Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L12);
	}


	private void _on_L13Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L13);
	}


	private void _on_L14Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L14);
	}


	private void _on_L15Button_button_up()
	{
		SceneManager.instance.ChangeScene(eSceneNames.World4L15);
	}

}



