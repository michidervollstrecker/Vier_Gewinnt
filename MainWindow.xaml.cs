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
        // public bool[] barr1 = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        //public bool[] barr2 = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        //public bool[,,] mbarr2 = { { { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false }, { false } } };
        public bool[,,] mbarr3 = { { { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false }, { false, false } } };
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
        public void chkmbarr2()
        {
            if (mbarr3[0, 0, 0] == true && mbarr3[0, 1, 0] == true && mbarr3[0, 2, 0] == true && mbarr3[0, 3, 0] == true)
            {
                MessageBox.Show("Vier gewinnt Player one reste Reihe horizontal");
            }
            else if ((mbarr3[0, 0, 1] == true && mbarr3[0, 1, 1] == true && mbarr3[0, 2, 1] == true && mbarr3[0, 3, 1] == true))
            {
                MessageBox.Show("Vier gewinnt Player two zweite Reihe horizontal");
            }

            if (mbarr3[0, 4, 0] == true && mbarr3[0, 5, 0] == true && mbarr3[0, 6, 0] == true && mbarr3[0, 7, 0] == true)
            {
                MessageBox.Show("Vier gewinnt Player one zweite Reihe horizontal");
            }
            else if (mbarr3[0, 4, 1] == true && mbarr3[0, 5, 1] == true && mbarr3[0, 6, 1] == true && mbarr3[0, 7, 1] == true)
            {
                MessageBox.Show("Vier gewinnt Player twoz weite Reihe horizontal");
            }
            if (mbarr3[0, 8, 0] == true && mbarr3[0, 9, 0] == true && mbarr3[0, 10, 0] == true && mbarr3[0, 11, 0] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe horizontal Player one");
            }
            else if (mbarr3[0, 8, 1] == true && mbarr3[0, 9, 1] == true && mbarr3[0, 10, 1] == true && mbarr3[0, 11, 1] == true)
            {
                MessageBox.Show("Vier gewinnt zweite Reihe horizontalPlayer two");
            }
            if (mbarr3[0, 13, 0] == true && mbarr3[0, 14, 0] == true && mbarr3[0, 15, 0] == true && mbarr3[0, 16, 0] == true)
            {
                MessageBox.Show("Vier gewinnt vierte Reihe horizontal Player one");
            }
            if (mbarr3[0, 0, 0] == true && mbarr3[0, 4, 0] == true && mbarr3[0, 8, 0] == true && mbarr3[0, 12, 0] == true)
            {
                MessageBox.Show("Vier gewinnt erste Reihe vertikal Player one");
            }
            else if ((mbarr3[0, 0, 1] == true && mbarr3[0, 4, 1] == true && mbarr3[0, 8, 1] == true && mbarr3[0, 12, 1] == true))
            {
                MessageBox.Show("Vier gewinnt erste Reihe vertikal Player two");
            }
            if (mbarr3[0, 1, 0] == true && mbarr3[0, 4, 0] == true && mbarr3[0, 9, 0] == true && mbarr3[0, 13, 0] == true)
            {
                MessageBox.Show("Vier gewinnt zweite Reihe vertikal green Player one");                                         //
            }
            if (mbarr3[0, 1, 1] == true && mbarr3[0, 5, 1] == true && mbarr3[0, 9, 1] == true && mbarr3[0, 13, 1] == true)
            {
                MessageBox.Show("Vier gewinnt zweite Reihe vertikal Player two");
            }
            if (mbarr3[0, 3, 0] == true && mbarr3[0, 7, 0] == true && mbarr3[0, 11, 0] == true && mbarr3[0, 15, 0] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe vertikal Player one");
            }
            else if (mbarr3[0, 3, 0] == true && mbarr3[0, 7, 0] == true && mbarr3[0, 11, 0] == true && mbarr3[0, 15, 0] == true)
            {
                MessageBox.Show("Vier gewinnt dritte Reihe vertikal Player two");
            }
            if (mbarr3[0, 3, 0] == true && mbarr3[0, 7, 0] == true && mbarr3[0, 11, 0] == true && mbarr3[0, 15, 0] == true)
            {
                MessageBox.Show("Vier gewinnt one Diagonal");
            }
            else if (mbarr3[0, 0, 1] == true && mbarr3[0, 5, 1] == true && mbarr3[0, 10, 1] == true && mbarr3[0, 15, 1] == true)
            {
                MessageBox.Show("Vier gewinnt two diagonal");
            }
            if (mbarr3[0, 3, 0] == true && mbarr3[0, 6, 0] == true && mbarr3[0, 9, 0] == true && mbarr3[0, 12, 0] == true)
            {
                MessageBox.Show("Vier gewinnt one diagonal");
            }
            else if (mbarr3[0, 3, 1] == true && mbarr3[0, 6, 1] == true && mbarr3[0, 9, 1] == true && mbarr3[0, 12, 1] == true)
            {
                MessageBox.Show("Vier gewinnt Green diagonal");
            }
            if (mbarr3[0, 0, 0] == true && mbarr3[0, 4, 0] == true && mbarr3[0, 8, 0] == true && mbarr3[0, 12, 0] == true)
            {
                MessageBox.Show("Vier gewinnt Player one erste Reihe vertikal");
            }
            else if (mbarr3[0, 0, 0] == true && mbarr3[0, 4, 1] == true && mbarr3[0, 8, 1] == true && mbarr3[0, 12, 1] == true)
            {
                MessageBox.Show("Vier gewinnt Player two erste Reihe vertikal");
            }
            {
                if (mbarr3[0, 0, 0] == true && mbarr3[0, 1, 0] == true && mbarr3[0, 2, 0] == true && mbarr3[0, 3, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt Player one reste Reihe horizontal");
                }
                else if ((mbarr3[0, 0, 1] == true && mbarr3[0, 1, 1] == true && mbarr3[0, 2, 1] == true && mbarr3[0, 3, 1] == true))
                {
                    MessageBox.Show("Vier gewinnt Player two erste Reihe horizontal");
                }

                if (mbarr3[0, 4, 0] == true && mbarr3[0, 5, 0] == true && mbarr3[0, 6, 0] == true && mbarr3[0, 7, 0] == true && mbarr3[0, 8, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt Player one zweite Reihe horizontal");
                }
                else if (mbarr3[0, 4, 1] == true && mbarr3[0, 5, 1] == true && mbarr3[0, 6, 1] == true && mbarr3[0, 7, 1] == true && mbarr3[0, 8, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt zweite Reihe horizontal Player two");
                }
                if (mbarr3[0, 9, 0] == true && mbarr3[0, 10, 0] == true && mbarr3[0, 11, 0] == true && mbarr3[0, 12, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt dritte Reihe horizontal Player one");
                }
                else if (mbarr3[0, 9, 1] == true && mbarr3[0, 10, 1] == true && mbarr3[0, 11, 1] == true && mbarr3[0, 12, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt dritte Reihe horizontalPlayer two");
                }
                if (mbarr3[0, 13, 0] == true && mbarr3[0, 14, 0] == true && mbarr3[0, 15, 0] == true && mbarr3[0, 16, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt vierte Reihe horizontal Player one");
                }
                if (mbarr3[0, 0, 0] == true && mbarr3[0, 1, 0] == true && mbarr3[0, 2, 0] == true && mbarr3[0, 13, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt erste Reihe vertikal Player one");
                }
                else if ((mbarr3[0, 0, 1] == true && mbarr3[0, 1, 1] == true && mbarr3[0, 2, 1] == true && mbarr3[0, 3, 1] == true))
                {
                    MessageBox.Show("Vier gewinnt erste Reihe vertikal Player two");
                }
                if (mbarr3[0, 2, 0] == true && mbarr3[0, 6, 0] == true && mbarr3[0, 10, 0] == true && mbarr3[0, 14, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt zweite Reihe vertikal green Player one");
                }
                if (mbarr3[0, 2, 1] == true && mbarr3[0, 6, 1] == true && mbarr3[0, 10, 1] == true && mbarr3[0, 14, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt dritte Reihe vertikal two");
                }
                if (mbarr3[0, 3, 0] == true && mbarr3[0, 7, 0] == true && mbarr3[0, 11, 0] == true && mbarr3[0, 15, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt vierte Reihe vertikal Player one");
                }
                else if (mbarr3[0, 3, 1] == true && mbarr3[0, 7, 1] == true && mbarr3[0, 11, 1] == true && mbarr3[0, 15, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt dritte Reihe vertikal Player two");
                }
                if (mbarr3[0, 0, 0] == true && mbarr3[0, 5, 0] == true && mbarr3[0, 10, 0] == true && mbarr3[0, 15, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt one Diagonal");
                }
                else if (mbarr3[0, 0, 1] == true && mbarr3[0, 5, 1] == true && mbarr3[0, 10, 1] == true && mbarr3[0, 15, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt two diagonal");
                }
                if (mbarr3[0, 3, 0] == true && mbarr3[0, 6, 0] == true && mbarr3[0, 9, 0] == true && mbarr3[0, 12, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt one diagonal");
                }
                else if (mbarr3[0, 3, 1] == true && mbarr3[0, 6, 1] == true && mbarr3[0, 9, 1] == true && mbarr3[0, 12, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt Green diagonal");
                }
                if (mbarr3[0, 0, 0] == true && mbarr3[0, 4, 0] == true && mbarr3[0, 8, 0] == true && mbarr3[0, 12, 0] == true)
                {
                    MessageBox.Show("Vier gewinnt Player one erste Reihe vertikal");
                }
                else if (mbarr3[0, 0, 0] == true && mbarr3[0, 4, 1] == true && mbarr3[0, 8, 1] == true && mbarr3[0, 12, 1] == true)
                {
                    MessageBox.Show("Vier gewinnt Player two erste Reihe vertikal");
                }

            }
        }
        private void RB1_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                mbarr3[0, 0, 0] = true;
                RB1.Content = Convert.ToString(mbarr3[0, 0, 0]);
                G1.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                G1.Background = System.Windows.Media.Brushes.Green;
                mbarr3[0, 0, 1] = true;
            }
            next();
            chkmbarr2();
        }
        private void RB6_Checked(object sender, RoutedEventArgs e)
        {
            mbarr3[0, 5, 0] = true;
            RB6.Content = Convert.ToString(mbarr3[0, 5, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 5, 0] = true;
                G6.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 5, 1] = true;
                G6.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB2_Checked(object sender, RoutedEventArgs e)
        {
            if (P1.IsChecked == true)
            {
                RB2.Content = Convert.ToString(mbarr3[0, 1, 0]);
                mbarr3[0, 1, 0] = true;
                G2.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 1, 1] = true;
                G2.Background = System.Windows.Media.Brushes.Green;
                RB2.Content = Convert.ToString(mbarr3[0, 1, 1]);
            }
            next();
            chkmbarr2();
        }
        private void RB33_Checked(object sender, RoutedEventArgs e)
        {
            RB33.Content = Convert.ToString(mbarr3[0, 2, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 2, 0] = true;
                G3.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 2, 1] = true;
                G3.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB4_Checked(object sender, RoutedEventArgs e)
        {
            RB4.Content = Convert.ToString(mbarr3[0, 3, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 3, 0] = true;
                G4.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 3, 1] = true;
                G4.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB5_Checked(object sender, RoutedEventArgs e)
        {
            RB5.Content = Convert.ToString(mbarr3[0, 4, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 4, 0] = true;
                G5.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 4, 1] = true;
                G5.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }

        private void RB7_Checked(object sender, RoutedEventArgs e)
        {
            RB7.Content = Convert.ToString(mbarr3[0, 6, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 6, 0] = true;
                G7.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 6, 1] = true;
                G7.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB8_Checked(object sender, RoutedEventArgs e)
        {
            RB8.Content = Convert.ToString(mbarr3[0, 7, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 7, 0] = true;
                G8.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 7, 1] = true;
                G8.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }

        private void RB9_Checked(object sender, RoutedEventArgs e)
        {
            RB9.Content = Convert.ToString(mbarr3[0, 8, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 8, 0] = true;

                G9.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 8, 1] = true;
                G9.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }

        private void RB10_Checked(object sender, RoutedEventArgs e)
        {
            RB10.Content = Convert.ToString(mbarr3[0, 9, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 9, 0] = true;
                G10.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 9, 1] = true;
                G10.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB11_Checked(object sender, RoutedEventArgs e)
        {
            RB11.Content = Convert.ToString(mbarr3[0, 10, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 11, 0] = true;
                G11.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 10, 1] = true;
                G11.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }

        private void RB12_Checked(object sender, RoutedEventArgs e)
        {
            RB12.Content = Convert.ToString(mbarr3[0, 11, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 11, 0] = true;
                G12.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 11, 1] = true;
                G12.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB13_Checked(object sender, RoutedEventArgs e)
        {
            RB13.Content = Convert.ToString(mbarr3[0, 12, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 12, 0] = true;
                G13.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 12, 1] = true;
                G13.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }

        private void RB14_Checked(object sender, RoutedEventArgs e)
        {
            RB14.Content = Convert.ToString(mbarr3[0, 13, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 13, 0] = true;
                G14.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 13, 1] = true;
                G14.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB15_Checked(object sender, RoutedEventArgs e)
        {
            RB15.Content = Convert.ToString(mbarr3[0, 14, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 14, 0] = true;
                G15.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 14, 1] = true;
                G15.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }
        private void RB16_Checked(object sender, RoutedEventArgs e)
        {
            RB16.Content = Convert.ToString(mbarr3[0, 15, 0]);
            if (P1.IsChecked == true)
            {
                mbarr3[0, 15, 0] = true;
                G16.Background = System.Windows.Media.Brushes.Red;
            }
            else if (P2.IsChecked == true)
            {
                mbarr3[0, 15, 1] = true;
                G16.Background = System.Windows.Media.Brushes.Green;
            }
            next();
            chkmbarr2();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(mbarr3[0, 0, 0]));

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
