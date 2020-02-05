namespace bank_ucet
{
    partial class DeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccount));
            this.txt_zoznam = new System.Windows.Forms.Label();
            this.combox_list = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lable_id = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label_back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_priezvisko = new System.Windows.Forms.Label();
            this.txt_meno = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_zoznam
            // 
            this.txt_zoznam.AutoSize = true;
            this.txt_zoznam.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_zoznam.Location = new System.Drawing.Point(437, 5);
            this.txt_zoznam.Name = "txt_zoznam";
            this.txt_zoznam.Size = new System.Drawing.Size(38, 20);
            this.txt_zoznam.TabIndex = 14;
            this.txt_zoznam.Text = "LIST";
            this.txt_zoznam.Click += new System.EventHandler(this.txt_zoznam_Click);
            // 
            // combox_list
            // 
            this.combox_list.FormattingEnabled = true;
            this.combox_list.Location = new System.Drawing.Point(393, 28);
            this.combox_list.Name = "combox_list";
            this.combox_list.Size = new System.Drawing.Size(127, 24);
            this.combox_list.TabIndex = 13;
            this.combox_list.SelectedIndexChanged += new System.EventHandler(this.combox_list_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(110, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(127, 23);
            this.txt_id.TabIndex = 18;
            // 
            // lable_id
            // 
            this.lable_id.AutoSize = true;
            this.lable_id.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lable_id.Location = new System.Drawing.Point(81, 28);
            this.lable_id.Name = "lable_id";
            this.lable_id.Size = new System.Drawing.Size(23, 20);
            this.lable_id.TabIndex = 17;
            this.lable_id.Text = "ID";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(19, 168);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(218, 26);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label_back
            // 
            this.label_back.AutoSize = true;
            this.label_back.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_back.Location = new System.Drawing.Point(322, 168);
            this.label_back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_back.Name = "label_back";
            this.label_back.Size = new System.Drawing.Size(46, 20);
            this.label_back.TabIndex = 21;
            this.label_back.Text = "BACK";
            this.label_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Delete Account";
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.Location = new System.Drawing.Point(110, 114);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(127, 25);
            this.txt_surname.TabIndex = 27;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(110, 67);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(127, 25);
            this.txt_name.TabIndex = 26;
            // 
            // txt_priezvisko
            // 
            this.txt_priezvisko.AutoSize = true;
            this.txt_priezvisko.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_priezvisko.Location = new System.Drawing.Point(27, 119);
            this.txt_priezvisko.Name = "txt_priezvisko";
            this.txt_priezvisko.Size = new System.Drawing.Size(77, 20);
            this.txt_priezvisko.TabIndex = 25;
            this.txt_priezvisko.Text = "SURNAME";
            // 
            // txt_meno
            // 
            this.txt_meno.AutoSize = true;
            this.txt_meno.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_meno.Location = new System.Drawing.Point(54, 72);
            this.txt_meno.Name = "txt_meno";
            this.txt_meno.Size = new System.Drawing.Size(50, 20);
            this.txt_meno.TabIndex = 24;
            this.txt_meno.Text = "NAME";
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::bank_ucet.Properties.Resources.delete_user;
            this.pictureBox4.Image = global::bank_ucet.Properties.Resources.delete_user;
            this.pictureBox4.Location = new System.Drawing.Point(267, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bank_ucet.Properties.Resources.back_1;
            this.pictureBox1.Location = new System.Drawing.Point(273, 152);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 221);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_priezvisko);
            this.Controls.Add(this.txt_meno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lable_id);
            this.Controls.Add(this.txt_zoznam);
            this.Controls.Add(this.combox_list);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Delete user";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_zoznam;
        private System.Windows.Forms.ComboBox combox_list;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lable_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label txt_priezvisko;
        private System.Windows.Forms.Label txt_meno;
    }
}