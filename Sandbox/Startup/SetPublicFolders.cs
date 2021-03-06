﻿namespace Sandbox.Startup
{
    using Simple.Web;

    public class SetPublicFolders : IStartupTask
    {
        public void Run(IConfiguration configuration, IWebEnvironment environment)
        {
            configuration.PublicFolders.Add("/Scripts");
            configuration.PublicFileMappings.Add("/about", "/about.html");
        }
    }
}