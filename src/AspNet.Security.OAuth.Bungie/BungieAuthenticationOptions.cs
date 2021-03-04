/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AspNet.Security.OAuth.Bungie
{
    /// <summary>
    /// Defines a set of options used by <see cref="BungieAuthenticationHandler"/>.
    /// </summary>
    public class BungieAuthenticationOptions : OAuthOptions
    {
        public BungieAuthenticationOptions()
        {
            ClaimsIssuer = BungieAuthenticationDefaults.Issuer;

            AuthorizationEndpoint = BungieAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = BungieAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = BungieAuthenticationDefaults.UserInformationEndpoint;

            ClaimActions.MapJsonKey("X-API-Key", "APIKey");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
        }
    }
}
