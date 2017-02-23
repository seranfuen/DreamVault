using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamVault.Model
{
    public class Dream
    {
        #region ' Properties '

        public DateTime Date
        {
            get;
            set;
        }

        public DateTime DateAdded
        {
            get;
            set;
        }

        public string Summary
        {
            get;
            set;
        }

        public List<Tag> Tags
        {
            get;
            set;
        }

        #endregion
    }
}
