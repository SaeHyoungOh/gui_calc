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
		private List<Calculation> calc = new List<Calculation>();
		private List<char> allowedOper = new List<char>() { '+', '-', '*', '/', '=' };
		private int histIndex = 0;

		// button click action
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// get the content of the button
			var content = (sender as Button).Content;
			// update the number box
			CurrentNumber.Text = ui.ClickAction((string)content);

		}
		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
