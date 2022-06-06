// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan Post, corresponding to Stack Exchange API v2's post type
    /// http://api.stackexchange.com/docs/types/post
    /// </summary>
    public partial class Post : StacManType
    {
        /// <summary>
        /// body
        /// </summary>
        [Field("body")]
        public string Body { get; internal set; }

        /// <summary>
        /// collectives -- introduced in API version 2.3
        /// </summary>
        [Field("collectives")]
        public Collective[] Collectives { get; internal set; }

        /// <summary>
        /// comments
        /// </summary>
        [Field("comments")]
        public Comment[] Comments { get; internal set; }

        /// <summary>
        /// creation_date
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        /// <summary>
        /// down_vote_count
        /// </summary>
        [Field("down_vote_count")]
        public int DownVoteCount { get; internal set; }

        /// <summary>
        /// last_activity_date
        /// </summary>
        [Field("last_activity_date")]
        public DateTime LastActivityDate { get; internal set; }

        /// <summary>
        /// last_edit_date
        /// </summary>
        [Field("last_edit_date")]
        public DateTime? LastEditDate { get; internal set; }

        /// <summary>
        /// link -- introduced in API version 2.1
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// owner
        /// </summary>
        [Field("owner")]
        public ShallowUser Owner { get; internal set; }

        /// <summary>
        /// post_id
        /// </summary>
        [Field("post_id")]
        public int PostId { get; internal set; }

        /// <summary>
        /// post_type
        /// </summary>
        [Field("post_type")]
        public Posts.PostType PostType { get; internal set; }

        /// <summary>
        /// posted_by_collectives -- introduced in API version 2.3
        /// </summary>
        [Field("posted_by_collectives")]
        public Collective[] PostedByCollectives { get; internal set; }

        /// <summary>
        /// score
        /// </summary>
        [Field("score")]
        public int Score { get; internal set; }

        /// <summary>
        /// up_vote_count
        /// </summary>
        [Field("up_vote_count")]
        public int UpVoteCount { get; internal set; }

    }
}
