using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		/// <summary>
		/// 
		/// </summary>
		private GuiInterface ui = new GuiInterface();

		/// <summary>
		/// 
		/// </summary>
		public ObservableCollection<string> HistoryList { get; set; } = new ObservableCollection<string>();

		// button click action
		private void NumberClick(object sender, RoutedEventArgs e)
		{
			// get the content of the button
			var content = (sender as Button).Content;
			// update the number box
			ui.NumberAdd((string)content);
		}

		private void OperatorClick(object sender, RoutedEventArgs e)
		{
			// get the content of the button
			var content = (sender as Button).Content;
			// update the current calculation box and the number box
			ui.OperatorAdd((string)content);
		}

		public MainWindow()
		{
			InitializeComponent();
			DataContext = ui;
		}
	}
}
