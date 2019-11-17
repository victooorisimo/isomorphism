namespace Isomorphism
{
    partial class HomeApplication
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbGraphTwo = new System.Windows.Forms.PictureBox();
            this.ptbGraphOne = new System.Windows.Forms.PictureBox();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.openFileDialogTwo = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGraphTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGraphOne)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isomorfismo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ptbGraphTwo);
            this.panel1.Controls.Add(this.ptbGraphOne);
            this.panel1.Controls.Add(this.btnSecond);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 65);
            this.panel1.TabIndex = 1;
            // 
            // ptbGraphTwo
            // 
            this.ptbGraphTwo.Image = global::Isomorphism.Properties.Resources.verificationIcon;
            this.ptbGraphTwo.Location = new System.Drawing.Point(379, 30);
            this.ptbGraphTwo.Name = "ptbGraphTwo";
            this.ptbGraphTwo.Size = new System.Drawing.Size(10, 12);
            this.ptbGraphTwo.TabIndex = 6;
            this.ptbGraphTwo.TabStop = false;
            // 
            // ptbGraphOne
            // 
            this.ptbGraphOne.Image = global::Isomorphism.Properties.Resources.verificationIcon;
            this.ptbGraphOne.Location = new System.Drawing.Point(148, 29);
            this.ptbGraphOne.Name = "ptbGraphOne";
            this.ptbGraphOne.Size = new System.Drawing.Size(10, 12);
            this.ptbGraphOne.TabIndex = 5;
            this.ptbGraphOne.TabStop = false;
            // 
            // btnSecond
            // 
            this.btnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSecond.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnSecond.Location = new System.Drawing.Point(250, 22);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(125, 25);
            this.btnSecond.TabIndex = 4;
            this.btnSecond.Text = "Segundo archivo";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnFirst.Location = new System.Drawing.Point(19, 22);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(125, 25);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "Primer archivo";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selección de archivos:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 295);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Grafo número dos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grafo número uno";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(207, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 254);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyze.Font = new System.Drawing.Font("Corbel", 10F);
            this.btnAnalyze.Location = new System.Drawing.Point(155, 467);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(125, 25);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analizar grafos";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // openFileDialogTwo
            // 
            this.openFileDialogTwo.FileName = "openFileDialogTwo";
            this.openFileDialogTwo.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Representación de los grafos:";
            // 
            // HomeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home application - Isomorphism";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbGraphTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGraphOne)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.OpenFileDialog openFileDialogTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbGraphOne;
        private System.Windows.Forms.PictureBox ptbGraphTwo;
    }
}

