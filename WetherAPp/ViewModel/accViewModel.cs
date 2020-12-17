using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using WetherAPp.Model;
using WetherAPp.ViewModel.command;

namespace WetherAPp.ViewModel
{
    public class accViewModel : INotifyPropertyChanged
    {
        public accViewModel()
        {
            cities = new ObservableCollection<City>();
            cmd = new Command(this);
           
        }
        public ICommand cmd { get; set; }
        private ObservableCollection<City> cities;

        public ObservableCollection<City> Cities
        {
            get { return cities; }
            set { cities = value; OnPropertyChanged("Cities"); }
        }


        private string query;

        public string Query
        {
            get { return query; }
            set { query = value; OnPropertyChanged("Query"); }
        }
        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set { selectedCity = value; OnPropertyChanged("SelectedCity"); currcon(); }
        }

        private CurrentCondition currCond;

        public CurrentCondition CurrCond
        {
            get { return currCond; }
            set { currCond = value; OnPropertyChanged("CurrCond"); }
        }
        public async void GetCities()
        {
           
            var citi = await AccWetherHelper.GetCities(Query);
            foreach (var city in citi)
            {
                cities.Add(city);
            }
        }
        public async void currcon()
        {
            //Query = string.Empty;
            //Cities.Clear();
            CurrCond = await AccWetherHelper.GetCondition(selectedCity.Key);

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
