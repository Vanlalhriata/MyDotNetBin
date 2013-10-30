using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.Models
{
    /// <summary>
    /// A base class for Models that implements INotifyPropertyChanged
    /// </summary>
    public abstract class ModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">The name of the property that changed. Pass empty or null to raise for all properties</param>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged implementation
    }
}
