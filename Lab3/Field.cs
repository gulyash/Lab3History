using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
	class Field : Panel
	{
		private readonly Color selectedColor = Color.FromArgb(255, Color.Lime);

		private Shape currentShape;

		public Shape CurrentShape
		{
			get => currentShape;
			set
			{
				if (currentShape != null)
				{
					currentShape.BackColor = Color.Transparent;
				}

				currentShape = value;
				if (currentShape != null)
				{
					currentShape.BackColor = selectedColor;
				}
				
			}
		}

		public void AddShape(Image img, Point location)
		{
			var shape = new Shape
			{
				Parent = this,
				Image = img,
				Center = location
			};
			shape.CheckBounds();
			Controls.Add(shape);

			CurrentShape = shape;
		}

		public void AutoMove()
		{
			foreach (var shape in Controls.OfType<Shape>())
			{
				shape.AutoMove();
			}
		}

		public void SelectNextShape(bool previous)
		{
			if (currentShape == null)
			{
				return;
			}

			var figs = Controls.OfType<Shape>().ToList();
			var selectedIndex = figs.IndexOf(currentShape);

			var nextIndex = previous ? selectedIndex - 1 : selectedIndex + 1;
			if (nextIndex >= figs.Count)
				nextIndex = 0;
			else if (nextIndex < 0)
				nextIndex = figs.Count - 1;

			CurrentShape = figs[nextIndex];
		}

		public void InvalidateAll()
		{
			foreach (Control control in Controls)
			{
				control.Invalidate();
			}
		}
	}
}
