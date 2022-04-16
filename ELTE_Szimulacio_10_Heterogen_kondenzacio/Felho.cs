using System;
using System.Drawing;
using System.Windows.Forms;


namespace ELTE_Szimulacio_10_Heterogen_kondenzacio
{
	class Felho
	{
		private int H;
		private int W;
		private double BV;
		private double BK;
		private int T;
		private Bitmap bmp;
		private PictureBox pb;
		private int[,] Tér;
		private Random r;
		private bool fut;

		public Felho(decimal H, decimal W, decimal BV, decimal BK, decimal T, PictureBox pb)
		{
			this.H = (int)H;
			this.W = (int)W;
			this.BV = (double)BV;
			this.BK = (double)BK;
			this.T = (int)T;
			this.pb = pb;
			this.pb.Size = new Size(this.W, this.H);
			this.bmp = new Bitmap(this.W, this.H);
			this.pb.Image = bmp;
			this.Tér = new int[this.W, this.H];
			this.r = new Random();
			this.fut = false;

			for (int x = 0; x < W; x++)
				for (int y = 0; y < H; y++)
					bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
		}
		internal void Stop()
		{
			fut = false;			
		}
		internal void Start()
		{
			fut = true;
			Futás();
		}
		private bool Csepp(Point P) => Tér[P.X, P.Y] > 1;
		private bool Vizes(Point P) => Tér[P.X, P.Y] != 0;
		private void Futás()
		{
			while (fut)
			{
				Lépés();
				Application.DoEvents(); // ki a loopból?
			}
		}
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
			pb.Refresh();
		}

		private void Belépés(Point P)
		{
			if (r.NextDouble()<BV)
			{
				Tér[P.X, P.Y]++;
				Fest(P);
			}
		}

		private void Kilépés(Point P)
		{
			Tér[P.X, P.Y] = 0;
			Fest(P);
		}


		private void Mozgás(Point P, Point Q)
		{
			if (Csepp(P))
				Párolgás(P);
			else if (Vizes(P))
				Felfelé(P, Q);
		}

		private void Felfelé(Point P, Point Q)
		{
			if (!(Csepp(P) && Csepp(Q)))
			{
				Tér[Q.X, Q.Y] += Tér[P.X, P.Y];
				Kilépés(P);
				Fest(P);
				Fest(Q);
			}
		}

		private void Fest(Point P) => bmp.SetPixel(P.X, P.Y, Festőszín(Tér[P.X,P.Y]));
		private Color Festőszín(int v) => Festőszín_from_rg(v > 25 ? 0 : 255 - 10 * v);
		private Color Festőszín_from_rg(int c) => Color.Blue;
		// private Color Festőszín_from_rg(int c) => Color.FromArgb(c, c, 255);



		private void Egyet_Felfelé(Point P, Point Q)
		{
			if (Csepp(P))
			{
				Tér[Q.X, Q.Y]++;
				Tér[P.X, Q.Y]--;
				Fest(P);
				Fest(Q);
			}
		}

		private void Párolgás(Point P)
		{
			if (r.NextDouble()< PÁROL(T, P))
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
		private double PÁROL(int T, Point P) => ((0.005 * (double)T) + 0.5 * (Tér[P.X, P.Y] == 0 ? 1 : 1 / Tér[P.X, P.Y]));
		private Point Véletlen_szomszéd_fel(Point P) => new Point(P.X + r.Next(Min_X(ref P), Max_X(ref P) + 1), P.Y - 1);
		private int Min_X(ref Point P) => P.X == 0 ? 0 : -1;
		private int Max_X(ref Point P) => P.X == W - 1 ? 0 : 1;
		private Point Véletlen_hely() => new Point(r.Next(W), r.Next(H + 1));
	}
}