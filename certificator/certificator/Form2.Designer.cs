namespace certificator
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameServ = new System.Windows.Forms.TextBox();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.nameAdmin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите название услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Контактный телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ФИО администратора";
            // 
            // nameServ
            // 
            this.nameServ.Location = new System.Drawing.Point(12, 51);
            this.nameServ.Name = "nameServ";
            this.nameServ.Size = new System.Drawing.Size(136, 20);
            this.nameServ.TabIndex = 7;
            // 
            // nameClient
            // 
            this.nameClient.Location = new System.Drawing.Point(12, 90);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(136, 20);
            this.nameClient.TabIndex = 8;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(12, 129);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(136, 20);
            this.tel.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 168);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(136, 20);
            this.email.TabIndex = 10;
            // 
            // nameAdmin
            // 
            this.nameAdmin.Location = new System.Drawing.Point(12, 207);
            this.nameAdmin.Name = "nameAdmin";
            this.nameAdmin.Size = new System.Drawing.Size(136, 20);
            this.nameAdmin.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::certificator.Properties.Resources.lCNuMvjs9Wo;
            this.pictureBox1.Location = new System.Drawing.Point(167, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 224);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::certificator.Properties.Resources.image;
            this.button1.Location = new System.Drawing.Point(35, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(334, 302);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameAdmin);
            this.Controls.Add(this.email);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.nameClient);
            this.Controls.Add(this.nameServ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Create certificate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameServ;
        private System.Windows.Forms.TextBox nameClient;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox nameAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}