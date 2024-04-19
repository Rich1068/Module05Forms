using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public int age;
        public PersonalInfoPage()
        {
            InitializeComponent();
        }
        void OnDateSelected(object sender, DataErrorsChangedEventArgs args)
        {
            DateTime birthdate = birthDatePicker.Date;
            DateTime today = DateTime.Today;
            age = today.Year - birthdate.Year;

            result.Text = age.ToString();
        }
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string fnametext = fname.Text;
            string mnametext = mname.Text;
            string lnametext = lname.Text;
            string gendertext = gender.SelectedItem as String;
            DateTime birthdate = birthDatePicker.Date;
            string birthdateText = birthdate.ToString("d MMMM yyyy");
            string agetext = age.ToString();
            string addresstext = address.Text;
            string contacttext = contact.Text;
            string emailtext = email.Text;
            string unametext = uname.Text;
            string passwordtext = password.Text;
            string cpasswordtext = cpassword.Text;

            DisplayAlert("Enter Values", $"Firstname: {fnametext}\n Middlename: {mnametext}\n Lastname: {lnametext}\n Gender: {gendertext}\n Birthdate: {birthdateText}\n Age: {agetext}\n" +
                $" Address: {addresstext}\n Contact: {contacttext}\n Email: {emailtext}\n Username: {unametext}\n Password: {passwordtext}\n Confirm Password: {cpasswordtext}\n are you sure you want to submit", "Ok", "Cancel");
        }
    }
}