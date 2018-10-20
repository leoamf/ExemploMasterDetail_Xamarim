using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExemploMasterDetail
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
         
        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            var obj = sender as Button;
            if( obj.Text == "Third"){
                ((MasterDetailPage)this.Parent).Detail = new NavigationPage( new ThirdScreen());
                ((MasterDetailPage)this.Parent).IsPresented = false;

            }
            else if (obj.Text == "Second"){
                ((MasterDetailPage)this.Parent).Detail = new NavigationPage(new SecondScreen());
                ((MasterDetailPage)this.Parent).IsPresented = false;
            }
            else{
                    ((MasterDetailPage)this.Parent).Detail = new NavigationPage(new FirstScreen());
                ((MasterDetailPage)this.Parent).IsPresented = false;

            }
        }
    }
}
