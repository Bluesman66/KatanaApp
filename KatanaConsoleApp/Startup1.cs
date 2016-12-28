﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KatanaConsoleApp.Startup1))]

namespace KatanaConsoleApp
{
	public class Startup1
	{
		public void Configuration(IAppBuilder app)
		{
			app.Run(context =>
			{
				context.Response.ContentType = "text/html; charset=utf-8";
				return context.Response.WriteAsync("<h2>Привет мир!</h2>");
			});
		}
	}
}
