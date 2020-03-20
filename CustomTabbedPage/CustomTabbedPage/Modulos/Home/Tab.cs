using MvvmHelpers;

namespace CustomTabbedPage.Modulos.Home
{
    public class Tab : BaseViewModel
    {
        public string Id { get; set; }
        public bool Selected { get; set; }
        public string Title { get; set; }
        //public List<Place> Items { get; set; }
    }
}
