using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace PushWoosh
{
	public enum PWSupportedOrientations {
		OrientationPortrait = 1 << 0,
		OrientationPortraitUpsideDown = 1 << 1,
		OrientationLandscapeLeft = 1 << 2,
		OrientationLandscapeRight = 1 << 3
	}

}

