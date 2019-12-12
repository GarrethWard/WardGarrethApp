using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanetsAssignGarrethWard
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Newsletter : ContentPage
	{
		public Newsletter ()
		{
			InitializeComponent ();
            //functions store and get details saved
            btnStore.Clicked += BtnStore_Clicked;

            btnGet.Clicked += BtnGet_Clicked;

        }
       

        private void BtnGet_Clicked(object sender, EventArgs e)

        {

            //Get all Values

            if (Application.Current.Properties.ContainsKey("ID"))

            {
                lblId.Text = Application.Current.Properties["ID"].ToString();

                lblName.Text = Application.Current.Properties["Name"].ToString();
            }
        }



        private void BtnStore_Clicked(object sender, EventArgs e)

        {

            // Store all  Values

            Application.Current.Properties["ID"] = txtId.Text;

            Application.Current.Properties["Name"] = txtName.Text;


            txtId.Text = string.Empty;

            txtName.Text = string.Empty;

            DisplayAlert("Success", "You have signed up", "OK");

           
        }

    }
}