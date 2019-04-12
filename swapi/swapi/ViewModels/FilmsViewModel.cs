using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using swapi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace swapi.ViewModels
{
    public class FilmsViewModel : INotifyPropertyChanged
    {
        private IList<Film> _films;

        public IList<Film> Films
        {
            get => _films;
            set
            {
                _films = value;
                OnPropertyChanged(nameof(Films));
            }
        }

        public class Rootobject
        {
            public int count { get; set; }
            public object next { get; set; }
            public object previous { get; set; }
            public List<Film> results { get; set; }
        }

        public async Task<List<Film>> GetFilmsAsync()
        {
            var Url = "https://swapi.co/api/films";
            using (var client = new HttpClient())
            {
                try
                {
                    var responseContent = await client.GetStringAsync(Url);
                    Rootobject root = JsonConvert.DeserializeObject<Rootobject>(responseContent);
                    List<Film> films = root.results;
                    Films = films;

                    return films;
                }
                catch (Exception ex)
                {
                    var message = ex.Message;
                    throw;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}