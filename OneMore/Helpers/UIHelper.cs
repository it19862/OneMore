﻿//************************************************************************************************
// Copyright © 2016 Steven M Cohn.  Yada yada...
//************************************************************************************************

namespace River.OneMoreAddIn
{
	using System;
	using System.Windows.Forms;
	using One = Microsoft.Office.Interop.OneNote;


	public interface IOneMoreWindow : IDisposable
	{
	}


	/// <summary>
	/// Some helper functions for dealing with Windows Forms on High DPI systems.
	/// </summary>

	internal static class UIHelper
	{
		private static bool unprepared = true;


		/// <summary>
		/// Find the OneNote main window from the given window context.
		/// </summary>
		/// <param name="context">Window context; typically an IRibbonControl reference.</param>
		/// <returns>The window wrapper.</returns>
		/// <remarks>
		/// Call with
		/// <![CDATA[
		/// var owner = UIHelper.GetOwner((IRibbonControl)control.Context as Window);
		/// ]]>
		/// </remarks>

		public static Win32WindowHandle GetOwner (One.Window context)
		{
			return new Win32WindowHandle(Native.GetParent(Native.GetParent((IntPtr)context.WindowHandle)));
		}


		/// <summary>
		/// Initialize Windows Forms to scale appropriately on High DPI systems.
		/// </summary>

		public static void PrepareUI ()
		{
			/*

			High DPI support in Windows Forms
			https://docs.microsoft.com/en-us/dotnet/framework/winforms/high-dpi-support-in-windows-forms

			In addition, to configure high DPI support in your Windows Forms application,
			you must do the following:

			Declare compatibility with Windows 10. To do this, add the following to your
			manifest file:

			<compatibility xmlns="urn:schemas-microsoft.comn:compatibility.v1">
			  <application>
				<!-- Windows 10 compatibility -->
				<supportedOS Id="{8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a}" />
			  </application>
			</compatibility>

			Enable per-monitor DPI awareness in the app.config file. Windows Forms introduces
			a new <System.Windows.Forms.ApplicationConfigurationSection> element to support
			new features and customizations added starting with the .NET Framework 4.7. To take
			advantage of the new features that support high DPI, add the following to your
			application configuration file.

			<System.Windows.Forms.ApplicationConfigurationSection>
			  <add key="DpiAwareness" value="PerMonitorV2" />
			</System.Windows.Forms.ApplicationConfigurationSection>      


			Call the static EnableVisualStyles method. This should be the first method call
			in your application entry point. For example:

			static void Main()
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form2());   
			}

			*/

			if (unprepared)
			{
				Native.SetProcessDPIAware();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				unprepared = false;
			}
		}


		public static void SetForegroundWindow (Form form)
		{
			var location = form.Location;

			Native.SetForegroundWindow(form.Handle);
			form.BringToFront();
			form.TopMost = true;
			form.Activate();
			form.TopMost = false;

			form.Location = location;
			form.Focus();
		}


		/// <summary>
		/// Shows an informational message box with the given caption and ensures it appears
		/// on top of the main OneNote window
		/// </summary>
		/// <param name="window">The OneNote window, from ApplicationManager.Window</param>
		/// <param name="message">The caption message to display</param>
		public static void ShowMessage(IWin32Window window, string message)
		{
			MessageBox.Show(window, message, "OneMore",
				MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
				MessageBoxOptions.DefaultDesktopOnly);
		}


		public static void Shutdown ()
		{
			Application.Exit();
		}
	}
}
