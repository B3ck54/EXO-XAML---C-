using System;

namespace PremierProjet
{

	public partial class MainWindow : Window
	{
		public class ConversionDoubleEntier : IValueConverter
		{
			public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
			{
				if (value != null)
				{
					double dblValue = (double)value;
					return (int)dblValue;
				}
				return 0;
			}
			// obligation d'interface d'implémenter aussi la méthode ConvertBack

			public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
			{
				throw new NotImplementedException();
			}


					
			
		}
	}
}