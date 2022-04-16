
namespace ELTE_Szimulacio_10_Heterogen_kondenzacio
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pb = new System.Windows.Forms.PictureBox();
			this.nud_N = new System.Windows.Forms.NumericUpDown();
			this.nud_M = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nud_BV = new System.Windows.Forms.NumericUpDown();
			this.nud_BK = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.nud_T = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_stop = new System.Windows.Forms.Button();
			this.btn_lep = new System.Windows.Forms.Button();
			this.debuglabel = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btn_uj = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_N)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_M)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_T)).BeginInit();
			this.SuspendLayout();
			// 
			// pb
			// 
			this.pb.BackColor = System.Drawing.Color.Black;
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb.Location = new System.Drawing.Point(50, 50);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(400, 400);
			this.pb.TabIndex = 0;
			this.pb.TabStop = false;
			// 
			// nud_N
			// 
			this.nud_N.Location = new System.Drawing.Point(752, 97);
			this.nud_N.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
			this.nud_N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_N.Name = "nud_N";
			this.nud_N.Size = new System.Drawing.Size(54, 23);
			this.nud_N.TabIndex = 1;
			this.nud_N.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// nud_M
			// 
			this.nud_M.Location = new System.Drawing.Point(752, 68);
			this.nud_M.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
			this.nud_M.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_M.Name = "nud_M";
			this.nud_M.Size = new System.Drawing.Size(54, 23);
			this.nud_M.TabIndex = 2;
			this.nud_M.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(660, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "magasság: N =";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(663, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "szélesség: M =";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(812, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "in [1..400]";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(812, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "in [1..400]";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(523, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(223, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "vízmolekula belépési valószínűsége: BV =";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(487, 159);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(259, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "kondenzációs mag belépési valószínűsége: BK =";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_BV
			// 
			this.nud_BV.DecimalPlaces = 2;
			this.nud_BV.Location = new System.Drawing.Point(752, 126);
			this.nud_BV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_BV.Name = "nud_BV";
			this.nud_BV.Size = new System.Drawing.Size(54, 23);
			this.nud_BV.TabIndex = 9;
			this.nud_BV.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// nud_BK
			// 
			this.nud_BK.DecimalPlaces = 2;
			this.nud_BK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nud_BK.Location = new System.Drawing.Point(752, 157);
			this.nud_BK.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_BK.Name = "nud_BK";
			this.nud_BK.Size = new System.Drawing.Size(54, 23);
			this.nud_BK.TabIndex = 10;
			this.nud_BK.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(812, 128);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "in [0;1]";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(812, 159);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 15);
			this.label8.TabIndex = 12;
			this.label8.Text = "in [0;1]";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_T
			// 
			this.nud_T.Location = new System.Drawing.Point(752, 186);
			this.nud_T.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_T.Name = "nud_T";
			this.nud_T.Size = new System.Drawing.Size(54, 23);
			this.nud_T.TabIndex = 13;
			this.nud_T.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(649, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 15);
			this.label9.TabIndex = 14;
			this.label9.Text = "Hőmérséklet: T =";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(812, 188);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 15);
			this.label10.TabIndex = 15;
			this.label10.Text = "in [1..100]";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(156, 456);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(84, 24);
			this.btn_start.TabIndex = 16;
			this.btn_start.Text = "START";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// btn_stop
			// 
			this.btn_stop.Location = new System.Drawing.Point(261, 456);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(84, 24);
			this.btn_stop.TabIndex = 17;
			this.btn_stop.Text = "STOP";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// btn_lep
			// 
			this.btn_lep.Location = new System.Drawing.Point(366, 456);
			this.btn_lep.Name = "btn_lep";
			this.btn_lep.Size = new System.Drawing.Size(84, 24);
			this.btn_lep.TabIndex = 18;
			this.btn_lep.Text = "LÉPTET";
			this.btn_lep.UseVisualStyleBackColor = true;
			this.btn_lep.Click += new System.EventHandler(this.btn_lep_Click);
			// 
			// debuglabel
			// 
			this.debuglabel.BackColor = System.Drawing.Color.White;
			this.debuglabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.debuglabel.Location = new System.Drawing.Point(487, 230);
			this.debuglabel.Name = "debuglabel";
			this.debuglabel.Size = new System.Drawing.Size(383, 220);
			this.debuglabel.TabIndex = 19;
			this.debuglabel.Text = "debugablak";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(169, 15);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(152, 32);
			this.label12.TabIndex = 20;
			this.label12.Text = "Megjelenítés";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_uj
			// 
			this.btn_uj.Location = new System.Drawing.Point(50, 456);
			this.btn_uj.Name = "btn_uj";
			this.btn_uj.Size = new System.Drawing.Size(84, 24);
			this.btn_uj.TabIndex = 21;
			this.btn_uj.Text = "Új";
			this.btn_uj.UseVisualStyleBackColor = true;
			this.btn_uj.Click += new System.EventHandler(this.btn_uj_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 511);
			this.Controls.Add(this.btn_uj);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.debuglabel);
			this.Controls.Add(this.btn_lep);
			this.Controls.Add(this.btn_stop);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.nud_T);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nud_BK);
			this.Controls.Add(this.nud_BV);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nud_M);
			this.Controls.Add(this.nud_N);
			this.Controls.Add(this.pb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_N)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_M)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_T)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.NumericUpDown nud_N;
		private System.Windows.Forms.NumericUpDown nud_M;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nud_BV;
		private System.Windows.Forms.NumericUpDown nud_BK;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nud_T;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.Button btn_lep;
		private System.Windows.Forms.Label debuglabel;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btn_uj;
	}
}

