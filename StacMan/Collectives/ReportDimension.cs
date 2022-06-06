using System;
using System.Collections.Generic;
using System.Text;

namespace StackExchange.StacMan.Collectives
{
    public enum ReportDimension
    {
        /// <summary>
        /// date 
        /// </summary>
        Date,

        /// <summary>
        /// page_views
        /// </summary>
        PageViews,

        /// <summary>
        /// unique_users 
        /// </summary>
        UniqueUsers,

        /// <summary>
        /// tag
        /// </summary>
        Tag,

        /// <summary>
        /// total_questions
        /// </summary>
        TotalQuestions,

        /// <summary>
        /// open_question
        /// </summary>
        OpenQuestion,

        /// <summary>
        /// answered_questions
        /// </summary>
        AnsweredQuestions,

        /// <summary>
        /// total_comments
        /// </summary>
        TotalComments,

        /// <summary>
        /// total_answers
        /// </summary>
        TotalAnswers,

        /// <summary>
        /// community_member_questions
        /// </summary>
        CommunityMemberQuestions,

        /// <summary>
        /// community_member_answers
        /// </summary>
        CommunityMemberAnswers,

        /// <summary>
        /// community_member_comments
        /// </summary>
        CommunityMemberComments,

        /// <summary>
        /// percent_response_24hrs
        /// </summary>
        PercentResponse24hrs,

        /// <summary>
        /// percent_answer_24hrs
        /// </summary>
        PercentAnswer24hrs
    }
}
