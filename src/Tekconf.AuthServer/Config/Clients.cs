using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tekconf;
using Thinktecture.IdentityServer.Core.Models;

namespace Tekconf.AuthServer.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
             {
                new Client 
                {
                     Enabled = true,
                     ClientId = "mvc",
                     ClientName = "Tekconf MVC Client (Hybrid Flow)",
                     Flow = Flows.Hybrid, 
                     RequireConsent = true,  
      
                    // redirect = URI of MVC app
                    RedirectUris = new List<string>
                    {
                        TekconfConstants.TekconfClient
                    }
                 }
             };

        }
    }
}