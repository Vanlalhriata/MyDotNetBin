using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class TestModel : ModelBase
    {
        #region StringA

        private string _StringA = String.Empty;

        /// <summary>
        /// Gets or sets the StringA property. This observable property 
        /// indicates a test string.
        /// </summary>
        public string StringA
        {
            get { return _StringA; }
            set
            {
                if (_StringA != value)
                {
                    _StringA = value;
                    RaisePropertyChanged();
                }
            }
        }

        #endregion
    }
}
