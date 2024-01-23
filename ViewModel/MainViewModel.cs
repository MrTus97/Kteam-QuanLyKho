using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKhoKteam.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        // Mọi thứ xử lý sẽ nằm trong class này
        public bool isLoaded = false;

        public ICommand LoadedWindowCommand { get; set; }
        public MainViewModel() {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                isLoaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            });
            
        }
    }
}
