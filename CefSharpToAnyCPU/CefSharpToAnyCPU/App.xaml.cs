﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Winform.CefBrowser;

namespace CefSharpToAnyCPU
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);
			CefContainer.ShutDown();
		}
	}
}