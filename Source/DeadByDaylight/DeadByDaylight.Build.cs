using UnrealBuildTool;

public class DeadByDaylight : ModuleRules {
	public DeadByDaylight(ReadOnlyTargetRules Target) : base(Target) {
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bLegacyPublicIncludePaths = false;
		ShadowVariableWarningLevel = WarningLevel.Warning;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"AnimationBudgetAllocator",
            "GameplayTags",
			"Customization",
			"DataTableUtilities",
            "DBDAnimationBudgetAllocator",
            "DBDSharedTypes",
            "UMG"
		});
	}
}
