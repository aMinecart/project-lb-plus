using System;
using Godot;

public class Knob : Button
{
	private bool editMode = false;
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
	}

	public void UpdateEditing()
	{
		editMode = editToggle.Pressed;
	}

	public override void _Input(InputEvent @event)
    {
		if (editMode && @event is InputEventKey inputEventKey)
		{
			Text = @event.AsText();
		}
    }
}
