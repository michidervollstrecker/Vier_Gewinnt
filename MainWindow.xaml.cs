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
        public bool[] barr1 = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public bool[] barr2 = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public void next()
        {
            if (P1.IsChecked == true)
            {
                P2.IsChecked = true;
            }
            else if (P2.IsChecked == true)
            {
                P1.IsChecked = true;
            }
        }
        public void chk()
        {
            if (barr1[0] == true && barr1[1] == true && barr1[2] == true && barr1[3] == true)
            {
                MessageBox.Show("Vier gewinnt Player Red reste Reihe horizontal");
            }
            else if ((barr2[0] == true && barr2[1] == true && barr2[2] == true && barr2[3] == true))
            {
                MessageBox.Show("Vier gewinnt Player Green erste Reihe horizontal");
            }

            if (barr1[4] == true && barr1[5] == true && barr1[6] == true && barr1[7] == true && barr1[8] == true)
            {
                MessageBox.Show("Vier gewinnt Player Red zweite Reihe horizontal");
            }
            else if (barr2[4] == true && barr2[5] == true && barr2[6] == true && barr2[7] == true && barr2[8] == true)
            {
                MessageBox.Show("Vier gewinnt zweite Reihe horizontal Player Green");
            }
            if (barr1[9] == true && barr1[10] == true && barr1[11] == true && barr1[12] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe horizontal Player Red");
            }
            else if (barr2[9] == true && barr2[10] == true && barr2[11] == true && barr2[12] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe horizontalPlayer green");
            }
            if (barr1[13] == true && barr1[14] == true && barr1[15] == true && barr1[16] == true)
            {
                MessageBox.Show("Vier gewinnt vierte Reihe horizontal Player Red");
            }
            if (barr1[0] == true && barr1[1] == true && barr1[2] == true && barr1[13] == true)
            {
                MessageBox.Show("Vier gewinnt erste Reihe vertikal Player Red");
            }
            else if ((barr2[0] == true && barr2[1] == true && barr2[2] == true && barr2[3] == true))
            {
                MessageBox.Show("Vier gewinnt erste Reihe vertikal Player Green");
            }
            if (barr1[2] == true && barr1[6] == true && barr1[10] == true && barr1[14] == true)
            {
                MessageBox.Show("Vier gewinnt zweite Reihe vertikal green Player Red");
            }
            if (barr2[2] == true && barr2[6] == true && barr2[10] == true && barr2[14] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe vertikal Green");
            }
            if (barr1[3] == true && barr1[7] == true && barr1[11] == true && barr1[15] == true)
            {
                MessageBox.Show("Vier gewinnt vierte Reihe vertikal Player Red");
            }
            else if (barr1[3] == true && barr1[7] == true && barr1[11] == true && barr1[15] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe vertikal Player Green");
            }
            if (barr1[0] == true && barr1[5] == true && barr1[10] == true && barr1[15] == true)
            {
                MessageBox.Show("Vier gewinnt Red Diagonal");
            }
            else if (barr2[0] == true && barr2[5] == true && barr2[10] == true && barr2[15] == true)
            {
                MessageBox.Show("Vier gewinnt Green diagonal");
            }
            if (barr1[3] == true && barr1[6] == true && barr1[9] == true && barr1[12] == true)
            {
                MessageBox.Show("Vier gewinnt Red diagonal");
            }
            else if (barr2[3] == true && barr2[6] == true && barr2[9] == true && barr2[12] == true)
            {
                MessageBox.Show("Vier gewinnt Green diagonal");
            }
            if (barr1[0] == true && barr1[4] == true && barr1[8] == true && barr1[12] == true)
            {
                MessageBox.Show("Vier gewinnt Player Red erste Reihe vertikal");
            }
            else if (barr2[0] == true && barr2[4] == true && barr2[8] == true && barr2[12] == true)
            {
                MessageBox.Show("Vier gewinnt Player Green erste Reihe vertikal");
            }

        }
        private void RB1_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[0] = true;
                G1.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G1.Background = System.Windows.Media.Brushes.Green;
                barr2[0] = true;
            }
            next();
            chk();
        }
        private void RB6_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[5] = true;
                G6.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[5] = true;
                G6.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB2_Checked(object sender, RoutedEventArgs e)
        {

            if (P1.IsChecked == true)
            {
                barr1[1] = true;
                G2.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[1] = true;
                G2.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB33_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[2] = true;
                G3.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[2] = true;
                G3.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB4_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[3] = true;
                G4.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[3] = true;
                G4.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB5_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[4] = true;
                G5.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[4] = true;
                G5.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }

        private void RB7_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[6] = true;
                G7.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[6] = true;
                G7.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB8_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[7] = true;
                G8.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[7] = true;
                G8.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }

        private void RB9_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[8] = true;

                G9.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[8] = true;
                G9.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }

        private void RB10_Checked(object sender, RoutedEventArgs e)
        {
            barr1[9] = true;
            bool rb10 = true;
            if (P1.IsChecked == true)
            {
                barr1[9] = true;
                G10.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[9] = true;
                G10.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB11_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[10] = true;
                G11.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[10] = true;
                G11.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }

        private void RB12_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[11] = true;
                G12.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[11] = true;
                G12.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB13_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[12] = true;
                G13.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[12] = true;
                G13.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }

        private void RB14_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[13] = true;
                G14.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[13] = true;
                G14.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB15_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[14] = true;
                G15.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[14] = true;
                G15.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }
        private void RB16_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                barr1[15] = true;
                G16.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                barr2[15] = true;
                G16.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chk();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
        private void P1_Click(object sender, RoutedEventArgs e)
        {
        }
        private void P2_Checked(object sender, RoutedEventArgs e)
        {
        }
        private void P1_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}
