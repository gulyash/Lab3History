namespace Lab3
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.starToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.field = new Lab3.Field();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.crossToolStripMenuItem,
            this.starToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(105, 70);
			// 
			// circleToolStripMenuItem
			// 
			this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
			this.circleToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.circleToolStripMenuItem.Text = "Circle";
			this.circleToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
			// 
			// crossToolStripMenuItem
			// 
			this.crossToolStripMenuItem.Name = "crossToolStripMenuItem";
			this.crossToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.crossToolStripMenuItem.Text = "Cross";
			this.crossToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
			// 
			// starToolStripMenuItem
			// 
			this.starToolStripMenuItem.Name = "starToolStripMenuItem";
			this.starToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.starToolStripMenuItem.Text = "Star";
			this.starToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "circle.png");
			this.imageList.Images.SetKeyName(1, "cross.png");
			this.imageList.Images.SetKeyName(2, "star.png");
			// 
			// field
			// 
			this.field.ContextMenuStrip = this.contextMenuStrip;
			this.field.CurrentShape = null;
			this.field.Location = new System.Drawing.Point(0, 0);
			this.field.Name = "field";
			this.field.Size = new System.Drawing.Size(441, 330);
			this.field.TabIndex = 1;
			this.field.MouseUp += new System.Windows.Forms.MouseEventHandler(this.field_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 329);
			this.Controls.Add(this.field);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crossToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem starToolStripMenuItem;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ImageList imageList;
		private Field field;
	}
}

