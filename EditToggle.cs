using System;
using System.Collections.Generic;
using System.Linq;
using Godot;

public class EditToggle : Button
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    private float clock = 0.0f;
    public Knob activeKnob;

    private IEnumerable<Knob> linkList;
    public List<int> connections = new List<int>();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        linkList = GetParent().GetChildren().OfType<Knob>();
    }

    public override void _Process(float delta)
    {
        clock += delta;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Draw()
    {
        for (int i = 0; i < connections.Count - 1; i++)
        {
            Knob knob = GetParent().GetNode<Knob>(connections[i].ToString());
            Vector2 offset = knob.RectSize / 2;

            foreach (int linkID in knob.linkIDs)
		    {
                GD.Print("here");
                Button link = GetParent().GetNode<Button>(linkID.ToString());
                DrawLine(knob.RectGlobalPosition - this.RectGlobalPosition + offset, link.RectGlobalPosition - this.RectGlobalPosition + offset, Colors.Gray, 2);
		    }
        }
    }

    public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey inputEventKey &&
            inputEventKey.AsText() == "BackSpace" &&
            connections.Count > 0 &&
            clock > 1)
		{
            Knob old = GetParent().GetNode<Knob>(connections[connections.Count - 2].ToString());
            old.linkIDs.Remove(old.linkIDs.Count - 1);

            connections.RemoveAt(connections.Count - 1);
            clock = 0.0f;
		}
	}
}