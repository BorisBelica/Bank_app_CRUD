namespace bank_ucet
{
    partial class LoginAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAccess));
            this.txt_meno = new System.Windows.Forms.Label();
            this.txt_priezvisko = new System.Windows.Forms.Label();
            this.txt_zostatok = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.btn_save_data = new System.Windows.Forms.Button();
            this.lable_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.combox_list = new System.Windows.Forms.ComboBox();
            this.txt_zoznam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_meno
            // 
            this.txt_meno.AutoSize = true;
            this.txt_meno.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_meno.Location = new System.Drawing.Point(36, 79);
            this.txt_meno.Name = "txt_meno";
            this.txt_meno.Size = new System.Drawing.Size(47, 17);
            this.txt_meno.TabIndex = 0;
            this.txt_meno.Text = "MENO";
            // 
            // txt_priezvisko
            // 
            this.txt_priezvisko.AutoSize = true;
            this.txt_priezvisko.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priezvisko.Location = new System.Drawing.Point(36, 126);
            this.txt_priezvisko.Name = "txt_priezvisko";
            this.txt_priezvisko.Size = new System.Drawing.Size(75, 17);
            this.txt_priezvisko.TabIndex = 1;
            this.txt_priezvisko.Text = "PRIEZVISKO";
            this.txt_priezvisko.Click += new System.EventHandler(this.txt_priezvisko_Click);
            // 
            // txt_zostatok
            // 
            this.txt_zostatok.AutoSize = true;
            this.txt_zostatok.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zostatok.Location = new System.Drawing.Point(36, 172);
            this.txt_zostatok.Name = "txt_zostatok";
            this.txt_zostatok.Size = new System.Drawing.Size(69, 17);
            this.txt_zostatok.TabIndex = 2;
            this.txt_zostatok.Text = "ZOSTATOK";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(153, 76);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(127, 25);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.Location = new System.Drawing.Point(153, 123);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(127, 25);
            this.txt_surname.TabIndex = 4;
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(153, 169);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(127, 25);
            this.txt_balance.TabIndex = 5;
            this.txt_balance.TextChanged += new System.EventHandler(this.txt_balance_TextChanged);
            // 
            // btn_save_data
            // 
            this.btn_save_data.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_data.Location = new System.Drawing.Point(153, 215);
            this.btn_save_data.Name = "btn_save_data";
            this.btn_save_data.Size = new System.Drawing.Size(127, 26);
            this.btn_save_data.TabIndex = 6;
            this.btn_save_data.Text = "ULOŽ";
            this.btn_save_data.UseVisualStyleBackColor = true;
            this.btn_save_data.Click += new System.EventHandler(this.btn_save_data_Click);
            // 
            // lable_id
            // 
            this.lable_id.AutoSize = true;
            this.lable_id.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_id.Location = new System.Drawing.Point(36, 41);
            this.lable_id.Name = "lable_id";
            this.lable_id.Size = new System.Drawing.Size(20, 17);
            this.lable_id.TabIndex = 7;
            this.lable_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(153, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(127, 20);
            this.txt_id.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "UPRAV DÁTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(28, 320);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 26);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "VYMAŽ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // combox_list
            // 
            this.combox_list.FormattingEnabled = true;
            this.combox_list.Location = new System.Drawing.Point(345, 37);
            this.combox_list.Name = "combox_list";
            this.combox_list.Size = new System.Drawing.Size(121, 21);
            this.combox_list.TabIndex = 11;
            this.combox_list.SelectedIndexChanged += new System.EventHandler(this.combox_list_SelectedIndexChanged);
            // 
            // txt_zoznam
            // 
            this.txt_zoznam.AutoSize = true;
            this.txt_zoznam.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zoznam.Location = new System.Drawing.Point(374, 17);
            this.txt_zoznam.Name = "txt_zoznam";
            this.txt_zoznam.Size = new System.Drawing.Size(62, 17);
            this.txt_zoznam.TabIndex = 12;
            this.txt_zoznam.Text = "ZOZNAM";
            this.txt_zoznam.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(391, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "BACK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bank_ucet.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(395, 199);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_zoznam);
            this.Controls.Add(this.combox_list);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lable_id);
            this.Controls.Add(this.btn_save_data);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_zostatok);
            this.Controls.Add(this.txt_priezvisko);
            this.Controls.Add(this.txt_meno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Bankový účet";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_meno;
        private System.Windows.Forms.Label txt_priezvisko;
        private System.Windows.Forms.Label txt_zostatok;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Button btn_save_data;
        private System.Windows.Forms.Label lable_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox combox_list;
        private System.Windows.Forms.Label txt_zoznam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}