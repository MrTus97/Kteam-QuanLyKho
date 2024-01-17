using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyKhoKteam.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        // Mọi thứ xử lý sẽ nằm trong class này

        public MainViewModel() {
            MessageBox.Show("Đã vào trong MainViewModel -> Data context của mainwindow.xaml");
        }
    }
}
