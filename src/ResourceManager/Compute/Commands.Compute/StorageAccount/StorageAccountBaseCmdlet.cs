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

using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Management.Storage;
using System;
using Microsoft.Azure.Management.Storage.Models;

namespace Microsoft.Azure.Commands.Compute
{
    public abstract class StorageAccountBaseCmdlet : AzurePSCmdlet
    {
        private StorageManagementClientWrapper storageClientWrapper;
        
        protected const string StorageAccountNounStr = "AzureStorageAccount";
        protected const string StorageAccountKeyNounStr = StorageAccountNounStr + "Key";

        protected const string StorageAccountNameAlias = "StorageAccountName";
        protected const string AccountNameAlias = "AccountName";

        protected const string StorageAccountTypeAlias = "StorageAccountType";
        protected const string AccountTypeAlias = "AccountType";

        protected struct AccountTypeString
        {
            internal const string StandardLRS = "Standard_LRS";
            internal const string StandardZRS = "Standard_ZRS";
            internal const string StandardGRS = "Standard_GRS";
            internal const string StandardRAGRS = "Standard_RAGRS";
            internal const string PremiumLRS = "Premium_LRS";
        }
        
        public IStorageManagementClient StorageClient
        {
            get
            {
                if (storageClientWrapper == null)
                {
                    storageClientWrapper = new StorageManagementClientWrapper(Profile.Context)
                    {
                        VerboseLogger = WriteVerboseWithTimestamp,
                        ErrorLogger = WriteErrorWithTimestamp
                    };
                }

                return storageClientWrapper.StorageManagementClient;
            }

            set { storageClientWrapper = new StorageManagementClientWrapper(value); }
        }

        public string SubscriptionId
        {
            get
            {
                return Profile.Context.Subscription.Id.ToString();
            }
        }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
        }

        protected static AccountType ParseAccountType(string accountType)
        {
            if ("Standard_LRS".Equals(accountType, StringComparison.OrdinalIgnoreCase))
            {
                return AccountType.StandardLRS;
            }
            if ("Standard_ZRS".Equals(accountType, StringComparison.OrdinalIgnoreCase))
            {
                return AccountType.StandardZRS;
            }
            if ("Standard_GRS".Equals(accountType, StringComparison.OrdinalIgnoreCase))
            {
                return AccountType.StandardGRS;
            }
            if ("Standard_RAGRS".Equals(accountType, StringComparison.OrdinalIgnoreCase))
            {
                return AccountType.StandardRAGRS;
            }
            if ("Premium_LRS".Equals(accountType, StringComparison.OrdinalIgnoreCase))
            {
                return AccountType.PremiumLRS;
            }
            throw new ArgumentOutOfRangeException("accountType");
        }
    }
}
