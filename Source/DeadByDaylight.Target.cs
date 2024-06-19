using UnrealBuildTool;

public class DeadByDaylightTarget : TargetRules {
	public DeadByDaylightTarget(TargetInfo Target) : base(Target) {
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange(new string[] {
			"DeadByDaylight",
			"DBDSharedTypes",
			"Customization",
			"DBDAnimationBudgetAllocator",
			"DataTableUtilities",
		});
	}
}
