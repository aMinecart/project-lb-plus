using Godot;
using System;
using System.Collections.Generic;

public enum eSceneNames {
	MainMenu = 10,
	WorldSelect = 20,
	
	World1Select = 110,
	World2Select = 120,
	World3Select = 130,
	World4Select = 140,
	
	World1L1 = 1010,
	World1L2 = 1020,
	World1L3 = 1030,
	World1L4 = 1040,
	World1L5 = 1050,
	World1L6 = 1060,
	World1L7 = 1070,
	World1L8 = 1080,
	World1L9 = 1090,
	World1L10 = 1100,
	World1L11 = 1110,
	World1L12 = 1120,
	World1L13 = 1130,
	World1L14 = 1140,
	World1L15 = 1150,
	
	World2L1 = 2010,
	World2L2 = 2020,
	World2L3 = 2030,
	World2L4 = 2040,
	World2L5 = 2050,
	World2L6 = 2060,
	World2L7 = 2070,
	World2L8 = 2080,
	World2L9 = 2090,
	World2L10 = 2100,
	World2L11 = 2110,
	World2L12 = 2120,
	World2L13 = 2130,
	World2L14 = 2140,
	World2L15 = 2150,
	
	World3L1 = 3010,
	World3L2 = 3020,
	World3L3 = 3030,
	World3L4 = 3040,
	World3L5 = 3050,
	World3L6 = 3060,
	World3L7 = 3070,
	World3L8 = 3080,
	World3L9 = 3090,
	World3L10 = 3100,
	World3L11 = 3110,
	World3L12 = 3120,
	World3L13 = 3130,
	World3L14 = 3140,
	World3L15 = 3150,
	
	World4L1 = 4010,
	World4L2 = 4020,
	World4L3 = 4030,
	World4L4 = 4040,
	World4L5 = 4050,
	World4L6 = 4060,
	World4L7 = 4070,
	World4L8 = 4080,
	World4L9 = 4090,
	World4L10 = 4100,
	World4L11 = 4110,
	World4L12 = 4120,
	World4L13 = 4130,
	World4L14 = 4140,
	World4L15 = 4150
	}

public partial class SceneManager : Node {

	public static SceneManager instance;

