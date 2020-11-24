﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

using Azure.Core;
using Azure.Identity;

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;

namespace Microsoft.Azure.PowerShell.Authenticators
{
    public class ManagedServiceIdentityAuthenticator : DelegatingAuthenticator
    {
        public const string CommonAdTenant = "organizations",
            AppServiceManagedIdentityFlag = "AppServiceManagedIdentityFlag",
            DefaultMSILoginUri = "http://169.254.169.254/metadata/identity/oauth2/token",
            DefaultBackupMSILoginUri = "http://localhost:50342/oauth2/token";

        private static Regex SystemMsiNameRegex = new Regex(@"MSI@\d+");

        public override Task<IAccessToken> Authenticate(AuthenticationParameters parameters, CancellationToken cancellationToken)
        {
            var msiParameters = parameters as ManagedServiceIdentityParameters;

            var scopes = new[] { GetResourceId(msiParameters.ResourceId, msiParameters.Environment) };
            var requestContext = new TokenRequestContext(scopes);
            var userAccountId = SystemMsiNameRegex.IsMatch(msiParameters.Account.Id) ? null : msiParameters.Account.Id;
            ManagedIdentityCredential identityCredential = new ManagedIdentityCredential(userAccountId);
            return MsalAccessToken.GetAccessTokenAsync(identityCredential, requestContext, cancellationToken,
                msiParameters.TenantId, msiParameters.Account.Id);
        }

        public override bool CanAuthenticate(AuthenticationParameters parameters)
        {
            return (parameters as ManagedServiceIdentityParameters) != null;
        }

        private string GetResourceId(string resourceIdorEndpointName, IAzureEnvironment environment)
        {
            return environment.GetEndpoint(resourceIdorEndpointName) ?? resourceIdorEndpointName;
        }
    }
}
