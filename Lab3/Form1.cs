using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
	public partial class Form1 : Form
	{
		private Point mouseLocation;

		public Form1()
		{
			InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			var actions = new Dictionary<Keys, Action>
			{
               // timer
                {Keys.F5, () => timer.Start()},
				{Keys.F6, () => timer.Stop()},

                // manual moving
                {Keys.Left, () => field.CurrentShape?.MoveByKeys(new Point(-1, 0))},
				{Keys.Right, () => field.CurrentShape?.MoveByKeys(new Point(1, 0))},
				{Keys.Up, () => field.CurrentShape?.MoveByKeys(new Point(0, -1))},
				{Keys.Down, () => field.CurrentShape?.MoveByKeys(new Point(0, 1))},
			};


			if (actions.ContainsKey(keyData))
			{
				actions[keyData].Invoke();
			}
			if ((keyData & Keys.Tab) == Keys.Tab)
			{
				field.SelectNextShape((keyData & Keys.Shift) == Keys.Shift);
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			field.AutoMove();
		}

		private void toolStripMenuItem_Click(object sender, EventArgs e)
		{
			var imgIndex = 0;
			if (sender.Equals(crossToolStripMenuItem))
			{
				imgIndex = 1;
			}
			else if (sender.Equals(starToolStripMenuItem))
			{
				imgIndex = 2;
			}

			field.AddShape(imageList.Images[imgIndex], mouseLocation);
		}

		private void field_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				mouseLocation = e.Location;
			}
		}
	}
}