	public Dictionary<eSceneNames, SceneData> sceneDictionary = new Dictionary<eSceneNames, SceneData>() {
		{eSceneNames.MainMenu, new SceneData("res://Menus/MainMenu.tscn", "Main Menu") },
		{eSceneNames.WorldSelect, new SceneData("res://Menus/WorldSelect.tscn", "World Select") },
		
		{eSceneNames.World1Select, new SceneData("res://Menus/World1Select.tscn", "World 1 Select") },
		{eSceneNames.World2Select, new SceneData("res://Menus/World2Select.tscn", "World 2 Select") },
		{eSceneNames.World3Select, new SceneData("res://Menus/World3Select.tscn", "World 3 Select") },
		{eSceneNames.World4Select, new SceneData("res://Menus/World4Select.tscn", "World 4 Select") },
		
		{eSceneNames.World1L1, new SceneData("res://Worlds/World1/World1L1.tscn", "World 1-1") },
		{eSceneNames.World1L2, new SceneData("res://Worlds/World1/World1L2.tscn", "World 1-2") },
		{eSceneNames.World1L3, new SceneData("res://Worlds/World1/World1L3.tscn", "World 1-3") },
		{eSceneNames.World1L4, new SceneData("res://Worlds/World1/World1L4.tscn", "World 1-4") },
		{eSceneNames.World1L5, new SceneData("res://Worlds/World1/World1L5.tscn", "World 1-5") },
		{eSceneNames.World1L6, new SceneData("res://Worlds/World1/World1L6.tscn", "World 1-6") },
		{eSceneNames.World1L7, new SceneData("res://Worlds/World1/World1L7.tscn", "World 1-7") },
		{eSceneNames.World1L8, new SceneData("res://Worlds/World1/World1L8.tscn", "World 1-8") },
		{eSceneNames.World1L9, new SceneData("res://Worlds/World1/World1L9.tscn", "World 1-9") },
		{eSceneNames.World1L10, new SceneData("res://Worlds/World1/World1L10.tscn", "World 1-10") },
		{eSceneNames.World1L11, new SceneData("res://Worlds/World1/World1L11.tscn", "World 1-11") },
		{eSceneNames.World1L12, new SceneData("res://Worlds/World1/World1L12.tscn", "World 1-12") },
		{eSceneNames.World1L13, new SceneData("res://Worlds/World1/World1L13.tscn", "World 1-13") },
		{eSceneNames.World1L14, new SceneData("res://Worlds/World1/World1L14.tscn", "World 1-14") },
		{eSceneNames.World1L15, new SceneData("res://Worlds/World1/World1L15.tscn", "World 1-15") },
		
		{eSceneNames.World2L1, new SceneData("res://Worlds/World2/World2L1.tscn", "World 2-1") },
		{eSceneNames.World2L2, new SceneData("res://Worlds/World2/World2L2.tscn", "World 2-2") },
		{eSceneNames.World2L3, new SceneData("res://Worlds/World2/World2L3.tscn", "World 2-3") },
		{eSceneNames.World2L4, new SceneData("res://Worlds/World2/World2L4.tscn", "World 2-4") },
		{eSceneNames.World2L5, new SceneData("res://Worlds/World2/World2L5.tscn", "World 2-5") },
		{eSceneNames.World2L6, new SceneData("res://Worlds/World2/World2L6.tscn", "World 2-6") },
		{eSceneNames.World2L7, new SceneData("res://Worlds/World2/World2L7.tscn", "World 2-7") },
		{eSceneNames.World2L8, new SceneData("res://Worlds/World2/World2L8.tscn", "World 2-8") },
		{eSceneNames.World2L9, new SceneData("res://Worlds/World2/World2L9.tscn", "World 2-9") },
		{eSceneNames.World2L10, new SceneData("res://Worlds/World2/World2L10.tscn", "World 2-10") },
		{eSceneNames.World2L11, new SceneData("res://Worlds/World2/World2L11.tscn", "World 2-11") },
		{eSceneNames.World2L12, new SceneData("res://Worlds/World2/World2L12.tscn", "World 2-12") },
		{eSceneNames.World2L13, new SceneData("res://Worlds/World2/World2L13.tscn", "World 2-13") },
		{eSceneNames.World2L14, new SceneData("res://Worlds/World2/World2L14.tscn", "World 2-14") },
		{eSceneNames.World2L15, new SceneData("res://Worlds/World2/World2L15.tscn", "World 2-15") },
			
		{eSceneNames.World3L1, new SceneData("res://Worlds/World3/World3L1.tscn", "World 3-1") },
		{eSceneNames.World3L2, new SceneData("res://Worlds/World3/World3L2.tscn", "World 3-2") },
		{eSceneNames.World3L3, new SceneData("res://Worlds/World3/World3L3.tscn", "World 3-3") },
		{eSceneNames.World3L4, new SceneData("res://Worlds/World3/World3L4.tscn", "World 3-4") },
		{eSceneNames.World3L5, new SceneData("res://Worlds/World3/World3L5.tscn", "World 3-5") },
		{eSceneNames.World3L6, new SceneData("res://Worlds/World3/World3L6.tscn", "World 3-6") },
		{eSceneNames.World3L7, new SceneData("res://Worlds/World3/World3L7.tscn", "World 3-7") },
		{eSceneNames.World3L8, new SceneData("res://Worlds/World3/World3L8.tscn", "World 3-8") },
		{eSceneNames.World3L9, new SceneData("res://Worlds/World3/World3L9.tscn", "World 3-9") },
		{eSceneNames.World3L10, new SceneData("res://Worlds/World3/World3L10.tscn", "World 3-10") },
		{eSceneNames.World3L11, new SceneData("res://Worlds/World3/World3L11.tscn", "World 3-11") },
		{eSceneNames.World3L12, new SceneData("res://Worlds/World3/World3L12.tscn", "World 3-12") },
		{eSceneNames.World3L13, new SceneData("res://Worlds/World3/World3L13.tscn", "World 3-13") },
		{eSceneNames.World3L14, new SceneData("res://Worlds/World3/World3L14.tscn", "World 3-14") },
		{eSceneNames.World3L15, new SceneData("res://Worlds/World3/World3L15.tscn", "World 3-15") },
		
		{eSceneNames.World4L1, new SceneData("res://Worlds/World4/World4L1.tscn", "World 4-1") },
		{eSceneNames.World4L2, new SceneData("res://Worlds/World4/World4L2.tscn", "World 4-2") },
		{eSceneNames.World4L3, new SceneData("res://Worlds/World4/World4L3.tscn", "World 4-3") },
		{eSceneNames.World4L4, new SceneData("res://Worlds/World4/World4L4.tscn", "World 4-4") },
		{eSceneNames.World4L5, new SceneData("res://Worlds/World4/World4L5.tscn", "World 4-5") },
		{eSceneNames.World4L6, new SceneData("res://Worlds/World4/World4L6.tscn", "World 4-6") },
		{eSceneNames.World4L7, new SceneData("res://Worlds/World4/World4L7.tscn", "World 4-7") },
		{eSceneNames.World4L8, new SceneData("res://Worlds/World4/World4L8.tscn", "World 4-8") },
		{eSceneNames.World4L9, new SceneData("res://Worlds/World4/World4L9.tscn", "World 4-9") },
		{eSceneNames.World4L10, new SceneData("res://Worlds/World4/World4L10.tscn", "World 4-10") },
		{eSceneNames.World4L11, new SceneData("res://Worlds/World4/World4L11.tscn", "World 4-11") },
		{eSceneNames.World4L12, new SceneData("res://Worlds/World4/World4L12.tscn", "World 4-12") },
		{eSceneNames.World4L13, new SceneData("res://Worlds/World4/World4L13.tscn", "World 4-13") },
		{eSceneNames.World4L14, new SceneData("res://Worlds/World4/World4L14.tscn", "World 4-14") },
		{eSceneNames.World4L15, new SceneData("res://Worlds/World4/World4L15.tscn", "World 4-15") }
	};

	public override void _Ready() {
		instance = this;
	}

	public void ChangeScene(eSceneNames mySceneName) {
		string myPath = sceneDictionary[mySceneName].path;
		GetTree().ChangeScene(myPath);
	}

}
