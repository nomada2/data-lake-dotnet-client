﻿using Microsoft.Azure.Management.DataLake.Store;
using MSADLS = Microsoft.Azure.Management.DataLake.Store;
using ADL = Microsoft.Azure.Management.DataLake;

namespace AdlClient.Rest
{
    public class StoreRestClients
    {
        public readonly ADL.Store.DataLakeStoreFileSystemManagementClient FileSystemClient;
        public readonly MSADLS.DataLakeStoreAccountManagementClient AccountClient;
        public readonly AdlClient.Models.StoreAccountRef Account;

        public StoreRestClients(AuthenticationBase authSession, AdlClient.Models.StoreAccountRef account)
        {
            this.Account = account;
            this.FileSystemClient = new DataLakeStoreFileSystemManagementClient(authSession.AdlCreds);
            this.AccountClient = new DataLakeStoreAccountManagementClient(authSession.ArmCreds);
            this.AccountClient.SubscriptionId = account.SubscriptionId;
        }
    }
}