namespace VideojuegosPNo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNL_HEADER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PNL_HEADER.Controls.Add(this.pictureBox1);
            this.PNL_HEADER.Controls.Add(this.add);
            this.PNL_HEADER.Controls.Add(this.BTN_EXE);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1026, 94);
            this.PNL_HEADER.TabIndex = 1;
            this.PNL_HEADER.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_HEADER_Paint);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Navy;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Silver;
            this.add.Location = new System.Drawing.Point(215, 13);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 52);
            this.add.TabIndex = 3;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.Maroon;
            this.BTN_EXE.FlatAppearance.BorderSize = 0;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXE.ForeColor = System.Drawing.Color.SeaShell;
            this.BTN_EXE.Location = new System.Drawing.Point(41, 14);
            this.BTN_EXE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(107, 52);
            this.BTN_EXE.TabIndex = 0;
            this.BTN_EXE.Text = "RESET";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 10;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PCT_CANVAS.BackgroundImage = global::LYB.Resource1.fondo;
            this.PCT_CANVAS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCT_CANVAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCT_CANVAS.Location = new System.Drawing.Point(0, 94);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1026, 443);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.Click += new System.EventHandler(this.PCT_CANVAS_Click);
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LYB.Resource1.title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::LYB.Resource1.title;
            this.pictureBox1.Location = new System.Drawing.Point(358, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 537);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.PNL_HEADER);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "VERLET";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PNL_HEADER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

