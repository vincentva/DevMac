// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace MBMonoMac
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton LireButton { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField ValLuesLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ValLuesLabel != null) {
				ValLuesLabel.Dispose ();
				ValLuesLabel = null;
			}

			if (LireButton != null) {
				LireButton.Dispose ();
				LireButton = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
