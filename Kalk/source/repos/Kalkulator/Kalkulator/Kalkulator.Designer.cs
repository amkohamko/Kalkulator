
namespace Kalkulator
{
    partial class Kalkulator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator));
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.tbAnzeige = new System.Windows.Forms.TextBox();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Silver;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(73, 256);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 63);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Silver;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(224, 256);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 63);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // tbAnzeige
            // 
            this.tbAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnzeige.Location = new System.Drawing.Point(54, 42);
            this.tbAnzeige.Name = "tbAnzeige";
            this.tbAnzeige.Size = new System.Drawing.Size(435, 40);
            this.tbAnzeige.TabIndex = 2;
            this.tbAnzeige.TextChanged += new System.EventHandler(this.tbAnzeige_TextChanged);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Silver;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThree.Location = new System.Drawing.Point(372, 256);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 63);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Silver;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(73, 360);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 63);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Silver;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.Color.White;
            this.btnFive.Location = new System.Drawing.Point(224, 360);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 63);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Silver;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.Color.White;
            this.btnSix.Location = new System.Drawing.Point(372, 360);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 63);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Silver;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.White;
            this.btnSeven.Location = new System.Drawing.Point(73, 467);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(75, 63);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Silver;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.Color.White;
            this.btnEight.Location = new System.Drawing.Point(224, 467);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(75, 63);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Silver;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.Color.White;
            this.btnNine.Location = new System.Drawing.Point(372, 468);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(75, 63);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(505, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.isEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Silver;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(73, 575);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 63);
            this.btnZero.TabIndex = 11;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Silver;
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.White;
            this.btnPoint.Location = new System.Drawing.Point(224, 575);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(75, 62);
            this.btnPoint.TabIndex = 12;
            this.btnPoint.Text = ",";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(372, 575);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 63);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "C";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Gray;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(505, 258);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 63);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Gray;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(505, 362);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 62);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Gray;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(505, 470);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 62);
            this.btnMulti.TabIndex = 16;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Gray;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(505, 576);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 62);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 30);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.pictureBox3.Location = new System.Drawing.Point(580, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 30);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // Kalkulator
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 666);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.tbAnzeige);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.TextBox tbAnzeige;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

