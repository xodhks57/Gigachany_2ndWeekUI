﻿namespace Gigachany_2ndWeekUI
{
    partial class Form1_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SidePanel2 = new System.Windows.Forms.Panel();
			this.SidePanel = new System.Windows.Forms.Panel();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new Gigachany_2ndWeekUI.New_ProgressBar();
			this.panel1.SuspendLayout();
			this.SidePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.SidePanel2);
			this.panel1.Controls.Add(this.SidePanel);
			this.panel1.Controls.Add(this.Graph);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(963, 613);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// SidePanel2
			// 
			this.SidePanel2.BackColor = System.Drawing.Color.Brown;
			this.SidePanel2.Location = new System.Drawing.Point(933, 2);
			this.SidePanel2.Name = "SidePanel2";
			this.SidePanel2.Size = new System.Drawing.Size(27, 639);
			this.SidePanel2.TabIndex = 9;
			this.SidePanel2.Visible = false;
			// 
			// SidePanel
			// 
			this.SidePanel.BackColor = System.Drawing.Color.Brown;
			this.SidePanel.Controls.Add(this.TopPanel);
			this.SidePanel.Location = new System.Drawing.Point(481, 0);
			this.SidePanel.Name = "SidePanel";
			this.SidePanel.Size = new System.Drawing.Size(10, 639);
			this.SidePanel.TabIndex = 6;
			this.SidePanel.Visible = false;
			// 
			// BottomPanel
			// 
			this.BottomPanel.BackColor = System.Drawing.Color.Brown;
			this.BottomPanel.Location = new System.Drawing.Point(474, 612);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(481, 18);
			this.BottomPanel.TabIndex = 7;
			this.BottomPanel.Visible = false;
			this.BottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BottomPanel_Paint);
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.Brown;
			this.TopPanel.Location = new System.Drawing.Point(1, 3);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(481, 25);
			this.TopPanel.TabIndex = 8;
			this.TopPanel.Visible = false;
			// 
			// Graph
			// 
			chartArea1.Name = "ChartArea1";
			this.Graph.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.Graph.Legends.Add(legend1);
			this.Graph.Location = new System.Drawing.Point(488, 3);
			this.Graph.Name = "Graph";
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "표정";
			this.Graph.Series.Add(series1);
			this.Graph.Size = new System.Drawing.Size(473, 613);
			this.Graph.TabIndex = 1;
			this.Graph.Text = "chart1";
			this.Graph.Visible = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightCoral;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Image = global::Gigachany_2ndWeekUI.Properties.Resources.button_exit1;
			this.button5.Location = new System.Drawing.Point(388, 2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(94, 66);
			this.button5.TabIndex = 4;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Maroon;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Image = global::Gigachany_2ndWeekUI.Properties.Resources.button_Reset;
			this.button4.Location = new System.Drawing.Point(293, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(94, 66);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkRed;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = global::Gigachany_2ndWeekUI.Properties.Resources.button_ScreenShot;
			this.button3.Location = new System.Drawing.Point(198, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 66);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Brown;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Image = global::Gigachany_2ndWeekUI.Properties.Resources.button_Start;
			this.button2.Location = new System.Drawing.Point(103, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 66);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Firebrick;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::Gigachany_2ndWeekUI.Properties.Resources.button_load;
			this.button1.Location = new System.Drawing.Point(8, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 66);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Gigachany_2ndWeekUI.Properties.Resources.Q;
			this.pictureBox1.Location = new System.Drawing.Point(8, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(474, 544);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(-11, -5);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 619);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.White;
			this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.progressBar1.Location = new System.Drawing.Point(0, 612);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Percentage = 0;
			this.progressBar1.ShowText = false;
			this.progressBar1.Size = new System.Drawing.Size(474, 18);
			this.progressBar1.TabIndex = 1;
			// 
			// Form1_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(475, 632);
			this.ControlBox = false;
			this.Controls.Add(this.BottomPanel);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1_Main";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.panel1.ResumeLayout(false);
			this.SidePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		//private System.Windows.Forms.ProgressBar progressBar1;
		private New_ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel SidePanel;
		private System.Windows.Forms.Panel BottomPanel;
		private System.Windows.Forms.Panel SidePanel2;
		private System.Windows.Forms.Panel TopPanel;
	}
}

