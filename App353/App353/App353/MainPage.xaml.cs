using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App353
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        viewModel vm;
        public MainPage()
        {
            InitializeComponent();

            vm = new viewModel();
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var text = numberEntry.Text;
            int number = Convert.ToInt32(text);

            for (int i = 0; i < number; i++)
            {
                PersonalInfo memberOne = new PersonalInfo() { name = "", phone = "" };
                vm.familyMember.Add(memberOne);
            }

        }
    }

    public class viewModel {

        public ObservableCollection<PersonalInfo> familyMember { get; set; }

        public viewModel()
        {
            familyMember = new ObservableCollection<PersonalInfo>();

            //PersonalInfo memberOne = new PersonalInfo() {name = "jack", phone="516" };

            //familyMember.Add(memberOne);
        }
    }

    public class PersonalInfo
    {
        public string name { get; set; }
        public string phone { get; set; }
    }
}
