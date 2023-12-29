namespace Grubas
{
    partial class NakarmGrubego
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NakarmGrubego));
            this.start_button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.insertFood = new System.Windows.Forms.TextBox();
            this.question = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pet_button = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(242, 390);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(114, 48);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Wręcz jedzenie";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Title.Location = new System.Drawing.Point(236, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(314, 34);
            this.Title.TabIndex = 1;
            this.Title.Text = "Nakarm swojego Bukraja";
            this.Title.Click += new System.EventHandler(this.username_Click);
            // 
            // insertFood
            // 
            this.insertFood.Location = new System.Drawing.Point(338, 349);
            this.insertFood.MaxLength = 10;
            this.insertFood.Name = "insertFood";
            this.insertFood.Size = new System.Drawing.Size(201, 20);
            this.insertFood.TabIndex = 3;
            this.insertFood.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(162, 353);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(170, 16);
            this.question.TabIndex = 4;
            this.question.Text = "Co dzisiaj zje Twój bukraj?";
            this.question.Click += new System.EventHandler(this.question_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grubas.Properties.Resources.mammon;
            this.pictureBox1.Location = new System.Drawing.Point(231, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 254);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Grubas.Properties.Resources.petpetbukraj;
            this.pictureBox2.Location = new System.Drawing.Point(204, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pet_button
            // 
            this.pet_button.Location = new System.Drawing.Point(443, 390);
            this.pet_button.Name = "pet_button";
            this.pet_button.Size = new System.Drawing.Size(120, 48);
            this.pet_button.TabIndex = 8;
            this.pet_button.Text = "Pogłaskaj";
            this.pet_button.UseVisualStyleBackColor = true;
            this.pet_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(556, 64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 21);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_click);
            // 
            // NakarmGrubego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pet_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.insertFood);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.start_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NakarmGrubego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NakarmBukraja";
            this.TransparencyKey = System.Drawing.Color.YellowGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button start_button;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.TextBox insertFood;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button pet_button;
        private System.Windows.Forms.Button btnClose;
    }
}

