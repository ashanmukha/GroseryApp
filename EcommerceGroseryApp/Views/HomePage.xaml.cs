namespace EcommerceGroseryApp.Views;

using EcommerceGroseryApp.Helpers;
using EcommerceGroseryApp.Models;
using EcommerceGroseryApp.Models.Enums;
using MauiEx;
using Microsoft.Maui.Controls;
using System;

public partial class HomePage : ContentPage
{
    private List<Countries> countries;
    public HomePage()
	{
		InitializeComponent();
        //using (var s = typeof(Single).Assembly.GetManifestResourceStream("SampleApp.Data.Countries.txt"))
        //{
        //    countries = new StreamReader(s).ReadToEnd().Split('\n').Select(t => t.Trim()).ToList();
        //}
        //SuggestBox1.ItemsSource = countries;

        countries = new List<Countries>()
        {
            new Countries()
            {
                Name="shannu",
                Code=1
            },
            new Countries()
            {
                Name="shanmukha",
                Code=2
            },
            new Countries()
            {
                Name="kavya",
                Code=3
            }
        };
       
        SuggestBox1.ItemsSource = countries;

    }
    private void SuggestBox_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
    {
        AutoSuggestBox box = (AutoSuggestBox)sender;
        // Filter the list based on text input
        box.ItemsSource = GetSuggestions(box.Text);
    }

    private List<Countries> GetSuggestions(string text)
    {
        return string.IsNullOrWhiteSpace(text) ? countries : countries.Where(s => s.Name.StartsWith(text, StringComparison.InvariantCultureIgnoreCase)).ToList();
    }

    private void SuggestBox_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
    {
        if (e.ChosenSuggestion == null)
            status.Text = "Query submitted: " + e.QueryText;
        else
            status.Text = "Suggestion chosen: " + e.ChosenSuggestion;

        //Move focus to the next control or stop focus
        if (sender == SuggestBox1)
            SuggestBox2.Focus();
        else if (sender == SuggestBox2)
            SuggestBox2.Unfocus();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        EventTracker.TrackEvent(EventName.LoginClicked);
    }
}