﻿// ******************************* Module Header *******************************
// Module Name: Program.cs
// Project:     StakeMaster
// Copyright (c) Michael Goldfinger.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// *****************************************************************************

namespace StakeMaster
{
	using System;
	using System.IO;
	using System.Reflection;
	using System.Threading.Tasks;
	using BusinessLogic;
	using Microsoft.Extensions.Configuration;
	using Serilog;

	internal class Program
	{
		private static IConfiguration Configuration { get; } = InitializeAppSettings();

		private static void Main(string[] args)
		{
			try
			{
				InitializeAppSettings();
				InitializeLogging();
				Log.Verbose("Command line arguments: {@args}", args);
				Log.Debug("Parse command line arguments...");
				Settings settings = SettingsHelper.Read(args);
				//TODO: Calculate Transaction Size
				//TODO: Move Inputs to Collection Address
				//TODO: Move Dust from Staking Address
				//TODO: Compress Collect Address
				//TODO: Generate new Staking Input
				Log.Verbose("Settings: {@settings}", settings);
			}
			catch (SettingsArgumentInvalidException e)
			{
				Log.Verbose(e, "Error while reading the command line arguments.");
				SettingsHelper.DisplayHelp(e.Message);
			}
			catch (Exception e)
			{
				Log.Fatal(e, "An unexpected error occured. The application will be terminated.");
			}
			finally
			{
				Log.CloseAndFlush();
			}
		}

		private static IConfiguration InitializeAppSettings()
		{
			IConfigurationBuilder builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", false, false);

			return builder.Build();
		}

		private static void InitializeLogging()
		{
			Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(Configuration).CreateLogger();
		}
	}
}
