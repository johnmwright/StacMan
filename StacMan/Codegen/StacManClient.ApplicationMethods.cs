// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackExchange.StacMan
{
    public partial class StacManClient : IApplicationMethods
    {
        /// <summary>
        /// Stack Exchange API Applications methods
        /// </summary>
        public IApplicationMethods Applications
        {
            get { return this; }
        }

        Task<StacManResponse<AccessToken>> IApplicationMethods.Deauthenticate(IEnumerable<string> accessTokens, string filter = null, int? page = null, int? pagesize = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateEnumerable(accessTokens, "accessTokens");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder(String.Format("/apps/{0}/de-authenticate", String.Join(";", accessTokens)), useHttps: false);

            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);

            return CreateApiTask<AccessToken>(ub, filterObj);
        }
    }

    public interface IApplicationMethods
    {
        /// <summary>
        /// Allows an application to de-authorize itself for a set of users. (API Method: "/apps/{accessTokens}/de-authenticate")
        /// </summary>
        Task<StacManResponse<AccessToken>> Deauthenticate(IEnumerable<string> accessTokens, string filter = null, int? page = null, int? pagesize = null);

    }
}

#pragma warning restore 1591
