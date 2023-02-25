using UnrealBuildTool;

public class Coots_GamejamTarget : TargetRules
{
	public Coots_GamejamTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Coots_Gamejam");
	}
}
