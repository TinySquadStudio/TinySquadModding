// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TinySquadModding 
	: ModuleRules 
{

	public TinySquadModding( ReadOnlyTargetRules Target ) 
		: base( Target ) 
	{

		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange( new string[] { } );

		PrivateIncludePaths.AddRange( new string[] { } );

		PublicDependencyModuleNames.AddRange( new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"UMG"
		} );

		PrivateDependencyModuleNames.AddRange( new string[] { "UnrealEd" } );

		DynamicallyLoadedModuleNames.AddRange( new string[] { } );

	}

}
