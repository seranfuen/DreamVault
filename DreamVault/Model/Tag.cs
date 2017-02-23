using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DreamVault.Helper;
using System.Threading.Tasks;

namespace DreamVault.Model
{
    /// <summary>
    /// A particular tag describing the contents of the dream. A tag can have a number of subtags related to it
    /// </summary>
    public class Tag
    {
        #region ' Constructor '

        public Tag(string name)
        {
            Name = name;
            Subtags = new List<Subtag>();
        }

        #endregion

        #region ' Properties '

        public string Name
        {
            get;
            private set;
        }

        public List<Subtag> Subtags
        {
            get;
            private set;
        }

        #endregion

        #region ' Public Functions '

        public override string ToString()
        {
            return Name;
        }

        public void AddSubtag(string tagName)
        {
            if (!HasSubtag(tagName))
            {
                Subtags.Add(new Subtag(tagName));
            }
        }

        public bool HasSubtag(string tagName)
        {
            return !Subtags.IsNullOrEmpty() && Subtags.Any(subtag => subtag.Name.Equals(tagName, StringComparison.OrdinalIgnoreCase));
        }

        public string ToFullString()
        {
            var sb = new StringBuilder(Name);
            if (!Subtags.IsNullOrEmpty())
            {
                sb.Append(" (");
                sb.Append(string.Join(", ", Subtags.Select(subtag => subtag.Name)));
                sb.Append(")");
            }
            return sb.ToString();
        }

        #endregion
    }
}