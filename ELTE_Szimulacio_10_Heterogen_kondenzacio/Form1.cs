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
		Control[] kezelők;
		public Form1()
		{
			InitializeComponent();
			Ujfelho();
			kezelők = new Control[] { 
				btn_lep, 
				btn_start, 
				btn_stop, 
				btn_uj, 
				nud_BK, 
				nud_BV, 
				nud_C, 
				nud_M, 
				nud_N, 
				nud_T, 
				chb_cs, 
				chb_matrix 
			};
			Kezelőfelület_megnyitása();
		}

		private void btn_uj_Click(object sender, EventArgs e) => Ujfelho();

		private void Ujfelho()
		{
			felhő = new Felho(
				nud_N.Value, 
				nud_M.Value, 
				nud_BV.Value, 
				nud_BK.Value, 
				nud_T.Value, 
				nud_C.Value, 
				tb_l,
				chb_cs,
				chb_matrix,
				lab_matrix,
				pb,
				pb_ido,
				pb_reteg
				);
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			Kezelőfelület_zárolása();
			felhő.Start();
		}

		private void btn_stop_Click(object sender, EventArgs e)
		{
			felhő.Stop();
			Kezelőfelület_megnyitása();
		}

		private void btn_lep_Click(object sender, EventArgs e) => felhő.Lépés();
		private void Kezelőfelület_zárolása()
		{
			foreach (Control kezelő in kezelők)
				kezelő.Enabled = kezelő == btn_stop || kezelő == chb_matrix || kezelő == chb_cs;
		}

		private void Kezelőfelület_megnyitása()
		{
			foreach (Control kezelő in kezelők)
				kezelő.Enabled = kezelő != btn_stop;
		}


	}
}
