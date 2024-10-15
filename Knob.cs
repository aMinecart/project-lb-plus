using System;
using System.Collections.Generic;
using Godot;

public class Knob : Button
{
	[Export] public int buttonID = 0;
	public List<int> linkIDs = new List<int>();
	
	private bool editMode = false;
	private bool isEditing = false;

	private EditToggle editToggle;
	public Line2D line;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Name = buttonID.ToString();
		
		editToggle = GetParent().GetNode<EditToggle>("Edit Toggle");
		line = GetNode<Line2D>("Line2D2");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
  	{
		UpdateEditing();
		UpdateEditStatus();

		foreach (int num in linkIDs)
		{
		}
		GD.Print(buttonID + " " + linkIDs.Count);
	}

	private void UpdateEditing()
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
	
	private void UpdateEditStatus()
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

	public override void _Pressed()
	{
		editToggle.activeKnob = this;
		editToggle.connections.Add(buttonID);

		if (editToggle.connections.Count > 1)
		{
			Knob knob = GetParent().GetNode<Knob>(editToggle.connections[editToggle.connections.Count - 2].ToString());
			knob.linkIDs.Add(buttonID);
		}
	}

    public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey inputEventKey)
		{
			if (editMode && isEditing)
			{
				this.Text = inputEventKey.AsText();
			}
		}
	}
}