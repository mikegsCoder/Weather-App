using System.Windows;

namespace WeatherApp.WPF.Windows.MessageBoxes
{
    public static class MessageBoxes
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(
                message,
                "Success",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}
