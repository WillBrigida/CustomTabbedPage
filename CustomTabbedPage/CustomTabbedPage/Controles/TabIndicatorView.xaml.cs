using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomTabbedPage.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabIndicatorView : Grid
    {
        public static readonly BindableProperty ItemsProperty = BindableProperty.Create(nameof(Items), typeof(IEnumerable), typeof(TabIndicatorView), null);
        public static readonly BindableProperty CurrentItemProperty = BindableProperty.Create(nameof(CurrentItem), typeof(object), typeof(TabIndicatorView), null, BindingMode.TwoWay, propertyChanged: CurrentItemChange);
        public IEnumerable Items
        {
            get { return (IEnumerable)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }
        public object CurrentItem
        {
            get { return (object)GetValue(CurrentItemProperty); }
            set { SetValue(CurrentItemProperty, value); }
        }
        public TabIndicatorView()
        {
            InitializeComponent();
        }
        static void CurrentItemChange(object bindable, object oldValue, object newValue)
        {
            var x = (TabIndicatorView)bindable;
            var labelContainer = x.FindByName("myList") as FlexLayout;
            foreach (Label label in labelContainer.Children)
            {
                var tabGesture = label.GestureRecognizers[0] as TapGestureRecognizer;
                if (newValue == tabGesture.CommandParameter)
                {
                    x.MoveActiveIndicator(label);
                    return;
                }
            }
        }

        void MoveActiveIndicator(Label target)
        {
            var width = target.Width - activeIndicator.Width;
            activeIndicator.TranslateTo(target.X + (width / 2), 0, 100, Easing.Linear);
        }
        void ChangeTab(System.Object sender, System.EventArgs e)
        {
            foreach (var item in Items)
            {
                if (item == ((TappedEventArgs)e).Parameter)
                {
                    CurrentItem = item;
                    return;
                }
            }
        }
    }
}