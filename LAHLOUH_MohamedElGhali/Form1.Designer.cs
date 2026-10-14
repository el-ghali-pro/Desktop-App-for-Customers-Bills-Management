namespace LAHLOUH_MohamedElGhali
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DureenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.enmois = new System.Windows.Forms.RadioButton();
            this.enannee = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TauxBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreditBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalaireBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ValideButton2 = new System.Windows.Forms.Button();
            this.moisnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ansnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.creditBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ValideButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DureenumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moisnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez remplir les champs suivants : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.DureenumericUpDown);
            this.groupBox2.Controls.Add(this.enmois);
            this.groupBox2.Controls.Add(this.enannee);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TauxBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CreditBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(43, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saisissez les infos du crédit :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DureenumericUpDown
            // 
            this.DureenumericUpDown.Location = new System.Drawing.Point(540, 27);
            this.DureenumericUpDown.Name = "DureenumericUpDown";
            this.DureenumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.DureenumericUpDown.TabIndex = 9;
            this.DureenumericUpDown.ValueChanged += new System.EventHandler(this.DureenumericUpDown_ValueChanged);
            // 
            // enmois
            // 
            this.enmois.AutoSize = true;
            this.enmois.Location = new System.Drawing.Point(426, 64);
            this.enmois.Name = "enmois";
            this.enmois.Size = new System.Drawing.Size(61, 17);
            this.enmois.TabIndex = 8;
            this.enmois.TabStop = true;
            this.enmois.Text = "en mois";
            this.enmois.UseVisualStyleBackColor = true;
            // 
            // enannee
            // 
            this.enannee.AutoSize = true;
            this.enannee.Location = new System.Drawing.Point(514, 64);
            this.enannee.Name = "enannee";
            this.enannee.Size = new System.Drawing.Size(73, 17);
            this.enannee.TabIndex = 4;
            this.enannee.TabStop = true;
            this.enannee.Text = "en année ";
            this.enannee.UseVisualStyleBackColor = true;
            this.enannee.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durée de l\'emprunt";
            // 
            // TauxBox
            // 
            this.TauxBox.Location = new System.Drawing.Point(215, 61);
            this.TauxBox.Name = "TauxBox";
            this.TauxBox.Size = new System.Drawing.Size(106, 20);
            this.TauxBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taux Effectif Annuel (en %)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CreditBox
            // 
            this.CreditBox.Location = new System.Drawing.Point(143, 27);
            this.CreditBox.Name = "CreditBox";
            this.CreditBox.Size = new System.Drawing.Size(178, 20);
            this.CreditBox.TabIndex = 4;
            this.CreditBox.TextChanged += new System.EventHandler(this.CreditBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crédit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salaire";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SalaireBox);
            this.groupBox1.Location = new System.Drawing.Point(124, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisissez le salaire :";
            // 
            // SalaireBox
            // 
            this.SalaireBox.Location = new System.Drawing.Point(134, 30);
            this.SalaireBox.Name = "SalaireBox";
            this.SalaireBox.Size = new System.Drawing.Size(178, 20);
            this.SalaireBox.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ValideButton2);
            this.groupBox3.Controls.Add(this.moisnumericUpDown1);
            this.groupBox3.Controls.Add(this.ansnumericUpDown1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.creditBox2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(43, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 108);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resaisissez les infos ci-dessous pour que vous soyez éligible :";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "mois";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ans";
            // 
            // ValideButton2
            // 
            this.ValideButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ValideButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ValideButton2.BackgroundImage")));
            this.ValideButton2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ValideButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValideButton2.Location = new System.Drawing.Point(529, 57);
            this.ValideButton2.Name = "ValideButton2";
            this.ValideButton2.Size = new System.Drawing.Size(86, 32);
            this.ValideButton2.TabIndex = 12;
            this.ValideButton2.Text = "Valider";
            this.ValideButton2.UseVisualStyleBackColor = false;
            this.ValideButton2.Click += new System.EventHandler(this.ValideButton2_Click);
            // 
            // moisnumericUpDown1
            // 
            this.moisnumericUpDown1.Location = new System.Drawing.Point(313, 66);
            this.moisnumericUpDown1.Name = "moisnumericUpDown1";
            this.moisnumericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.moisnumericUpDown1.TabIndex = 11;
            // 
            // ansnumericUpDown1
            // 
            this.ansnumericUpDown1.Location = new System.Drawing.Point(213, 66);
            this.ansnumericUpDown1.Name = "ansnumericUpDown1";
            this.ansnumericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.ansnumericUpDown1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "de l\'emprunt :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "minimale";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Durée ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // creditBox2
            // 
            this.creditBox2.Location = new System.Drawing.Point(213, 25);
            this.creditBox2.Name = "creditBox2";
            this.creditBox2.Size = new System.Drawing.Size(171, 20);
            this.creditBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Crédit";
            // 
            // ValideButton
            // 
            this.ValideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ValideButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ValideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValideButton.Location = new System.Drawing.Point(495, 210);
            this.ValideButton.Name = "ValideButton";
            this.ValideButton.Size = new System.Drawing.Size(108, 37);
            this.ValideButton.TabIndex = 10;
            this.ValideButton.Text = "Valider";
            this.ValideButton.UseVisualStyleBackColor = false;
            this.ValideButton.Click += new System.EventHandler(this.ValideButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.ValideButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Eligibility Verification App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DureenumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moisnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ansnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreditBox;
        private System.Windows.Forms.TextBox TauxBox;
        private System.Windows.Forms.RadioButton enannee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton enmois;
        private System.Windows.Forms.NumericUpDown DureenumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SalaireBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox creditBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ValideButton2;
        private System.Windows.Forms.NumericUpDown moisnumericUpDown1;
        private System.Windows.Forms.NumericUpDown ansnumericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ValideButton;
    }
}

