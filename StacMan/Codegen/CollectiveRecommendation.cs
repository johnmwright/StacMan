// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan CollectiveRecommendation, corresponding to Stack Exchange API v2's collective_recommendation type
    /// http://api.stackexchange.com/docs/types/collective-recommendation
    /// </summary>
    public partial class CollectiveRecommendation : StacManType
    {
        /// <summary>
        /// collective
        /// </summary>
        [Field("collective")]
        public Collective Collective { get; internal set; }

        /// <summary>
        /// creation_date
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

    }
}
