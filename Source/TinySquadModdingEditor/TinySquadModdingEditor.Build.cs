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
			"TinySquadModding"
		} );

		PrivateDependencyModuleNames.AddRange( new string[] {
			"UnrealEd",
			"Slate",
			"SlateCore"
		} );

		DynamicallyLoadedModuleNames.AddRange( new string[] { } );

	}

}
