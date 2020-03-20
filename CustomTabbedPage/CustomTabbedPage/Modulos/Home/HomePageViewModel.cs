using MvvmHelpers;
using System.Collections.ObjectModel;

namespace CustomTabbedPage.Modulos.Home
{
    public class HomePageViewModel : BaseViewModel
    {
        private ObservableCollection<Tab> _listaTabs;
        public ObservableCollection<Tab> ListaTabs
        {
            get { return _listaTabs; }
            set { SetProperty(ref _listaTabs, value); }
        }

        private Tab _item;
        public Tab Item
        {
            get { return _item; }
            set
            { SetProperty(ref _item, value); }
        }

        public HomePageViewModel()
        {
            ListaTabs = new ObservableCollection<Tab>
            {
                new Tab{Title = "Tab1", Id = "A", Selected = true},
                new Tab{Title = "Tab2", Id = "B"},
                new Tab{Title = "Tab3", Id = "C",},
                new Tab{Title = "Tab4", Id = "D",},
            };

            Item = new Tab();
        }
    }
}
