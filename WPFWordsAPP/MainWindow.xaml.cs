using System.Windows;

namespace WPFWordsAPP;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string inputText = txtWord.Text;
        if(inputText != "")
        {
            MessageBox.Show("You entered: " + inputText, "Input Confirmation");
        }

    }
}