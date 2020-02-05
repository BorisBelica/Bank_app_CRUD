namespace bank_ucet
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.btn_save_data = new System.Windows.Forms.Button();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_zostatok = new System.Windows.Forms.Label();
            this.txt_priezvisko = new System.Windows.Forms.Label();
            this.txt_meno = new System.Windows.Forms.Label();
            this.label_back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save_data
            // 
            this.btn_save_data.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_data.Location = new System.Drawing.Point(25, 173);
            this.btn_save_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save_data.Name = "btn_save_data";
            this.btn_save_data.Size = new System.Drawing.Size(238, 35);
            this.btn_save_data.TabIndex = 15;
            this.btn_save_data.Text = "CREATE";
            this.btn_save_data.UseVisualStyleBackColor = true;
            this.btn_save_data.Click += new System.EventHandler(this.btn_save_data_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(142, 118);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(4);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(188, 25);
            this.txt_balance.TabIndex = 14;
            this.txt_balance.TextChanged += new System.EventHandler(this.txt_balance_TextChanged);
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.Location = new System.Drawing.Point(142, 70);
            this.txt_surname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(188, 25);
            this.txt_surname.TabIndex = 13;
            this.txt_surname.TextChanged += new System.EventHandler(this.txt_surname_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(142, 24);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(188, 25);
            this.txt_name.TabIndex = 12;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_zostatok
            // 
            this.txt_zostatok.AutoSize = true;
            this.txt_zostatok.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_zostatok.Location = new System.Drawing.Point(7, 123);
            this.txt_zostatok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_zostatok.Name = "txt_zostatok";
            this.txt_zostatok.Size = new System.Drawing.Size(100, 20);
            this.txt_zostatok.TabIndex = 11;
            this.txt_zostatok.Text = "BALANCE [€]";
            // 
            // txt_priezvisko
            // 
            this.txt_priezvisko.AutoSize = true;
            this.txt_priezvisko.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_priezvisko.Location = new System.Drawing.Point(7, 75);
            this.txt_priezvisko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_priezvisko.Name = "txt_priezvisko";
            this.txt_priezvisko.Size = new System.Drawing.Size(77, 20);
            this.txt_priezvisko.TabIndex = 10;
            this.txt_priezvisko.Text = "SURNAME";
            // 
            // txt_meno
            // 
            this.txt_meno.AutoSize = true;
            this.txt_meno.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_meno.Location = new System.Drawing.Point(7, 29);
            this.txt_meno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_meno.Name = "txt_meno";
            this.txt_meno.Size = new System.Drawing.Size(50, 20);
            this.txt_meno.TabIndex = 9;
            this.txt_meno.Text = "NAME";
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_back.Location = new System.Drawing.Point(285, 197);
            this.label_back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(54, 19);
            this.label_back.TabIndex = 17;
            this.label_back.Text = "BACK";
            this.label_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_back.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "New Account";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bank_ucet.Properties.Resources.add;
            this.pictureBox3.Location = new System.Drawing.Point(355, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bank_ucet.Properties.Resources.back_1;
            this.pictureBox1.Location = new System.Drawing.Point(289, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save_data);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_zostatok);
            this.Controls.Add(this.txt_priezvisko);
            this.Controls.Add(this.txt_meno);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "NEW ACCOUNT";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save_data;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label txt_zostatok;
        private System.Windows.Forms.Label txt_priezvisko;
        private System.Windows.Forms.Label txt_meno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}