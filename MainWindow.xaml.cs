using System.Windows;

namespace Vier_Gewinnt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            P1.IsChecked = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

        }
        /// <summary>
        /// Clean up any res
        public void checkchecklin()
        {
            if (RB1.IsChecked == true && RB2.IsChecked == true && RB33.IsChecked == true && RB4.IsChecked == true)
            {
                MessageBox.Show("Vier Gewinnt checkcheck");
                G1.Background = System.Windows.Media.Brushes.Wheat;
                G2.Background = System.Windows.Media.Brushes.Wheat;
                G3.Background = System.Windows.Media.Brushes.Wheat;
                G4.Background = System.Windows.Media.Brushes.Wheat;
                RB1.IsChecked = false;
                RB2.IsChecked = false;
                RB33.IsChecked = false;
                RB4.IsChecked = false;
            }
            else if (RB5.IsChecked == true && RB6.IsChecked == true && RB7.IsChecked == true && RB8.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt checkcheck");
                G5.Background = System.Windows.Media.Brushes.Wheat;
                G6.Background = System.Windows.Media.Brushes.Wheat;
                G7.Background = System.Windows.Media.Brushes.Wheat;
                G8.Background = System.Windows.Media.Brushes.Wheat;
                RB5.IsChecked = false;
                RB6.IsChecked = false;
                RB7.IsChecked = false;
                RB8.IsChecked = false;
            }
            else if (RB9.IsChecked == true && RB10.IsChecked == true && RB11.IsChecked == true && RB12.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt checkcheck");
                G9.Background = System.Windows.Media.Brushes.Wheat;
                G10.Background = System.Windows.Media.Brushes.Wheat;
                G11.Background = System.Windows.Media.Brushes.Wheat;
                G12.Background = System.Windows.Media.Brushes.Wheat;
                RB9.IsChecked = false;
                RB10.IsChecked = false;
                RB11.IsChecked = false;
                RB12.IsChecked = false;
            }
            else if (RB13.IsChecked == true && RB14.IsChecked == true && RB15.IsChecked == true && RB16.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt checkcheck");
                G13.Background = System.Windows.Media.Brushes.Wheat;
                G14.Background = System.Windows.Media.Brushes.Wheat;
                G15.Background = System.Windows.Media.Brushes.Wheat;
                G16.Background = System.Windows.Media.Brushes.Wheat;
                RB13.IsChecked = false;
                RB14.IsChecked = false;
                RB15.IsChecked = false;
                RB16.IsChecked = false;
            }
            //Vertical
            if (RB1.IsChecked == true && RB5.IsChecked == true && RB9.IsChecked == true && RB13.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt vertikal");
                G1.Background = System.Windows.Media.Brushes.Maroon;
                G5.Background = System.Windows.Media.Brushes.Maroon;
                G9.Background = System.Windows.Media.Brushes.Maroon;
                G13.Background = System.Windows.Media.Brushes.Maroon;
                RB1.IsChecked = false;
                RB5.IsChecked = false;
                RB9.IsChecked = false;
                RB13.IsChecked = false;
            }
            else if (RB2.IsChecked == true && RB6.IsChecked == true && RB10.IsChecked == true && RB14.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt vertikal");
                G2.Background = System.Windows.Media.Brushes.Maroon;
                G6.Background = System.Windows.Media.Brushes.Maroon;
                G10.Background = System.Windows.Media.Brushes.Maroon;
                G14.Background = System.Windows.Media.Brushes.Maroon;
                RB2.IsChecked = false;
                RB6.IsChecked = false;
                RB10.IsChecked = false;
                RB14.IsChecked = false;
            }
            else if (RB33.IsChecked == true && RB7.IsChecked == true && RB11.IsChecked == true && RB15.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt vertikal");
                G3.Background = System.Windows.Media.Brushes.Maroon;
                G7.Background = System.Windows.Media.Brushes.Maroon;
                G11.Background = System.Windows.Media.Brushes.Maroon;
                G15.Background = System.Windows.Media.Brushes.Maroon;
                RB33.IsChecked = false;
                RB7.IsChecked = false;
                RB11.IsChecked = false;
                RB15.IsChecked = false;
            }
            else if (RB4.IsChecked == true && RB8.IsChecked == true && RB12.IsChecked == true && RB16.IsChecked == true)
            {
                MessageBox.Show("Vier gewinnt vertikal");
                G4.Background = System.Windows.Media.Brushes.Maroon;
                G8.Background = System.Windows.Media.Brushes.Maroon;
                G12.Background = System.Windows.Media.Brushes.Maroon;
                G16.Background = System.Windows.Media.Brushes.Maroon;
                RB4.IsChecked = false;
                RB8.IsChecked = false;
                RB12.IsChecked = false;
                RB16.IsChecked = false;
            }

        }

        private void RB1_Checked(object sender, RoutedEventArgs e)
        {
            bool rb1 = true;
            if (P1.IsChecked == true)
            {
                G1.Background = System.Windows.Media.Brushes.Red;

            }
            else if (P2.IsChecked == true)
            {
                G1.Background = System.Windows.Media.Brushes.Green;
                P1.IsChecked = true;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB6_Checked(object sender, RoutedEventArgs e)
        {
            bool rb6 = true;
            if (P1.IsChecked == true)
            {
                G6.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G6.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB2_Checked(object sender, RoutedEventArgs e)
        {
            bool rb2 = true;
            if (P1.IsChecked == true)
            {
                G2.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G2.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }


        private void RB33_Checked(object sender, RoutedEventArgs e)
        {
            bool rb33 = true;
            if (P1.IsChecked == true)
            {
                G3.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G3.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }


        private void RB4_Checked(object sender, RoutedEventArgs e)
        {
            bool rb4 = true;
            if (P1.IsChecked == true)
            {
                G4.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G4.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB5_Checked(object sender, RoutedEventArgs e)
        {
            bool rb5 = true;
            if (P1.IsChecked == true)
            {
                G5.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G5.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB7_Checked(object sender, RoutedEventArgs e)
        {
            bool rb7 = true;
            if (P1.IsChecked == true)
            {
                G7.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G7.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB8_Checked(object sender, RoutedEventArgs e)
        {
            bool rb8 = true;
            if (P1.IsChecked == true)
            {
                G8.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G8.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB9_Checked(object sender, RoutedEventArgs e)
        {
            bool rb9 = true;
            if (P1.IsChecked == true)
            {

                G9.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G9.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB10_Checked(object sender, RoutedEventArgs e)
        {
            bool rb10 = true;
            if (P1.IsChecked == true)
            {
                G10.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G10.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB11_Checked(object sender, RoutedEventArgs e)
        {
            bool rb11 = true;
            if (P1.IsChecked == true)
            {
                G11.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G11.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB12_Checked(object sender, RoutedEventArgs e)
        {
            bool rb12 = true;
            if (P1.IsChecked == true)
            {
                G12.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G12.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB13_Checked(object sender, RoutedEventArgs e)
        {
            bool rb13 = true;
            if (P1.IsChecked == true)
            {
                G13.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G13.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB14_Checked(object sender, RoutedEventArgs e)
        {
            bool rb14 = true;
            if (P1.IsChecked == true)
            {
                G14.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G14.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB15_Checked(object sender, RoutedEventArgs e)
        {
            bool rb15 = true;
            if (P1.IsChecked == true)
            {
                G15.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G15.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void RB16_Checked(object sender, RoutedEventArgs e)
        {
            bool rb16 = true;
            if (P1.IsChecked == true)
            {
                G16.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G16.Background = System.Windows.Media.Brushes.Green;
            }
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            checkchecklin();

            if (RB1.IsChecked == true && RB2.IsChecked == true && RB33.IsChecked == true && RB4.IsChecked == true)
            {

            }
            else if (RB5.IsChecked == true && RB6.IsChecked == true && RB7.IsChecked == true && RB8.IsChecked == true)
            {

            }
            else if (RB9.IsChecked == true && RB10.IsChecked == true && RB11.IsChecked == true && RB12.IsChecked == true)
            {

            }
            else if (RB13.IsChecked == true && RB14.IsChecked == true && RB15.IsChecked == true && RB16.IsChecked == true)
            {

            }
            if (RB1.IsChecked == true && RB5.IsChecked == true && RB9.IsChecked == true && RB13.IsChecked == true)
            {

            }
            else if (RB2.IsChecked == true && RB6.IsChecked == true && RB10.IsChecked == true && RB14.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");

            }
            if (RB33.IsChecked == true && RB7.IsChecked == true && RB11.IsChecked == true && RB15.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");

            }
            if (RB4.IsChecked == true && RB8.IsChecked == true && RB12.IsChecked == true && RB16.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");

            }
            if (RB1.IsChecked == true && RB6.IsChecked == true && RB11.IsChecked == true && RB16.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");

            }
            if (RB4.IsChecked == true && RB7.IsChecked == true && RB10.IsChecked == true && RB13.IsChecked == true)
            {
                MessageBox.Show("vier gewinnt");
                G4.Background = System.Windows.Media.Brushes.Wheat;
                G7.Background = System.Windows.Media.Brushes.Wheat;
                G10.Background = System.Windows.Media.Brushes.Wheat;
                G13.Background = System.Windows.Media.Brushes.Wheat;
                RB4.IsChecked = false;
                RB7.IsChecked = false;
                RB10.IsChecked = false;
                RB13.IsChecked = false;

            }

        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void P2_Checked(object sender, RoutedEventArgs e)
        {
            bool pl2 = true;
        }

        private void P1_Checked(object sender, RoutedEventArgs e)
        {
            bool pl1 = true;
        }
    }
}
