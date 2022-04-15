using System;
using System.Drawing;
using System.Windows.Forms;


namespace ELTE_Szimulacio_10_Heterogen_kondenzacio
{
	class Felho
	{
		private int N;
		private int M;
		private decimal BV;
		private decimal BK;
		private int T;
		private Bitmap bmp;
		private PictureBox pb;
		private int[,] Tér;
		private Random r;

		public Felho(int N, int M, decimal BV, decimal BK, int T, PictureBox pb)
		{
			this.N = N;
			this.M = M;
			this.BV = BV;
			this.BK = BK;
			this.T = T;
			this.pb = pb;
			this.pb.Size = new Size(N, M);
			this.bmp = new Bitmap(N,M);
			this.pb.Image = bmp;
			this.Tér = new int[N,M];
			this.r = new Random();
		}
		public void Lépés()
		{
			Point P = Véletlen_hely();
			Point Q = Véletlen_szomszéd_fel(P);

			if (P.X == N+1)
			{
				Belépés(Q);
			}
			else if (P.X == 1)
			{
				Kilépés(P);
			}
			else
			{
				Mozgás(P, Q);
			}
		}

		private void Belépés(Point q)
		{
			throw new NotImplementedException();
		}

		private void Kilépés(Point p)
		{
			throw new NotImplementedException();
		}


		private void Mozgás(Point p, Point q)
		{
			throw new NotImplementedException();
		}

		private Point Véletlen_szomszéd_fel(Point p)
		{
			throw new NotImplementedException();
		}

		private Point Véletlen_hely()
		{
			throw new NotImplementedException();
		}
	}
}