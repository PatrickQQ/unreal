// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MeshPaint : ModuleRules
{
    public MeshPaint(TargetInfo Target)
    {
        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "AppFramework",
                "Core", 
                "CoreUObject",
                "DesktopPlatform",
                "Engine", 
                "InputCore",
                "RenderCore",
                "RHI",
                "ShaderCore",
                "Slate",
				"SlateCore",
                "EditorStyle",
                "UnrealEd",
                "RawMesh",
                "SourceControl",
            } 
        );

		PrivateIncludePathModuleNames.AddRange(
			new string[]
			{
				"AssetTools",
				"VREditor"
			} );

		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				"AssetTools",
				"VREditor"
			} );
    }
}
