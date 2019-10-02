using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gigachany_2ndWeekUI
{

	public class New_ProgressBar : ProgressBar
	{
		public int Percentage { get; set; }
		public bool ShowText { get; set; }

		public new int Value
		{
			get { return this.Percentage; }
			set
			{
				this.Percentage = value;
				this.Invalidate();
			}
		}

		public New_ProgressBar()
		{
			this.SetStyle(ControlStyles.UserPaint, true);
			this.DoubleBuffered = true;
			if (ProgressBarRenderer.IsSupported)
			{
				SetStyle(ControlStyles.UserPaint, true);

			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rec = e.ClipRectangle;

			rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;

			if (ProgressBarRenderer.IsSupported)
				ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
			else
				e.Graphics.DrawRectangle(Pens.Gray, 0, 0, this.Width, this.Height);

			rec.Height = rec.Height - 4;

			using (System.Drawing.Drawing2D.LinearGradientBrush l =
				new System.Drawing.Drawing2D.LinearGradientBrush(e.ClipRectangle, Color.Green, Color.Red, 0F))
			{
				System.Drawing.Drawing2D.ColorBlend lb = new System.Drawing.Drawing2D.ColorBlend();
				lb.Colors = new Color[] { Color.LightCoral, Color.Firebrick, Color.Maroon };
				lb.Positions = new float[] { 0, 0.55F, 1.0F };
				l.InterpolationColors = lb;

				e.Graphics.FillRectangle(l, 2, 2, rec.Width, rec.Height);
			}

			using (System.Drawing.Drawing2D.LinearGradientBrush l2 =
				new System.Drawing.Drawing2D.LinearGradientBrush(e.ClipRectangle, Color.FromArgb(147, 255, 255, 255), Color.FromArgb(0, 255, 255, 255), System.Drawing.Drawing2D.LinearGradientMode.Vertical))
			{
				System.Drawing.Drawing2D.ColorBlend lb = new System.Drawing.Drawing2D.ColorBlend();
				lb.Colors = new Color[] { Color.FromArgb(40, 255, 255, 255), Color.FromArgb(147, 255, 255, 255),
	Color.FromArgb(40, 255, 255, 255), Color.FromArgb(0, 255, 255, 255) };
				lb.Positions = new float[] { 0, 0.12F, 0.39F, 1.0F };
				l2.InterpolationColors = lb;

				l2.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
				e.Graphics.FillRectangle(l2, 2, 2, rec.Width, rec.Height);
			}

			if (this.ShowText)
			{
				using (SolidBrush sb = new SolidBrush(this.ForeColor))
				{
					SizeF sz = e.Graphics.MeasureString(Percentage.ToString() + " %", this.Font);
					e.Graphics.DrawString(Percentage.ToString() + " %", this.Font, sb,
						new PointF((this.Width - sz.Width) / 2F, (this.Height - sz.Height) / 2F));
				}
			}

		}
	}
}
