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

        string Path_Source = Path.Combine(ModuleDirectory, "ThirdParty", "pugixml");

        if (UnrealTargetPlatform.Win64 == Target.Platform)
		{
            bUseRTTI = true;
           
            string Windows_Source = Path.Combine(Path_Source, "Win64");

            string Windows_Include = Path.Combine(Windows_Source, "include");
            PublicIncludePaths.Add(Windows_Include);

            string Windows_Libs = Path.Combine(Windows_Source, "lib");
            string[] List_Libs = Directory.GetFiles(Windows_Libs, "*.lib", SearchOption.TopDirectoryOnly);

            foreach (string File in List_Libs)
            {
                if (File.EndsWith(".lib"))
                {
                    PublicAdditionalLibraries.Add(File);
                }
            }
        }

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
