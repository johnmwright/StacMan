// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan Article, corresponding to Stack Exchange API v2's article type
    /// http://api.stackexchange.com/docs/types/article
    /// </summary>
    public partial class Article : StacManType
    {
        /// <summary>
        /// article_id -- introduced in API version 2.3
        /// </summary>
        [Field("article_id")]
        public int ArticleId { get; internal set; }

        /// <summary>
        /// article_type -- introduced in API version 2.3
        /// </summary>
        [Field("article_type")]
        public string ArticleType { get; internal set; }

        /// <summary>
        /// body -- introduced in API version 2.3
        /// </summary>
        [Field("body")]
        public string Body { get; internal set; }

        /// <summary>
        /// body_markdown -- introduced in API version 2.3
        /// </summary>
        [Field("body_markdown")]
        public string BodyMarkdown { get; internal set; }

        /// <summary>
        /// comment_count -- introduced in API version 2.3
        /// </summary>
        [Field("comment_count")]
        public int CommentCount { get; internal set; }

        /// <summary>
        /// comments -- introduced in API version 2.3
        /// </summary>
        [Field("comments")]
        public Comment[] Comments { get; internal set; }

        /// <summary>
        /// creation_date -- introduced in API version 2.3
        /// </summary>
        [Field("creation_date")]
        public DateTime CreationDate { get; internal set; }

        /// <summary>
        /// last_activity_date -- introduced in API version 2.3
        /// </summary>
        [Field("last_activity_date")]
        public DateTime LastActivityDate { get; internal set; }

        /// <summary>
        /// last_edit_date -- introduced in API version 2.3
        /// </summary>
        [Field("last_edit_date")]
        public DateTime? LastEditDate { get; internal set; }

        /// <summary>
        /// last_editor -- introduced in API version 2.3
        /// </summary>
        [Field("last_editor")]
        public ShallowUser LastEditor { get; internal set; }

        /// <summary>
        /// link -- introduced in API version 2.3
        /// </summary>
        [Field("link")]
        public string Link { get; internal set; }

        /// <summary>
        /// owner -- introduced in API version 2.3
        /// </summary>
        [Field("owner")]
        public ShallowUser Owner { get; internal set; }

        /// <summary>
        /// score -- introduced in API version 2.3
        /// </summary>
        [Field("score")]
        public int Score { get; internal set; }

        /// <summary>
        /// tags -- introduced in API version 2.3
        /// </summary>
        [Field("tags")]
        public string[] Tags { get; internal set; }

        /// <summary>
        /// title -- introduced in API version 2.3
        /// </summary>
        [Field("title")]
        public string Title { get; internal set; }

        /// <summary>
        /// view_count -- introduced in API version 2.3
        /// </summary>
        [Field("view_count")]
        public int ViewCount { get; internal set; }

    }
}
