using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double n1, n2, rs;
        string pro="";
        
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_min_Copy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        

      

        private void btn_min_Copy_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_min_Copy.Content = "Close";

        }

        private void btn_po(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                n1 = Convert.ToDouble(lb_result.Content);
                pro = btn.Content.ToString();
                lb_cal.Content = lb_cal.Content.ToString() + btn.Content;
                lb_result.Content = "";

            }
            catch { }
           


        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                n2 = Convert.ToDouble(lb_result.Content);
                if (pro == "+")
                {
                    rs = n1 + n2;
                    lb_result.Content = rs.ToString();
                }
                else if (pro == "-")
                {
                    rs = n1 - n2;
                    lb_result.Content = rs.ToString();
                }
                else if (pro == "*")
                {
                    rs = n1 * n2;
                    lb_result.Content = rs.ToString();
                }
                else if (pro == "/")
                {
                    rs = n1 / n2;
                    lb_result.Content = rs.ToString();
                }
                lb_cal.Content = lb_result.Content;
            }
            catch { }
          
           
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            lb_result.Content = "";
            lb_cal.Content = "";
            n1 = n2 = rs = 0;
            pro="";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                this.MouseDown += delegate
                {
                    DragMove();

                };

            }
            catch { }
        }

        private void btn_min_Copy_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_min_Copy.Content = "";

        }

        private void btn_number(object sender, RoutedEventArgs e)
        {
            try
            {

                Button btn = (Button)sender;
                if (lb_result.Content.ToString() == "0")
                {
                    lb_result.Content = "";
                    lb_result.Content = lb_result.Content.ToString() + btn.Content;
                    lb_cal.Content = lb_result.Content;

                }
                else
                {
                    if (pro == "")
                    {
                        lb_result.Content = lb_result.Content.ToString() + btn.Content;
                        lb_cal.Content = lb_result.Content;
                    }
                    else
                    {
                        lb_result.Content = lb_result.Content.ToString() + btn.Content;

                    }
                }
            }
            catch  { }
            

        }
    }
}
