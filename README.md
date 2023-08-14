# Simple dotnet Maui App to demonstrate DateTime format error

Code and Culture are english GB

DateTime.Parse("1 September 2023").ToString("dd-MMM-yyyy") = "01-Sept-2023"

All other months format correctly to 3 letters

MainPage.xaml displays the issue with the above code in the MainPage.xaml.cs
