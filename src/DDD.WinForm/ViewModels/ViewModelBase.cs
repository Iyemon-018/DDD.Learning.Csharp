namespace DDD.WinForm.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T field
                                            , T value
                                            , [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;

            field = value;
            var h = PropertyChanged;

            h?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return true;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}