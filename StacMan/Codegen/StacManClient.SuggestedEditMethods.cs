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
    public partial class StacManClient : ISuggestedEditMethods
    {
        /// <summary>
        /// Stack Exchange API SuggestedEdits methods
        /// </summary>
        public ISuggestedEditMethods SuggestedEdits
        {
            get { return this; }
        }

        Task<StacManResponse<SuggestedEdit>> ISuggestedEditMethods.GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, SuggestedEdits.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate);

            var ub = new ApiUrlBuilder("/suggested-edits", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("order", order);

            return CreateApiTask<SuggestedEdit>(ub, filterObj);
        }

        Task<StacManResponse<SuggestedEdit>> ISuggestedEditMethods.GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, SuggestedEdits.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate);

            var ub = new ApiUrlBuilder(String.Format("/suggested-edits/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("order", order);

            return CreateApiTask<SuggestedEdit>(ub, filterObj);
        }
    }

    public interface ISuggestedEditMethods
    {
        /// <summary>
        /// Get all the suggested edits on the site. (API Method: "/suggested-edits")
        /// </summary>
        Task<StacManResponse<SuggestedEdit>> GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, SuggestedEdits.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, Order? order = null);

        /// <summary>
        /// Get the suggested edits identified by a set of ids. (API Method: "/suggested-edits/{ids}")
        /// </summary>
        Task<StacManResponse<SuggestedEdit>> GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, SuggestedEdits.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, Order? order = null);

    }
}

#pragma warning restore 1591
