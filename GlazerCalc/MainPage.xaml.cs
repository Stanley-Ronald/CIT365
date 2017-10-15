using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void submitButton_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            width = double.Parse(widthTextBox.Text);
            height = double.Parse(heightTextBox.Text);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile saveFile = await storageFolder.CreateFileAsync("results.txt", CreationCollisionOption.ReplaceExisting);
            string comboBox = ((ContentControl)colorTint.SelectedItem).Content.ToString();
            await FileIO.WriteTextAsync(saveFile, "Width: " + widthTextBox.Text + "\n" + "Height: " + heightTextBox.Text + "\n" + "Tint Color: " +  comboBox + "\n" + "The length of the wood is " + woodLength + " feet"
                + "\n" + "The glass area is " + glassArea + " square meters" + "\n" + "Date Ordered: " + DateTime.Now);

            

            this.Frame.Navigate(typeof(SubmitResult), null);

        }


        private async void validateWidthInput(object sender, KeyRoutedEventArgs e)
        {
            char key = (char)e.Key;

            if (!char.IsDigit(key))
            {
                widthTextBox.Text = "";
                var dialog = new MessageDialog("Please enter a number!");
                await dialog.ShowAsync();
            }
        }


        private async void validateHeightInput(object sender, KeyRoutedEventArgs e)
        {
            char key = (char)e.Key;

            if (!char.IsDigit(key))
            {
                heightTextBox.Text = "";
                var dialog = new MessageDialog("Please enter a number!");
                await dialog.ShowAsync();
            }

        }
    }
}
