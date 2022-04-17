using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ELTE_Szimulacio_10_Heterogen_kondenzacio
{
	class Felho
	{
		private int l;
		private int H;
		private int W;
		private double BV;
		private double BK;
		private double BVBK;
		private int T;
		private int C;
		private Bitmap bmp;
		private PictureBox pb;
		private PictureBox pb_ido;
		private PictureBox pb_reteg;
		private TextBox tb_l;
		private CheckBox chb_cs;
		private CheckBox chb_matrix;
		private Label lab_matrix;
		private float[,] Tér;
		private Random r;
		private bool fut;
		private int[] víz_rétegenként;
		private List<int> ido_grafikon;
		private Pen toll;
		int résztömeg;
		int utolsó_regisztrált_lépés;



		private bool Csendes { get => chb_cs.Checked; }

		public Felho(decimal H, decimal W, decimal BV, decimal BK, decimal T, decimal C, TextBox tb_l, CheckBox chb_cs, CheckBox chb_matrix, Label lab_matrix, PictureBox pb, PictureBox pb_ido, PictureBox pb_reteg)
		{
			this.H = (int)H;
			this.W = (int)W;
			this.BV = (double)BV;
			this.BK = (double)BK;
			this.BVBK = this.BV+this.BK;
			this.T = (int)T;
			this.C = 255/(int)C;
			this.pb = pb;
			this.pb_ido = pb_ido;
			this.pb_reteg = pb_reteg;
			pb_reteg.Size = new Size(pb_reteg.Size.Width, this.H);
			this.pb.Size = new Size(this.W, this.H);
			this.bmp = new Bitmap(this.W, this.H);
			this.pb.Image = bmp;
			this.Tér = new float[this.W, this.H];
			this.r = new Random();
			this.fut = false;
			this.l = 0;
			this.tb_l = tb_l;
			this.chb_cs = chb_cs;
			this.chb_matrix = chb_matrix;
			this.lab_matrix = lab_matrix;
			víz_rétegenként = new int[this.H];
			ido_grafikon = new List<int>();
			résztömeg = 0;
			utolsó_regisztrált_lépés = 0;
			PictureBox_Törlése();
			tb_l.Text = l.ToString();
			toll = new Pen(Color.Black);

			if (chb_matrix.Checked)
			{
				lab_matrix.Text = Tér_ToString();
			}
		}
		private void PictureBox_Törlése()
		{
			for (int x = 0; x < W; x++)
				for (int y = 0; y < H; y++)
					bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
		}
		private void SetVíz(Point P, float v) => Tér[P.X, P.Y] = v;
		private void AddVíz(Point P, float v) => Tér[P.X, P.Y] += v;
		private float GetVíz(Point P) => Tér[P.X, P.Y];
		private float GetCsakVíz(Point P) => Tiszta(P) ? Tér[P.X, P.Y] : Tér[P.X, P.Y] - 0.3f;
		private bool Vizesebb(Point P) => GetVíz(P) > 1;
		private bool Vizes(Point P) => GetVíz(P) >= 1;
		private bool Tiszta(Point p) => GetVíz(p) % 1 == 0;
		
		public void Stop() => fut = false;			
		public void Start()
		{
			fut = true;
			Futás();
		}
		/// <summary>
		/// A ciklus, ami a szimulációs lépéseket futtatja.
		/// </summary>
		private void Futás()
		{
			while (fut)
			{
				Application.DoEvents(); // Ahhoz kell, hogy ki lehessen kattintani az ablakból. Async-awaitre majd át kellene írni. 
				Lépés();
			}
		}
		/// <summary>
		/// Szimulációs lépés.
		/// </summary>
		public void Lépés()
		{
			Point P = Véletlen_hely();
			Point Q = Véletlen_szomszéd_fel(P);

			if (P.Y == H)
				Belépés(Q);
			else if (P.Y == 0)
				Kilépés(P);
			else
				Mozgás(P, Q);

			++l;
			Form_frissítése();
		}

		/// <summary>
		/// frissíti a pictureboxokat és a labeleket. Csendes üzemmódban lényegében ez van kikapcsolva.
		/// </summary>
		private void Form_frissítése()
		{
			if (!Csendes)
			{
				pb.Refresh();
				tb_l.Text = l.ToString();
				Fest_Idő();
				Fest_Réteg();
			}
			if (!chb_matrix.Checked)
			{
				lab_matrix.Text = Tér_ToString();
			}
		}

		private void Fest_Réteg()
		{
			pb_reteg.Image = new Bitmap(pb_reteg.Width, pb_reteg.Height);
			Graphics g = Graphics.FromImage(pb_reteg.Image);
			for (int y = H-1; y >=0; y--)
			{
				g.DrawLine(toll, new Point(0,y), new Point(víz_rétegenként[y], y));
			}
			pb_reteg.Refresh();
		}

		private void Fest_Idő()
		{
			int w = pb_ido.Width;
			int h = pb_ido.Height;
			pb_ido.Image = new Bitmap(w, h);
			Graphics g = Graphics.FromImage(pb_ido.Image);
			for (int x = 0; x < ido_grafikon.Count; x++)
			{
				g.DrawLine(toll, new Point(x, h - 1), new Point(x, h - ido_grafikon[x] / 100 - 1));
			}
			pb_ido.Refresh();
		}

		/// <summary>
		/// stringet készít a mátrixból, amit így meg lehet jeleníteni.
		/// </summary>
		/// <returns></returns>
		private string Tér_ToString()
		{
			string s = "";
			for (int j = 0; j < H; j++)
			{
				for (int i = 0; i < W; i++)
				{
					s += Tér[i, j].ToString("00.0")+" ";
				}
				s += "\n";
			}
			return s;
		}

		/// <summary>
		/// Megadott valószínűséggel megjelenik 1 víz vagy egy kondenzációs mag a szimulációs tér alján. 
		/// </summary>
		/// <param name="P"></param>
		private void Belépés(Point P)
		{
			double véletlen = r.NextDouble();
			if (véletlen<BV)
			{
				AddVíz(P,1);
				Idő_grafikonhoz_víztömeg_adminisztrációja(1);
				víz_rétegenként[H-1] += 1;
				Fest(P);
			}
			else if (véletlen < BVBK)
			{
				AddKondenzációsMag(P);
				Fest(P);
			}
		}

		/// <summary>
		/// 100 lépésenként adminisztrálja a behúzandó vízszintes szakasz magasságát (ez lenne az oszlop a hisztogramban).
		/// </summary>
		/// <param name="v"></param>
		private void Idő_grafikonhoz_víztömeg_adminisztrációja(int v)
		{
			résztömeg += v;
			if (100 <= l-utolsó_regisztrált_lépés)
			{
				utolsó_regisztrált_lépés -= 100;
				ido_grafikon.Add(résztömeg);
				résztömeg = 0;
			}
		}

		private void AddKondenzációsMag(Point P)
		{
			if (Tiszta(P))
				AddVíz(P, 0.3f);
		}

		/// <summary>
		/// a kilépő vízmennyiséget törli a szimulációs térből és a grafikonokban adminisztrálja.
		/// </summary>
		/// <param name="P"></param>
		private void Kilépés(Point P)
		{
			int v = (int)GetCsakVíz(P);
			víz_rétegenként[0] -= v;
			Idő_grafikonhoz_víztömeg_adminisztrációja(-v);

			SetVíz(P, 0);

			Fest(P);
		}

		private void Mozgás(Point P, Point Q)
		{
			if (Vizesebb(P))
				Párolgás(P);
			if (Vizes(P))
				Felfelé(P, Q);
		}
		private void Felfelé(Point P, Point Q)
		{
			//if (!(Csepp(P) && Csepp(Q))) // homogén kondenzáció: Itt az előadás diáiban szerintem rossz volt a feltétel
			if (Vizes(P) && Vizes(Q)) // heterogén kondenzáció: Megint nem igazán értem az előadás diáiban szereplő feltételt.
			{
				if (Tiszta(P) || Tiszta(Q))
					AddVíz(Q, GetVíz(P));
				else
					AddVíz(Q, GetCsakVíz(P));
				Rétegből_felmegy(P.Y, (int)GetCsakVíz(P));
				Kilépés(P);
				Fest(P);
				Fest(Q);
			}
		}

		private void Rétegből_felmegy(int y, int v)
		{
			víz_rétegenként[y] -= v;
			víz_rétegenként[y - 1] += v;
		}

		private void Fest(Point P)
		{
			if (!Csendes)
			{
				if (Tiszta(P))
					bmp.SetPixel(P.X, P.Y, Szín_tiszta(Nbe(255 - C * (int)GetVíz(P))));
				else
					bmp.SetPixel(P.X, P.Y, Szín_koszos(Nbe(255 - C * (int)GetCsakVíz(P))));
			}
		}
		private int Nbe(int a) => a < 0 ? 0 : a;
		private Color Szín_tiszta(int c) => Color.FromArgb(c, c, 255);
		private Color Szín_koszos(int c) => Color.FromArgb(255, c, 255);
		private void Egyet_Felfelé(Point P, Point Q)
		{
			if (Vizes(P))
			{
				AddVíz(Q, 1);
				Rétegből_felmegy(P.Y, 1);
				AddVíz(P, -1);
				Fest(P);
				Fest(Q);
			}
		}
		private void Párolgás(Point P)
		{
			if (r.NextDouble() < (Tiszta(P) ? PÁROL(T, P) : SZPÁROL(T, P)))
				Egyet_Felfelé(P, Véletlen_szomszéd_fel(P));
		}



		/// <summary>
		/// Saját képlet: A hőmérséklet mint százalék és a cseppmennyiségből összekalapált [0..100] közé eső képlet úgy, hogy 
		/// - minél melegebb van, annál jobban párologjon.
		/// - minél nagyobb a csepp, annál jobban párologjon.
		/// több tudomány nincs benne.
		/// </summary>
		/// <param name="T"></param>
		/// <param name="P"></param>
		/// <returns></returns>
		private double PÁROL(int T, Point P) => ((0.005 * (double)T) + 0.5 * (GetVíz(P) == 0 ? 1 : 1 / GetVíz(P)));
		/// <summary>
		/// Nem tudom, hogy milyen dinamika szerint párolog a kondenzációs maggal bíró vízcsepp a simához képest. Jobban, rosszabbul? Maradtam ugyanannál.
		/// </summary>
		/// <param name="T"></param>
		/// <param name="P"></param>
		/// <returns></returns>
		private double SZPÁROL(int T, Point P) => PÁROL(T, P);
		private Point Véletlen_szomszéd_fel(Point P) => new Point(P.X + r.Next(Min_X(ref P), Max_X(ref P) + 1), P.Y - 1);
		private int Min_X(ref Point P) => P.X == 0 ? 0 : -1;
		private int Max_X(ref Point P) => P.X == W - 1 ? 0 : 1;
		private Point Véletlen_hely() => new Point(r.Next(W), r.Next(H + 1));
	}
}