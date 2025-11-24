namespace lista
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
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            lbl300 = new Label();
            btngrande = new RadioButton();
            btnmedio = new RadioButton();
            btnpequeno = new RadioButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            lbl500 = new Label();
            lbl700 = new Label();
            btnbanana = new CheckBox();
            btnpacoca = new CheckBox();
            btngranola = new CheckBox();
            btnchoco = new CheckBox();
            btnleitepo = new CheckBox();
            btnleite = new CheckBox();
            btnovomaltine = new CheckBox();
            btnconfetes = new CheckBox();
            btnmorango = new CheckBox();
            btndoceleite = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(59, 49);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(686, 142);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbl700);
            panel1.Controls.Add(lbl500);
            panel1.Controls.Add(lbl300);
            panel1.Controls.Add(btngrande);
            panel1.Controls.Add(btnmedio);
            panel1.Controls.Add(btnpequeno);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl1);
            panel1.Location = new Point(59, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 279);
            panel1.TabIndex = 4;
            // 
            // lbl300
            // 
            lbl300.AutoSize = true;
            lbl300.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl300.ForeColor = Color.DarkSlateBlue;
            lbl300.Location = new Point(30, 117);
            lbl300.Name = "lbl300";
            lbl300.Size = new Size(44, 17);
            lbl300.TabIndex = 6;
            lbl300.Text = "300ml";
            // 
            // btngrande
            // 
            btngrande.AutoSize = true;
            btngrande.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btngrande.ForeColor = Color.DarkSlateBlue;
            btngrande.Location = new Point(12, 201);
            btngrande.Name = "btngrande";
            btngrande.Size = new Size(300, 24);
            btngrande.TabIndex = 5;
            btngrande.TabStop = true;
            btngrande.Text = "Grande.....................R$17,90\r\n";
            btngrande.UseVisualStyleBackColor = true;
            btngrande.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnmedio
            // 
            btnmedio.AutoSize = true;
            btnmedio.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmedio.ForeColor = Color.DarkSlateBlue;
            btnmedio.Location = new Point(12, 146);
            btnmedio.Name = "btnmedio";
            btnmedio.Size = new Size(301, 24);
            btnmedio.TabIndex = 4;
            btnmedio.TabStop = true;
            btnmedio.Text = "Médio.......................R$15,90\r\n";
            btnmedio.UseVisualStyleBackColor = true;
            // 
            // btnpequeno
            // 
            btnpequeno.AutoSize = true;
            btnpequeno.Font = new Font("Verdana", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpequeno.ForeColor = Color.DarkSlateBlue;
            btnpequeno.Location = new Point(12, 90);
            btnpequeno.Name = "btnpequeno";
            btnpequeno.Size = new Size(302, 24);
            btnpequeno.TabIndex = 3;
            btnpequeno.TabStop = true;
            btnpequeno.Text = "Pequeno...................R$12,90\r\n";
            btnpequeno.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(268, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 31);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 31);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("SWItal", 24.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.DarkSlateBlue;
            lbl1.Location = new Point(68, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(208, 42);
            lbl1.TabIndex = 0;
            lbl1.Text = "Tamanho";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btndoceleite);
            panel2.Controls.Add(btnovomaltine);
            panel2.Controls.Add(btnconfetes);
            panel2.Controls.Add(btnmorango);
            panel2.Controls.Add(btnchoco);
            panel2.Controls.Add(btnleitepo);
            panel2.Controls.Add(btnleite);
            panel2.Controls.Add(btngranola);
            panel2.Controls.Add(btnpacoca);
            panel2.Controls.Add(btnbanana);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(409, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 345);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Plum;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(59, 511);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 260);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(323, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 31);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(3, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 31);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SWItal", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(372, 39);
            label1.TabIndex = 7;
            label1.Text = "Acompanhamentos";
            // 
            // lbl500
            // 
            lbl500.AutoSize = true;
            lbl500.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl500.ForeColor = Color.DarkSlateBlue;
            lbl500.Location = new Point(30, 173);
            lbl500.Name = "lbl500";
            lbl500.Size = new Size(44, 17);
            lbl500.TabIndex = 7;
            lbl500.Text = "500ml";
            // 
            // lbl700
            // 
            lbl700.AutoSize = true;
            lbl700.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl700.ForeColor = Color.DarkSlateBlue;
            lbl700.Location = new Point(30, 228);
            lbl700.Name = "lbl700";
            lbl700.Size = new Size(44, 17);
            lbl700.TabIndex = 8;
            lbl700.Text = "700ml";
            // 
            // btnbanana
            // 
            btnbanana.AutoSize = true;
            btnbanana.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnbanana.ForeColor = Color.DarkSlateBlue;
            btnbanana.Location = new Point(16, 87);
            btnbanana.Name = "btnbanana";
            btnbanana.Size = new Size(330, 27);
            btnbanana.TabIndex = 10;
            btnbanana.Text = "Banana.................................";
            btnbanana.UseVisualStyleBackColor = true;
            // 
            // btnpacoca
            // 
            btnpacoca.AutoSize = true;
            btnpacoca.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnpacoca.ForeColor = Color.DarkSlateBlue;
            btnpacoca.Location = new Point(16, 111);
            btnpacoca.Name = "btnpacoca";
            btnpacoca.Size = new Size(332, 27);
            btnpacoca.TabIndex = 11;
            btnpacoca.Text = "Paçoca..................................";
            btnpacoca.UseVisualStyleBackColor = true;
            // 
            // btngranola
            // 
            btngranola.AutoSize = true;
            btngranola.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btngranola.ForeColor = Color.DarkSlateBlue;
            btngranola.Location = new Point(16, 134);
            btngranola.Name = "btngranola";
            btngranola.Size = new Size(334, 27);
            btngranola.TabIndex = 12;
            btngranola.Text = "Granola.................................";
            btngranola.UseVisualStyleBackColor = true;
            // 
            // btnchoco
            // 
            btnchoco.AutoSize = true;
            btnchoco.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnchoco.ForeColor = Color.DarkSlateBlue;
            btnchoco.Location = new Point(16, 201);
            btnchoco.Name = "btnchoco";
            btnchoco.Size = new Size(334, 27);
            btnchoco.TabIndex = 15;
            btnchoco.Text = "Cobertura de chocolate............";
            btnchoco.UseVisualStyleBackColor = true;
            // 
            // btnleitepo
            // 
            btnleitepo.AutoSize = true;
            btnleitepo.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnleitepo.ForeColor = Color.DarkSlateBlue;
            btnleitepo.Location = new Point(16, 178);
            btnleitepo.Name = "btnleitepo";
            btnleitepo.Size = new Size(337, 27);
            btnleitepo.TabIndex = 14;
            btnleitepo.Text = "Leite em pó............................";
            btnleitepo.UseVisualStyleBackColor = true;
            // 
            // btnleite
            // 
            btnleite.AutoSize = true;
            btnleite.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnleite.ForeColor = Color.DarkSlateBlue;
            btnleite.Location = new Point(16, 154);
            btnleite.Name = "btnleite";
            btnleite.Size = new Size(335, 27);
            btnleite.TabIndex = 13;
            btnleite.Text = "Leite condensado....................";
            btnleite.UseVisualStyleBackColor = true;
            // 
            // btnovomaltine
            // 
            btnovomaltine.AutoSize = true;
            btnovomaltine.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnovomaltine.ForeColor = Color.DarkSlateBlue;
            btnovomaltine.Location = new Point(16, 269);
            btnovomaltine.Name = "btnovomaltine";
            btnovomaltine.Size = new Size(332, 27);
            btnovomaltine.TabIndex = 18;
            btnovomaltine.Text = "Ovomaltine............................";
            btnovomaltine.UseVisualStyleBackColor = true;
            // 
            // btnconfetes
            // 
            btnconfetes.AutoSize = true;
            btnconfetes.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnconfetes.ForeColor = Color.DarkSlateBlue;
            btnconfetes.Location = new Point(16, 246);
            btnconfetes.Name = "btnconfetes";
            btnconfetes.Size = new Size(329, 27);
            btnconfetes.TabIndex = 17;
            btnconfetes.Text = "Confetes...............................";
            btnconfetes.UseVisualStyleBackColor = true;
            // 
            // btnmorango
            // 
            btnmorango.AutoSize = true;
            btnmorango.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnmorango.ForeColor = Color.DarkSlateBlue;
            btnmorango.Location = new Point(16, 222);
            btnmorango.Name = "btnmorango";
            btnmorango.Size = new Size(329, 27);
            btnmorango.TabIndex = 16;
            btnmorango.Text = "Cobertura de morango............";
            btnmorango.UseVisualStyleBackColor = true;
            // 
            // btndoceleite
            // 
            btndoceleite.AutoSize = true;
            btndoceleite.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btndoceleite.ForeColor = Color.DarkSlateBlue;
            btndoceleite.Location = new Point(16, 292);
            btndoceleite.Name = "btndoceleite";
            btndoceleite.Size = new Size(335, 27);
            btndoceleite.TabIndex = 19;
            btndoceleite.Text = "Doce de leite..........................";
            btndoceleite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(808, 819);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox4;
        private Panel panel1;
        private RadioButton btnpequeno;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl1;
        private Panel panel2;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton btngrande;
        private RadioButton btnmedio;
        private Label lbl300;
        private Label lbl700;
        private Label lbl500;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox5;
        private CheckBox btndoceleite;
        private CheckBox btnovomaltine;
        private CheckBox btnconfetes;
        private CheckBox btnmorango;
        private CheckBox btnchoco;
        private CheckBox btnleitepo;
        private CheckBox btnleite;
        private CheckBox btngranola;
        private CheckBox btnpacoca;
        private CheckBox btnbanana;
    }
}