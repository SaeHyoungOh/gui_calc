using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gui_calc.Class
{
	class GuiInterface
	{
		private string numString = "";
		private bool decimalUsed = false;

		private void PlusMinus()
		{

		}

		private void Decimal()
		{

		}

		public string NumberAdd(string sender)
		{
			if (sender == "+/-")
			{

			}
			else
			{
				numString += sender;
			}

			return numString;
		}
		public string OperatorAdd(string sender)
		{
			if (sender == "+/-")
			{

			}
			else
			{
				numString += sender;
			}

			return numString;
		}
	}
}
