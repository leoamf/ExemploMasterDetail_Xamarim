using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExemploMasterDetail
{
    public partial class FirstScreen : ContentPage
    {
        public FirstScreen()
        {
            InitializeComponent();

            Label lblNovo = new Label();
            lblNovo.TextColor = Color.Blue;
            lblNovo.BindingContext = slider;
            lblNovo.SetBinding(Label.TextProperty, "Value");
            stack.Children.Add(lblNovo);

            Label lblNovo2 = new Label();
            lblNovo2.TextColor = Color.Green;
            Binding binding = new Binding { Source=slider, Path="Value" };
            lblNovo2.SetBinding(Label.TextProperty, binding);
            stack.Children.Add(lblNovo2);
        }

    }
}
