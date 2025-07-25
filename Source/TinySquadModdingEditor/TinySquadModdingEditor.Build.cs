// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TinySquadModdingEditor 
	: ModuleRules 
{

	public TinySquadModdingEditor( ReadOnlyTargetRules Target ) 
		: base( Target ) 
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange( new string[] { } );

		PrivateIncludePaths.AddRange( new string[] { } );

		PublicDependencyModuleNames.AddRange( new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"PropertyEditor",
			"ToolMenus",
			"UnrealEd",
			"ToolMenus"
		} );

		PrivateDependencyModuleNames.AddRange( new string[] {
			"EditorStyle",
			"LevelEditor",
			"PropertyEditor",
			"Slate",
			"SlateCore",
			"TinySquadModding"
		} );

		DynamicallyLoadedModuleNames.AddRange( new string[] { } );

	}

}
