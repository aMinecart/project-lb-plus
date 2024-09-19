using System;
using System.Collections.Generic;
using Godot;

public class Knob : Button
{
	[Export] private List<Button> linkList = new List<Button>();
	
	private bool editMode = false;
	private bool isEditing = false;
	private Button editToggle;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		editToggle = GetParent().GetNode<Button>("Edit Toggle");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
  	{
		UpdateEditing();
		UpdateEditStatus();
	}

	public void UpdateEditing()
	{
		editMode = editToggle.Pressed;
		if(editMode)
		{
			this.ToggleMode = true;
		}
		else
		{
			this.Pressed = false;
			this.ToggleMode = false;
		}
	}
	
	public void UpdateEditStatus()
	{
		isEditing = editMode && this.Pressed;
		if(editMode && this.Pressed)
		{
			isEditing = true;
		}
		else
		{
			isEditing = false;
		}
		
	}

	public override void _Input(InputEvent @event)
	{
		if (editMode && @event is InputEventKey inputEventKey && isEditing)
		{
			Text = @event.AsText();
		}
	}
}
