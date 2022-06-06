// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan User, corresponding to Stack Exchange API v2's user type
    /// http://api.stackexchange.com/docs/types/user
    /// </summary>
    public partial class User : StacManType
    {
        /// <summary>
        /// about_me
        /// </summary>
        [Field("about_me")]
        public string AboutMe { get; internal set; }

        /// <summary>
        /// accept_rate
        /// </summary>
        [Field("accept_rate")]
        public int? AcceptRate { get; internal set; }

        /// <summary>
        /// account_id
        /// </summary>
        [Field("account_id")]
        public int AccountId { get; internal set; }

        /// <summary>
        /// age
        /// </summary>
        [Field("age")]
        public int? Age { get; internal set; }

        /// <summary>
        /// answer_count
        /// </summary>
        [Field("answer_count")]
        public int AnswerCount { get; internal set; }

        /// <summary>
        /// badge_counts
        /// </summary>
        [Field("badge_counts")]
        public BadgeCount BadgeCounts { get; internal set; }

        /// <summary>
        /// collectives -- introduced in API version 2.3
        /// </summary>
        [Field("collectives")]
        public CollectiveMembership[] Collectives { get; internal set; }

        /// <summary>
        /// creation_date
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        /// <summary>
        /// display_name
        /// </summary>
        [Field("display_name")]
        public string DisplayName { get; internal set; }

        /// <summary>
        /// down_vote_count
        /// </summary>
        [Field("down_vote_count")]
        public int DownVoteCount { get; internal set; }

        /// <summary>
        /// is_employee
        /// </summary>
        [Field("is_employee")]
        public bool IsEmployee { get; internal set; }

        /// <summary>
        /// last_access_date
        /// </summary>
        [Field("last_access_date")]
        public DateTime LastAccessDate { get; internal set; }

        /// <summary>
        /// last_modified_date
        /// </summary>
        [Field("last_modified_date")]
        public DateTime? LastModifiedDate { get; internal set; }

        /// <summary>
        /// link
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// location
        /// </summary>
        [Field("location")]
        public string Location { get; internal set; }

        /// <summary>
        /// profile_image
        /// </summary>
        [Field("profile_image")]
        public string ProfileImage { get; internal set; }

        /// <summary>
        /// question_count
        /// </summary>
        [Field("question_count")]
        public int QuestionCount { get; internal set; }

        /// <summary>
        /// reputation
        /// </summary>
        [Field("reputation")]
        public int Reputation { get; internal set; }

        /// <summary>
        /// reputation_change_day
        /// </summary>
        [Field("reputation_change_day")]
        public int ReputationChangeDay { get; internal set; }

        /// <summary>
        /// reputation_change_month
        /// </summary>
        [Field("reputation_change_month")]
        public int ReputationChangeMonth { get; internal set; }

        /// <summary>
        /// reputation_change_quarter
        /// </summary>
        [Field("reputation_change_quarter")]
        public int ReputationChangeQuarter { get; internal set; }

        /// <summary>
        /// reputation_change_week
        /// </summary>
        [Field("reputation_change_week")]
        public int ReputationChangeWeek { get; internal set; }

        /// <summary>
        /// reputation_change_year
        /// </summary>
        [Field("reputation_change_year")]
        public int ReputationChangeYear { get; internal set; }

        /// <summary>
        /// timed_penalty_date
        /// </summary>
        [Field("timed_penalty_date")]
        public DateTime? TimedPenaltyDate { get; internal set; }

        /// <summary>
        /// up_vote_count
        /// </summary>
        [Field("up_vote_count")]
        public int UpVoteCount { get; internal set; }

        /// <summary>
        /// user_id
        /// </summary>
        [Field("user_id")]
        public int UserId { get; internal set; }

        /// <summary>
        /// user_type
        /// </summary>
        [Field("user_type")]
        public Users.UserType UserType { get; internal set; }

        /// <summary>
        /// view_count
        /// </summary>
        [Field("view_count")]
        public int ViewCount { get; internal set; }

        /// <summary>
        /// website_url
        /// </summary>
        [Field("website_url")]
        public string WebsiteUrl { get; internal set; }

    }
}
