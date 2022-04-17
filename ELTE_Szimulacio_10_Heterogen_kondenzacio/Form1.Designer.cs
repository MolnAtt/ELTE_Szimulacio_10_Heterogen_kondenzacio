
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.nud_C = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tb_l = new System.Windows.Forms.TextBox();
			this.chb_cs = new System.Windows.Forms.CheckBox();
			this.lab_matrix = new System.Windows.Forms.Label();
			this.chb_matrix = new System.Windows.Forms.CheckBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.pb_reteg = new System.Windows.Forms.PictureBox();
			this.pb_ido = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_N)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_M)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_T)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_C)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_reteg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_ido)).BeginInit();
			this.SuspendLayout();
			// 
			// pb
			// 
			this.pb.BackColor = System.Drawing.Color.Black;
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb.Location = new System.Drawing.Point(29, 78);
			this.pb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(100, 113);
			this.pb.TabIndex = 0;
			this.pb.TabStop = false;
			// 
			// nud_N
			// 
			this.nud_N.Location = new System.Drawing.Point(606, 137);
			this.nud_N.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.nud_N.Maximum = new decimal(new int[] {
            200,
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
            113,
            0,
            0,
            0});
			// 
			// nud_M
			// 
			this.nud_M.Location = new System.Drawing.Point(606, 108);
			this.nud_M.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.nud_M.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_M.Name = "nud_M";
			this.nud_M.Size = new System.Drawing.Size(54, 23);
			this.nud_M.TabIndex = 2;
			this.nud_M.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(514, 139);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "magasság: N =";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(516, 111);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "szélesség: M =";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(666, 139);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "in [1..200]";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(666, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "in [1..100]";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(376, 227);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(223, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "vízmolekula belépési valószínűsége: BV =";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(342, 258);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(259, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "kondenzációs mag belépési valószínűsége: BK =";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_BV
			// 
			this.nud_BV.DecimalPlaces = 2;
			this.nud_BV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nud_BV.Location = new System.Drawing.Point(606, 225);
			this.nud_BV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
			this.nud_BK.Location = new System.Drawing.Point(606, 256);
			this.nud_BK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
			this.label7.Location = new System.Drawing.Point(666, 227);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "in [0;1]";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(666, 258);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 15);
			this.label8.TabIndex = 12;
			this.label8.Text = "in [0;1]";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_T
			// 
			this.nud_T.Location = new System.Drawing.Point(606, 167);
			this.nud_T.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
			this.label9.Location = new System.Drawing.Point(502, 169);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 15);
			this.label9.TabIndex = 14;
			this.label9.Text = "Hőmérséklet: T =";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(666, 169);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 15);
			this.label10.TabIndex = 15;
			this.label10.Text = "in [1..100]";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(135, 108);
			this.btn_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(84, 24);
			this.btn_start.TabIndex = 16;
			this.btn_start.Text = "START";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// btn_stop
			// 
			this.btn_stop.Location = new System.Drawing.Point(135, 138);
			this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(84, 24);
			this.btn_stop.TabIndex = 17;
			this.btn_stop.Text = "STOP";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// btn_lep
			// 
			this.btn_lep.Location = new System.Drawing.Point(135, 168);
			this.btn_lep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
			this.debuglabel.Location = new System.Drawing.Point(226, 87);
			this.debuglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.debuglabel.Name = "debuglabel";
			this.debuglabel.Size = new System.Drawing.Size(259, 130);
			this.debuglabel.TabIndex = 19;
			this.debuglabel.Text = resources.GetString("debuglabel.Text");
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.Location = new System.Drawing.Point(46, 30);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(173, 32);
			this.label12.TabIndex = 20;
			this.label12.Text = "Szimulációs tér";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_uj
			// 
			this.btn_uj.Location = new System.Drawing.Point(135, 78);
			this.btn_uj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btn_uj.Name = "btn_uj";
			this.btn_uj.Size = new System.Drawing.Size(84, 24);
			this.btn_uj.TabIndex = 21;
			this.btn_uj.Text = "ÚJ";
			this.btn_uj.UseVisualStyleBackColor = true;
			this.btn_uj.Click += new System.EventHandler(this.btn_uj_Click);
			// 
			// nud_C
			// 
			this.nud_C.Location = new System.Drawing.Point(606, 196);
			this.nud_C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.nud_C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_C.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_C.Name = "nud_C";
			this.nud_C.Size = new System.Drawing.Size(54, 23);
			this.nud_C.TabIndex = 22;
			this.nud_C.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(493, 198);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(107, 15);
			this.label11.TabIndex = 23;
			this.label11.Text = "színárnyalatok: C =";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(666, 198);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(52, 15);
			this.label13.TabIndex = 24;
			this.label13.Text = "in [1..10]";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(224, 44);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 15);
			this.label14.TabIndex = 25;
			this.label14.Text = "lépésszám: l = ";
			// 
			// tb_l
			// 
			this.tb_l.Enabled = false;
			this.tb_l.Location = new System.Drawing.Point(314, 42);
			this.tb_l.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tb_l.Name = "tb_l";
			this.tb_l.Size = new System.Drawing.Size(78, 23);
			this.tb_l.TabIndex = 26;
			this.tb_l.Text = "0";
			// 
			// chb_cs
			// 
			this.chb_cs.AutoSize = true;
			this.chb_cs.Location = new System.Drawing.Point(136, 198);
			this.chb_cs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chb_cs.Name = "chb_cs";
			this.chb_cs.Size = new System.Drawing.Size(75, 19);
			this.chb_cs.TabIndex = 27;
			this.chb_cs.Text = "CSENDES";
			this.chb_cs.UseVisualStyleBackColor = true;
			// 
			// lab_matrix
			// 
			this.lab_matrix.AutoSize = true;
			this.lab_matrix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lab_matrix.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lab_matrix.ForeColor = System.Drawing.Color.White;
			this.lab_matrix.Location = new System.Drawing.Point(135, 311);
			this.lab_matrix.Name = "lab_matrix";
			this.lab_matrix.Size = new System.Drawing.Size(79, 13);
			this.lab_matrix.TabIndex = 28;
			this.lab_matrix.Text = "Tér (mátrix)";
			// 
			// chb_matrix
			// 
			this.chb_matrix.AutoSize = true;
			this.chb_matrix.Location = new System.Drawing.Point(135, 289);
			this.chb_matrix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chb_matrix.Name = "chb_matrix";
			this.chb_matrix.Size = new System.Drawing.Size(119, 19);
			this.chb_matrix.TabIndex = 29;
			this.chb_matrix.Text = "CSENDES MÁTRIX";
			this.chb_matrix.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(988, 86);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(193, 15);
			this.label15.TabIndex = 30;
			this.label15.Text = "Vízmennyiség az idő függvényében";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(755, 87);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(162, 15);
			this.label16.TabIndex = 31;
			this.label16.Text = "Vízmennyiség légrétegenként";
			// 
			// pb_reteg
			// 
			this.pb_reteg.BackColor = System.Drawing.Color.White;
			this.pb_reteg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb_reteg.Location = new System.Drawing.Point(755, 113);
			this.pb_reteg.Name = "pb_reteg";
			this.pb_reteg.Size = new System.Drawing.Size(202, 140);
			this.pb_reteg.TabIndex = 32;
			this.pb_reteg.TabStop = false;
			// 
			// pb_ido
			// 
			this.pb_ido.BackColor = System.Drawing.Color.White;
			this.pb_ido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb_ido.Location = new System.Drawing.Point(988, 113);
			this.pb_ido.Name = "pb_ido";
			this.pb_ido.Size = new System.Drawing.Size(202, 140);
			this.pb_ido.TabIndex = 33;
			this.pb_ido.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1550, 652);
			this.Controls.Add(this.pb_ido);
			this.Controls.Add(this.pb_reteg);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.chb_matrix);
			this.Controls.Add(this.lab_matrix);
			this.Controls.Add(this.chb_cs);
			this.Controls.Add(this.tb_l);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.nud_C);
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
			this.Name = "Form1";
			this.Text = "Felhőképződés: Heterogén kondenzáció";
			((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_N)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_M)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_BK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_T)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_C)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_reteg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_ido)).EndInit();
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
		private System.Windows.Forms.NumericUpDown nud_C;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tb_l;
		private System.Windows.Forms.CheckBox chb_cs;
		private System.Windows.Forms.Label lab_matrix;
		private System.Windows.Forms.CheckBox chb_matrix;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.PictureBox pb_reteg;
		private System.Windows.Forms.PictureBox pb_ido;
	}
}

