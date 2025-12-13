using System.Windows;

namespace Vier_Gewinnt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RB1_Checked(object sender, RoutedEventArgs e)
        {
            bool rb1 = true;
            G1.Background = System.Windows.Media.Brushes.Red;

        }

        private void RB6_Checked(object sender, RoutedEventArgs e)
        {
            bool rb6 = true;
            G6.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB2_Checked(object sender, RoutedEventArgs e)
        {
            bool rb2 = true;
            G2.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB33_Checked(object sender, RoutedEventArgs e)
        {
            bool rb3 = true;
            G3.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB4_Checked(object sender, RoutedEventArgs e)
        {
            bool rb4 = true;
            G4.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB5_Checked(object sender, RoutedEventArgs e)
        {
            bool rb5 = true;
            G5.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB7_Checked(object sender, RoutedEventArgs e)
        {
            bool rb7 = true;
            G7.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB8_Checked(object sender, RoutedEventArgs e)
        {
            bool rb8 = true;
            G8.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB9_Checked(object sender, RoutedEventArgs e)
        {
            bool rb9 = true;
            G9.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB10_Checked(object sender, RoutedEventArgs e)
        {
            bool rb10 = true;
            G10.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB11_Checked(object sender, RoutedEventArgs e)
        {
            bool rb11 = true;
            G11.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB12_Checked(object sender, RoutedEventArgs e)
        {
            bool rb12 = true;
            G12.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB13_Checked(object sender, RoutedEventArgs e)
        {
            bool rb13 = true;
            G13.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB14_Checked(object sender, RoutedEventArgs e)
        {
            bool rb14 = true;
            G14.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB15_Checked(object sender, RoutedEventArgs e)
        {
            bool rb15 = true;
            G15.Background = System.Windows.Media.Brushes.Red;
        }

        private void RB16_Checked(object sender, RoutedEventArgs e)
        {
            bool rb16 = true;
            G16.Background = System.Windows.Media.Brushes.Red;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RB1.IsChecked == true && RB2.IsChecked == true && RB33.IsChecked == true && RB4.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");
                G1.Background = System.Windows.Media.Brushes.Wheat;
                G2.Background = System.Windows.Media.Brushes.Wheat;
                G3.Background = System.Windows.Media.Brushes.Wheat;
                G4.Background = System.Windows.Media.Brushes.Wheat;
            }
            else if (RB5.IsChecked == true && RB6.IsChecked == true && RB7.IsChecked == true && RB8.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt");
                G5.Background = System.Windows.Media.Brushes.Wheat;
                G6.Background = System.Windows.Media.Brushes.Wheat;
                G7.Background = System.Windows.Media.Brushes.Wheat;
                G8.Background = System.Windows.Media.Brushes.Wheat;
            }
            else if (RB9.IsChecked == true && RB10.IsChecked == true && RB11.IsChecked == true && RB12.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt");
                G9.Background = System.Windows.Media.Brushes.Wheat;
                G10.Background = System.Windows.Media.Brushes.Wheat;
                G11.Background = System.Windows.Media.Brushes.Wheat;
                G12.Background = System.Windows.Media.Brushes.Wheat;
            }
            else if (RB13.IsChecked == true && RB14.IsChecked == true && RB15.IsChecked == true && RB16.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt");
                G13.Background = System.Windows.Media.Brushes.Wheat;
                G14.Background = System.Windows.Media.Brushes.Wheat;
                G15.Background = System.Windows.Media.Brushes.Wheat;
                G16.Background = System.Windows.Media.Brushes.Wheat;
            }
            if (RB1.IsChecked == true && RB5.IsChecked == true && RB9.IsChecked == true && RB13.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");
                G1.Background = System.Windows.Media.Brushes.Wheat;
                G5.Background = System.Windows.Media.Brushes.Wheat;
                G9.Background = System.Windows.Media.Brushes.Wheat;
                G13.Background = System.Windows.Media.Brushes.Wheat;
            }
            else if (RB2.IsChecked == true && RB6.IsChecked == true && RB10.IsChecked == true && RB14.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");
                G2.Background = System.Windows.Media.Brushes.Wheat;
                G6.Background = System.Windows.Media.Brushes.Wheat;
                G10.Background = System.Windows.Media.Brushes.Wheat;
                G14.Background = System.Windows.Media.Brushes.Wheat;

            }
            if (RB33.IsChecked == true && RB7.IsChecked == true && RB11.IsChecked == true && RB15.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");
                G3.Background = System.Windows.Media.Brushes.Wheat;
                G7.Background = System.Windows.Media.Brushes.Wheat;
                G11.Background = System.Windows.Media.Brushes.Wheat;
                G15.Background = System.Windows.Media.Brushes.Wheat;
            }
            if (RB4.IsChecked == true && RB8.IsChecked == true && RB12.IsChecked == true && RB16.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");
                G4.Background = System.Windows.Media.Brushes.Wheat;
                G8.Background = System.Windows.Media.Brushes.Wheat;
                G12.Background = System.Windows.Media.Brushes.Wheat;
                G16.Background = System.Windows.Media.Brushes.Wheat;
            }
        }
    }
}
