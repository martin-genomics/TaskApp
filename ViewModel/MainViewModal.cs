using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace MauiApp1.ViewModel
{
    public partial class MainViewModal: ObservableObject
    {
        public MainViewModal() {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;
        [RelayCommand]
        void Add()
        {
            if(string.IsNullOrEmpty(text))
            {
                return;
            }

            Items.Add(text);

            //add our item;
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string item) {
       
            Items.Remove(item);
        }

        [RelayCommand]
        async Task Tap(string item)
        {
            //method one of sending data;
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={item}");
            //method one of sending data;
            //await Shell.Current.GoToAsync(nameof(DetailPage),
            //    new Dictionary<string, object> { 
            ///        { nameof(DetailPage), new object()}
            //        }
            //    );
        }
    }
}
