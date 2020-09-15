// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace PayRoll.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResources.Phone(),
                new IdentityResources.Address(),
                new IdentityResource("companyDetails",new string[]{ "employee_id"}),
                new IdentityResource("location",new string[]{ "location"}),
                new IdentityResource("custom","Custom Info",new string[]{"custom.email", "custom.phone","kasi" })
            };
        }


        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("PayRollApi", "Pay Roll Api")
                {
                    Scopes = new List<string>{"",""}

                }

            };

        }
    }
}
