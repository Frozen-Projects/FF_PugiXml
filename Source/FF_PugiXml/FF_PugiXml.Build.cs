// Some copyright should be here...

using System;
using System.IO;
using UnrealBuildTool;

public class FF_PugiXml : ModuleRules
{
	public FF_PugiXml(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        CppCompileWarningSettings.UndefinedIdentifierWarningLevel = WarningLevel.Off;
        bEnableExceptions = true;

        if (UnrealTargetPlatform.Win64 == Target.Platform)
		{
            bUseRTTI = true;
        }

        PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "ThirdParty", "pugixml"));

        PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			});
			
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
			});
    }
}
