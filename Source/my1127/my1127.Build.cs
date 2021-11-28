// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class my1127 : ModuleRules
{
	public my1127(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
