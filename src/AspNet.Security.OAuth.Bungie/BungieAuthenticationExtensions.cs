/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using AspNet.Security.OAuth.Bungie;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods to add Bungie authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class BungieAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="BungieAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Bungie authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddBungie([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddBungie(BungieAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="BungieAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Bungie authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddBungie(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<BungieAuthenticationOptions> configuration)
        {
            return builder.AddBungie(BungieAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="BungieAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Bungie authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Bungie options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddBungie(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [NotNull] Action<BungieAuthenticationOptions> configuration)
        {
            return builder.AddBungie(scheme, BungieAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="BungieAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables Bungie authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the Bungie options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddBungie(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme,
            [CanBeNull] string caption,
            [NotNull] Action<BungieAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<BungieAuthenticationOptions, BungieAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}
