using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfLab_8_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight == FontWeights.UltraBold)
                {
                    textBox.FontWeight = FontWeights.Normal;
                }
                else
                {
                    textBox.FontWeight = FontWeights.UltraBold;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontStyle == FontStyles.Italic)
                {
                    textBox.FontStyle = FontStyles.Normal;
                }
                else
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.TextDecorations == TextDecorations.Baseline)
                {
                    textBox.TextDecorations = null;
                }
                else
                {
                    textBox.TextDecorations = TextDecorations.Baseline;
                }
            }
        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = new SolidColorBrush(Colors.Red);
            }
        }
        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Teкстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt| Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }
    }
}
