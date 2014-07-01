﻿using Nancy.Conventions;

namespace Nancy.Pile.Sample
{
    using Nancy;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            nancyConventions.StaticContentsConventions.AddStylesBundle("styles.css", !Bundle.IsDebugMode,
                new[]
                {
                    "css/pure.css",
                    "css/*.css"
                });

            nancyConventions.StaticContentsConventions.AddScriptsBundle("scripts.js", !Bundle.IsDebugMode,
                new[]
                {
                    "js/third-party/*.js",
                    "js/app.js",
                    "js/app/*.js"
                });
        }
    }
}