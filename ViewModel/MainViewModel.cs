﻿using System;
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

        public ICommand UnitCommand { get; set; } 

        public ICommand SuplierCommand { get; set; }

        public ICommand CustomerCommand { get; set; }

        public ICommand ObjectCommmand { get; set; }

        public ICommand UserCommand { get; set; }

        public ICommand InputCommand { get; set; }

        public ICommand OutputCommand { get; set; }
        public MainViewModel() {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                isLoaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            });

            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                UnitWindow wd = new UnitWindow();
                wd.ShowDialog();
            });

            SuplierCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SuplierWindow wd = new SuplierWindow();
                wd.ShowDialog();
            });

            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                CustomerWindow wd = new CustomerWindow();
                wd.ShowDialog();
            });
            ObjectCommmand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ObjectWindow wd = new ObjectWindow();
                wd.ShowDialog();
            });
            UserCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                UserWindow wd = new UserWindow();
                wd.ShowDialog();
            });
            InputCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                InputWindow wd = new InputWindow();
                wd.ShowDialog();
            });

            OutputCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OutputWindow wd = new OutputWindow();
                wd.ShowDialog();
            });
        }
    }
}
