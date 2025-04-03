using System;
using System.Windows;
using HelloWorldLibrary; // Reference to the .NET Standard library
namespace HelloWorldWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Initializes the components defined in the XAML file
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the username from the TextBox
            string username = txtUsername.Text;

            // Check if the username is empty or whitespace
            if (string.IsNullOrWhiteSpace(username))
            {
                // Show an error message if the username is invalid
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create the greeting message
            string message = HelloWorldHelper.GetGreetingMessage(username);

            // Display the greeting message in a MessageBox
            MessageBox.Show(message, "Greeting", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}