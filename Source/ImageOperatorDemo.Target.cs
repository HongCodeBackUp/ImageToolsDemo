// Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ImageOperatorDemoTarget : TargetRules
{
	public ImageOperatorDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "ImageOperatorDemo" } );
	}
}
