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
    public partial class StacManClient : IQuestionMethods
    {
        /// <summary>
        /// Stack Exchange API Questions methods
        /// </summary>
        public IQuestionMethods Questions
        {
            get { return this; }
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.AllSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/questions", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);
            ub.AddParameter("tagged", tagged);

            return CreateApiTask<Question>(ub, filterObj);
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(String.Format("/questions/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Question>(ub, filterObj);
        }

        Task<StacManResponse<Answer>> IQuestionMethods.GetAnswers(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Answers.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(String.Format("/questions/{0}/answers", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Answer>(ub, filterObj);
        }

        Task<StacManResponse<Comment>> IQuestionMethods.GetComments(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(String.Format("/questions/{0}/comments", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Comment>(ub, filterObj);
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetLinked(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.RelatedSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(String.Format("/questions/{0}/linked", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Question>(ub, filterObj);
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetRelated(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.RelatedSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(String.Format("/questions/{0}/related", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Question>(ub, filterObj);
        }

        Task<StacManResponse<QuestionTimeline>> IQuestionMethods.GetTimelines(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder(String.Format("/questions/{0}/timeline", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);

            return CreateApiTask<QuestionTimeline>(ub, filterObj);
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetFeatured(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/questions/unanswered", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);
            ub.AddParameter("tagged", tagged);

            return CreateApiTask<Question>(ub, filterObj);
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetUnanswered(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/questions/featured", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);
            ub.AddParameter("tagged", tagged);

            return CreateApiTask<Question>(ub, filterObj);
        }

        Task<StacManResponse<Question>> IQuestionMethods.GetWithNoAnswers(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/questions/no-answers", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);
            ub.AddParameter("tagged", tagged);

            return CreateApiTask<Question>(ub, filterObj);
        }
    }

    public interface IQuestionMethods
    {
        /// <summary>
        /// Get all questions on the site. (API Method: "/questions")
        /// </summary>
        Task<StacManResponse<Question>> GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.AllSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null);

        /// <summary>
        /// Get the questions identified by a set of ids. (API Method: "/questions/{ids}")
        /// </summary>
        Task<StacManResponse<Question>> GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get the answers to the questions identified by a set of ids. (API Method: "/questions/{ids}/answers")
        /// </summary>
        Task<StacManResponse<Answer>> GetAnswers(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Answers.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get the comments on the questions identified by a set of ids. (API Method: "/questions/{ids}/comments")
        /// </summary>
        Task<StacManResponse<Comment>> GetComments(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get the questions that link to the questions identified by a set of ids. (API Method: "/questions/{ids}/linked")
        /// </summary>
        Task<StacManResponse<Question>> GetLinked(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.RelatedSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get the questions that are related to the questions identified by a set of ids. (API Method: "/questions/{ids}/related")
        /// </summary>
        Task<StacManResponse<Question>> GetRelated(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.RelatedSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get the timelines of the questions identified by a set of ids. (API Method: "/questions/{ids}/timeline")
        /// </summary>
        Task<StacManResponse<QuestionTimeline>> GetTimelines(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null);

        /// <summary>
        /// Get all questions on the site with active bounties. (API Method: "/questions/unanswered")
        /// </summary>
        Task<StacManResponse<Question>> GetFeatured(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null);

        /// <summary>
        /// Get all questions the site considers unanswered. (API Method: "/questions/featured")
        /// </summary>
        Task<StacManResponse<Question>> GetUnanswered(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null);

        /// <summary>
        /// Get all questions on the site with no answers. (API Method: "/questions/no-answers")
        /// </summary>
        Task<StacManResponse<Question>> GetWithNoAnswers(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null);

    }
}

#pragma warning restore 1591
