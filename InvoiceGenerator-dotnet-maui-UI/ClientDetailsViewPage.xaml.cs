using InvoiceGenerator_dotnet_maui_UI.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InvoiceGenerator_dotnet_maui_UI;

public partial class ClientDetailsViewPage : ContentPage
{

    //public ClientDetailsListViewModel ViewModel { get; set; }

    public ClientDetailsViewPage(ClientDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

        //lst_clients.SetValue(ItemsView.ItemsSourceProperty, ViewModel);

        //this.BindingContext = ViewModel;


        //var allClients = _clientService.GetClients();
        //if (allClients.Any())
        //{
        //    Monkeys.Clear();
        //}
        //foreach(var client in allClients)
        //{
        //    Monkeys.Add(new ClientDetailsViewModel
        //    {
        //        ClientAddress = client.ClientAddress,
        //        ClientName = client.ClientName,
        //        ContactEmail = client.ContactEmail,
        //        ContactName = client.ContactName
        //    });
        //}

        //var thing = allClients.Select(c => new ClientDetailsViewModel
        //{
        //    ClientName = c.ClientName,
        //    ClientAddress = c.ClientAddress
        //}).ToList();

        //var viewModelList = new ClientDetailsListViewModel();
        //viewModelList.ViewList = viewModels;
    }
}

//public class ClientDetailsListViewModel : ViewModelBase
//{
//    private List<ClientDetailsViewModel> viewList;
//    public List<ClientDetailsViewModel> ViewList
//    {
//        get => viewList;
//        set => SetProperty(ref viewList, value);
//    }
//}

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public bool SetProperty<T>(ref T field, T value, [CallerMemberName] string name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        return true;
    }
}