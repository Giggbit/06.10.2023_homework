﻿using System;
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

namespace _06._10._2023_Свойства_зависимостей_и_маршрутизируемые_события
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
            int sum = Convert.ToInt32(textBox.Text);
            if(sum > 0) {
                slider.Maximum = sum * 2;
            }
        }
    }
}
