using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
	class Shape : PictureBox
	{
		public const int DefSize = 40;
		public const int DefSpeed = 4;

		public Point MovingVector { get; set; }

		public int Speed { get; set; }

		public Point Center
		{
			get => new Point(Left + Width / 2, Top + Height / 2);
			set
			{
				Left = value.X - Width / 2;
				Top = value.Y - Height / 2;
			}
		}

		public Shape()
		{
			Size = new Size(DefSize, DefSize);
			Speed = DefSpeed;
			MovingVector = new Point(1, 1);
		}

		public virtual void MoveByKeys(Point vector)
		{
			Left += Speed * vector.X;
			Top += Speed * vector.Y;

			CheckBounds();
		}

		public void CheckBounds()
		{
			if (Bounds.Top < 0)
			{
				Top = 0;
			}
			else if (Bounds.Bottom > Parent.Height)
			{
				Top = Parent.Height - Height;
			}

			if (Bounds.Left < 0)
			{
				Left = 0;
			}
			else if (Bounds.Right > Parent.Width)
			{
				Left = Parent.Width - Width;
			}
		}

		public void AutoMove()
		{
			if (Bounds.Right >= Parent.Width)
			{
				MovingVector = new Point(-1, MovingVector.Y);
			}
			else if (Bounds.Left <= 0)
			{
				MovingVector = new Point(1, MovingVector.Y);
			}

			if (Bounds.Bottom >= Parent.Height)
			{
				MovingVector = new Point(MovingVector.X, -1);
			}
			else if (Bounds.Top <= 0)
			{
				MovingVector = new Point(MovingVector.X, 1);
			}

			Left += Speed * MovingVector.X;
			Top += Speed * MovingVector.Y;
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			if (Parent is Field field)
			{
				field.CurrentShape = this;
			}
		}
	}
}
