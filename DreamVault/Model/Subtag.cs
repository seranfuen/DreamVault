using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamVault.Model
{
    public class Subtag
    {
        #region ' Constructor '

        public Subtag(string tagName)
        {
            Name = tagName;
        }

        #endregion

        #region ' Properties '

        public string Name
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

        #endregion
    }
}
