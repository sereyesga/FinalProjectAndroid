using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalProjectAndroid.Mobile.MVVM.ViewModels
{
    public class CountryViewModel
    {
        private string _countryName;
        private string _nationality;
        private bool _isRunning;
        private bool _isEnabled;

        public CountryViewModel()
        {
            IsEnabled = true;
        }

        public string CountryName
        { 
            get { return _countryName; }
            set
            {
                if (_countryName != value)
                {
                    _countryName = value;
                    OnPropertyChanged(nameof(CountryName));
                }
            }
        }

        public string Nationality
        {
            get { return _nationality; }
            set
            {
                if (_nationality != value)
                {
                    _nationality = value;
                    OnPropertyChanged(nameof(Nationality));
                }
            }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            set
            {
                if (_isRunning != value)
                {
                    _isRunning = value;
                    OnPropertyChanged(nameof(IsRunning));
                }
            }
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        public ICommand SaveCountryCommand => new Command(async () => await ExecuteSaveCountryCommand());

        private async Task ExecuteSaveCountryCommand()
        {
            bool isValid = await ValidateDataAsync();
        }

        private async Task<bool> ValidateDataAsync()
        {
            if (string.IsNullOrEmpty(CountryName))
            {
                await App.Current.MainPage.DisplayAlert("Error", "El campo nombre es obligatorio.", "Aceptar");
                return false;
            }

            if (string.IsNullOrEmpty(Nationality))
            {
                await App.Current.MainPage.DisplayAlert("Error", "El campo nacionalidad es obligatorio.", "Aceptar");
                return false;
            }

            return true;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
