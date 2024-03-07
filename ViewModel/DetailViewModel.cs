using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

//Text 1 is the accessible name in this specific model
//Text 2 is the query param from MainViewModel.cs
[QueryProperty("Text", "Text")]
public partial class DetailViewModel: ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    static async Task GoBack()
    {

        await Shell.Current.GoToAsync("..");
    }

}

