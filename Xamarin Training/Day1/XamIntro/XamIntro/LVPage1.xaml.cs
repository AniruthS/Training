using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamIntro
{
    public partial class LVPage1 : ContentPage
    {
        string[] courses =
        {
            "ADO.NET By Example",
            "Working with Databases using JDBC",
            "JAVA EE: Programming Servlets",
            "JAVA EE: Java Server Pages",
            "Building Web App using Spring MVC, Hibernate and REST Services",
            "Design Patterns and Best Practices in JAVA EE 8",
            "Python 3 Programming A Step By Step Guide",
            "Mastering Object Oriented Programming using Python"
        };

        public LVPage1()
        {
            InitializeComponent();

            ListViewCourses.ItemsSource = courses;
            ListViewCourses.ItemSelected += ListViewCourses_ItemSelected;
        }

        private void ListViewCourses_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var course = e.SelectedItem.ToString();
            var msg = $"You have selected {course} course";
            DisplayAlert("Demo", msg, "OK");
        }
    }
}
