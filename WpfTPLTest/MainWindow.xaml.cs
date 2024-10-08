using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfTPLTest
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
        private async void btnClick_Click(object sender, RoutedEventArgs e)
        {
            //Task<int> myTask = new Task<int>(() => { return CalcTotal(20, "first"); });
            //myTask.Start();
            //myTask.Wait();  //<-- result
            //MessageBox.Show($"Result2 is {myTask.Result}");

            //Task<int> myTask2 = new Task<int>(() => { return CalcTotal(20, "first"); });
            //myTask2.Start();
            //myTask2.Wait();  //<-- result

            //MessageBox.Show($"Result is {myTask2.Result}");





            //int myTask = CalcTotal(20, "third");
            //int myTask2 = CalcTotal(20, "third");
            //MessageBox.Show($"Result2 is {myTask2}");
            //MessageBox.Show($"Result is {myTask}");

            //int myTask = await CalcTotal(20, "third");
            //int myTask2 = await CalcTotal(20, "third");
            //MessageBox.Show($"Result2 is {myTask2}");
            //MessageBox.Show($"Result is {myTask}");

            var res = Task.WhenAll(
                CalcTotal(20, "third"),
                CalcTotal(20, "third"));

        }
        private async Task<int> CalcTotal(int cnt, string info)
        {
            int total = 0;

            for (int i = 0; i < cnt; i++)
            {
                await Task.Delay(200);
                //Thread.Sleep(200);

                total += (int)Math.Pow(i, 2);

                System.Diagnostics.Debug.WriteLine($"{info}:{total}");
            }

            return total;
        }

        private void btnDoStuff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dostuff");
        }
    }

    
}
