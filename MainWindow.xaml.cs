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

using gui_calc.Class;

namespace gui_calc
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private GuiInterface ui = new GuiInterface();

		// button click action
		private void NumberClick(object sender, RoutedEventArgs e)
		{
			// get the content of the button
			var content = (sender as Button).Content;
			// update the number box
			CurrentNumber.Text = ui.NumberAdd((string)content);
			CurrentCalculation.Text = ui.GetEquation();
		}
		private void OperatorClick(object sender, RoutedEventArgs e)
		{
			// get the content of the button
			var content = (sender as Button).Content;
			// update the current calculation box and the number box
			CurrentCalculation.Text = ui.OperatorAdd((string)content);
			CurrentNumber.Text = ui.GetNumString();

			// if "=" is entered, add it to the listbox
			if ((string)content == "=")
			{
				ListBoxItem newItem = new ListBoxItem();
				newItem.Content = new TextBlock
				{
					Text = ui.GetEquation() + ui.GetNumString(),
					TextWrapping = TextWrapping.Wrap,
					TextAlignment = TextAlignment.Right,
					Width = 240,
					Padding = new Thickness(5, 5, 5, 5)
				};
				CalculationHistory.Items.Insert(0, newItem);
			}
		}
		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
