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
		Felho felhő;
		public Form1()
		{
			InitializeComponent();
			Ujfelho();
		}

		private void btn_uj_Click(object sender, EventArgs e) => Ujfelho();

		private void Ujfelho() => felhő = new Felho(nud_N.Value, nud_M.Value, nud_BV.Value, nud_BK.Value, nud_T.Value, pb);
		

		private void btn_start_Click(object sender, EventArgs e) => felhő.Start();

		private void btn_stop_Click(object sender, EventArgs e) => felhő.Stop();

		private void btn_lep_Click(object sender, EventArgs e) => felhő.Lépés();
	}
}
