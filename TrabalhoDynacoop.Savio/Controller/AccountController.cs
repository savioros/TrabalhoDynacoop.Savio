﻿using Microsoft.Xrm.Tooling.Connector;
using System;
using TrabalhoDynacoop.Savio.Model;

namespace TrabalhoDynacoop.Savio.Controller
{
    internal class AccountController
    {
        public CrmServiceClient ServiceClient { get; set; }

        public Account Account { get; set; }

        public AccountController(CrmServiceClient serviceClient)
        {
            ServiceClient = serviceClient;
            this.Account = new Account(ServiceClient);
        }

        public Guid CreateAccount(string accountName, decimal marketCapitalization, int sharesOutstading, int companyRating, string creator)
        {
            return Account.CreateAccount(accountName, marketCapitalization, sharesOutstading, companyRating, creator);
        }

        public Guid CreateAccount(string accountName, decimal marketCapitalization, int sharesOutstading, int companyRating, string creator, Guid contactId)
        {
            return Account.CreateAccount(accountName, marketCapitalization, sharesOutstading, companyRating, creator, contactId);
        }
    }
}