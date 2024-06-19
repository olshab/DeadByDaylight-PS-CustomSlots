using UnrealBuildTool;

public class DeadByDaylightEditorTarget : TargetRules {
	public DeadByDaylightEditorTarget(TargetInfo Target) : base(Target) {
		Type = TargetType.Editor;
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
