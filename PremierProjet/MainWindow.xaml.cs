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

namespace PremierProjet
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnValide_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (label2 != null)
				label2.Content = ((int)Slider1.Value).ToString();

		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			if (listBox1.SelectedIndex == -1)
				MessageBox.Show("Choisissez une nationalité", "Nationalité", MessageBoxButton.OK, MessageBoxImage.Error);
			else
			{
				string resume = textBox2.Text + " " + textBox1.Text;
				resume += " de sexe " + (radioButton1.IsChecked == true ? "masculin" : "féminin");
				resume += " né" + (radioButton1.IsChecked == true ? "" : "e")
					+ " en " + ((int)Slider1.Value).ToString();
				resume += " de nationalité " + ((ListBoxItem)listBox1.SelectedItem).Content;
				MessageBox.Show(resume);
			}

		}

		private void button2_Click(object sender, RoutedEventArgs e)
			{
				Slider1.Value = Slider1.Minimum;
				textBox1.Text = "Votre nom";
				textBox2.Text = "Votre Prénom";
				radioButton1.IsChecked = true;
				listBox1.SelectedIndex = -1; //déselection
		}
		public object ConvertBack(object value, Type targetType, object parameter,System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}