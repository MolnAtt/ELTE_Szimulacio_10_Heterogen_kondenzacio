using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELTE_Szimulacio_10_Heterogen_kondenzacio
{
	public partial class Form1 : Form
	{
		Felho f;
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_uj_Click(object sender, EventArgs e)
		{
			int N = (int)nud_N.Value;
			int M = (int)nud_M.Value;
			decimal BV = nud_BV.Value;
			decimal BK = nud_BK.Value;
			int T = (int)nud_T.Value;
			f = new Felho(N, M, BV, BK, T, pb);
		}
	}
}
