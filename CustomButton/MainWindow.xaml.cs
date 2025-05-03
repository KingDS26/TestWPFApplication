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

namespace CustomButton
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //按钮点击事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 10, b = 20;
            int c = a + b;
            ShowTextBox.Text = c.ToString();
        }

        //鼠标指针移入
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            ShowTextBox.Text = "move in";
        }

        //鼠标指针移出
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            ShowTextBox.Text = "move out";
        }
    }
}
