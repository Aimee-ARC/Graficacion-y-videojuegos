
namespace Animacion_3D
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pct = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Archivos = new System.Windows.Forms.TreeView();
            this.TIME = new System.Windows.Forms.TrackBar();
            this.addFrame = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tansx = new System.Windows.Forms.TrackBar();
            this.transy = new System.Windows.Forms.TrackBar();
            this.transz = new System.Windows.Forms.TrackBar();
            this.rotz = new System.Windows.Forms.TrackBar();
            this.roty = new System.Windows.Forms.TrackBar();
            this.rotx = new System.Windows.Forms.TrackBar();
            this.esc = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tansx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esc)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pct.Location = new System.Drawing.Point(12, 76);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(1684, 677);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pct_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Lime;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Location = new System.Drawing.Point(1720, 577);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(183, 46);
            this.Play.TabIndex = 1;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Archivos
            // 
            this.Archivos.Location = new System.Drawing.Point(1720, 76);
            this.Archivos.Margin = new System.Windows.Forms.Padding(4);
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(183, 481);
            this.Archivos.TabIndex = 21;
            this.Archivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Archivos_AfterSelect);
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(87, 12);
            this.TIME.Margin = new System.Windows.Forms.Padding(4);
            this.TIME.Maximum = 100;
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(1829, 56);
            this.TIME.TabIndex = 31;
            this.TIME.Scroll += new System.EventHandler(this.TB_TIME_Scroll);
            // 
            // addFrame
            // 
            this.addFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addFrame.Location = new System.Drawing.Point(1721, 641);
            this.addFrame.Name = "addFrame";
            this.addFrame.Size = new System.Drawing.Size(183, 46);
            this.addFrame.TabIndex = 32;
            this.addFrame.Text = "RECORD";
            this.addFrame.UseVisualStyleBackColor = false;
            this.addFrame.Click += new System.EventHandler(this.addFrame_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(1721, 708);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(183, 46);
            this.open.TabIndex = 33;
            this.open.Text = "OPEN OBJ";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos OBJ|*.obj";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tansx
            // 
            this.tansx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tansx.Location = new System.Drawing.Point(12, 781);
            this.tansx.Margin = new System.Windows.Forms.Padding(1);
            this.tansx.Minimum = -10;
            this.tansx.Name = "tansx";
            this.tansx.Size = new System.Drawing.Size(1684, 56);
            this.tansx.TabIndex = 38;
            this.tansx.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tansx.Scroll += new System.EventHandler(this.tansx_Scroll);
            // 
            // transy
            // 
            this.transy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.transy.Location = new System.Drawing.Point(12, 810);
            this.transy.Margin = new System.Windows.Forms.Padding(1);
            this.transy.Minimum = -10;
            this.transy.Name = "transy";
            this.transy.Size = new System.Drawing.Size(1684, 56);
            this.transy.TabIndex = 39;
            this.transy.TickStyle = System.Windows.Forms.TickStyle.None;
            this.transy.Scroll += new System.EventHandler(this.transy_Scroll);
            // 
            // transz
            // 
            this.transz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.transz.Location = new System.Drawing.Point(12, 839);
            this.transz.Margin = new System.Windows.Forms.Padding(1);
            this.transz.Minimum = -10;
            this.transz.Name = "transz";
            this.transz.Size = new System.Drawing.Size(1684, 56);
            this.transz.TabIndex = 40;
            this.transz.TickStyle = System.Windows.Forms.TickStyle.None;
            this.transz.Scroll += new System.EventHandler(this.transz_Scroll);
            // 
            // rotz
            // 
            this.rotz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rotz.Location = new System.Drawing.Point(12, 926);
            this.rotz.Margin = new System.Windows.Forms.Padding(1);
            this.rotz.Maximum = 180;
            this.rotz.Minimum = -180;
            this.rotz.Name = "rotz";
            this.rotz.Size = new System.Drawing.Size(1684, 56);
            this.rotz.TabIndex = 43;
            this.rotz.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rotz.Scroll += new System.EventHandler(this.rotz_Scroll);
            // 
            // roty
            // 
            this.roty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roty.Location = new System.Drawing.Point(12, 897);
            this.roty.Margin = new System.Windows.Forms.Padding(1);
            this.roty.Maximum = 180;
            this.roty.Minimum = -180;
            this.roty.Name = "roty";
            this.roty.Size = new System.Drawing.Size(1684, 56);
            this.roty.TabIndex = 42;
            this.roty.TickStyle = System.Windows.Forms.TickStyle.None;
            this.roty.Scroll += new System.EventHandler(this.roty_Scroll);
            // 
            // rotx
            // 
            this.rotx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rotx.Location = new System.Drawing.Point(12, 868);
            this.rotx.Margin = new System.Windows.Forms.Padding(1);
            this.rotx.Maximum = 180;
            this.rotx.Minimum = -180;
            this.rotx.Name = "rotx";
            this.rotx.Size = new System.Drawing.Size(1684, 56);
            this.rotx.TabIndex = 41;
            this.rotx.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rotx.Scroll += new System.EventHandler(this.rotx_Scroll);
            // 
            // esc
            // 
            this.esc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.esc.Location = new System.Drawing.Point(12, 955);
            this.esc.Margin = new System.Windows.Forms.Padding(1);
            this.esc.Maximum = 200;
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(1684, 56);
            this.esc.TabIndex = 44;
            this.esc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.esc.Value = 100;
            this.esc.Scroll += new System.EventHandler(this.esc_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1717, 781);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Traslación x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1717, 813);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Traslación y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1717, 842);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Traslación z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1717, 871);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Rotación x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1717, 900);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 49;
            this.label6.Text = "Rotación y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1717, 929);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Rotación z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1717, 958);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Escalado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1024);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.rotz);
            this.Controls.Add(this.roty);
            this.Controls.Add(this.rotx);
            this.Controls.Add(this.transz);
            this.Controls.Add(this.transy);
            this.Controls.Add(this.tansx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.addFrame);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.Archivos);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPEN OBJ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tansx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.TreeView Archivos;
        private System.Windows.Forms.TrackBar TIME;
        private System.Windows.Forms.Button addFrame;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar tansx;
        private System.Windows.Forms.TrackBar transy;
        private System.Windows.Forms.TrackBar transz;
        private System.Windows.Forms.TrackBar rotz;
        private System.Windows.Forms.TrackBar roty;
        private System.Windows.Forms.TrackBar rotx;
        private System.Windows.Forms.TrackBar esc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

