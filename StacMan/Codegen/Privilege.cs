// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;

namespace StackExchange.StacMan
{
    public partial class Privilege : StacManType
    {
        internal Privilege(FilterBehavior filterBehavior, Filter filter) : base(filterBehavior, filter, "privilege") { }

        private string _Description;
        [Field("description")]
        public string Description
        {
            get { EnsureFilterContainsField("description"); return _Description; }
            internal set { _Description = value; }
        }

        private int _Reputation;
        [Field("reputation")]
        public int Reputation
        {
            get { EnsureFilterContainsField("reputation"); return _Reputation; }
            internal set { _Reputation = value; }
        }

        private string _ShortDescription;
        [Field("short_description")]
        public string ShortDescription
        {
            get { EnsureFilterContainsField("short_description"); return _ShortDescription; }
            internal set { _ShortDescription = value; }
        }
    }
}

#pragma warning restore 1591
