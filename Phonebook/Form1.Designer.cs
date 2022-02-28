
namespace Phonebook
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblfamiy = new System.Windows.Forms.Label();
            this.lbltell = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttell = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbfeild = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblname.Location = new System.Drawing.Point(12, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 28);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            this.lblname.MouseLeave += new System.EventHandler(this.lblname_MouseLeave);
            this.lblname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblname_MouseMove);
            // 
            // lblfamiy
            // 
            this.lblfamiy.AutoSize = true;
            this.lblfamiy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblfamiy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblfamiy.Location = new System.Drawing.Point(12, 37);
            this.lblfamiy.Name = "lblfamiy";
            this.lblfamiy.Size = new System.Drawing.Size(61, 19);
            this.lblfamiy.TabIndex = 1;
            this.lblfamiy.Text = "Family:";
            this.lblfamiy.MouseLeave += new System.EventHandler(this.lblfamiy_MouseLeave);
            this.lblfamiy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblfamiy_MouseMove);
            // 
            // lbltell
            // 
            this.lbltell.AutoSize = true;
            this.lbltell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbltell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltell.Location = new System.Drawing.Point(12, 65);
            this.lbltell.Name = "lbltell";
            this.lbltell.Size = new System.Drawing.Size(41, 19);
            this.lbltell.TabIndex = 2;
            this.lbltell.Text = "Tell:";
            this.lbltell.MouseLeave += new System.EventHandler(this.lbltell_MouseLeave);
            this.lbltell.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbltell_MouseMove);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbladdress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbladdress.Location = new System.Drawing.Point(12, 92);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(72, 19);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address:";
            this.lbladdress.MouseLeave += new System.EventHandler(this.lbladdress_MouseLeave);
            this.lbladdress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbladdress_MouseMove);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(79, 9);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(211, 20);
            this.txtname.TabIndex = 4;
            // 
            // txttell
            // 
            this.txttell.Location = new System.Drawing.Point(79, 65);
            this.txttell.Name = "txttell";
            this.txttell.ReadOnly = true;
            this.txttell.Size = new System.Drawing.Size(211, 20);
            this.txttell.TabIndex = 6;
            this.txttell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttell_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(79, 94);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(211, 124);
            this.txtaddress.TabIndex = 7;
            // 
            // txtfamily
            // 
            this.txtfamily.Location = new System.Drawing.Point(79, 39);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.ReadOnly = true;
            this.txtfamily.Size = new System.Drawing.Size(211, 20);
            this.txtfamily.TabIndex = 5;
            // 
            // btnnew
            // 
            this.btnnew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnnew.Location = new System.Drawing.Point(16, 224);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(64, 39);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "&New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsave.Location = new System.Drawing.Point(86, 224);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(64, 39);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnedit.Location = new System.Drawing.Point(156, 224);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(64, 39);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "&Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btndelete.Location = new System.Drawing.Point(226, 224);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(64, 39);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnfirst.Location = new System.Drawing.Point(16, 269);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(64, 39);
            this.btnfirst.TabIndex = 12;
            this.btnfirst.Text = "&First";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnlast
            // 
            this.btnlast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnlast.Location = new System.Drawing.Point(86, 269);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(64, 39);
            this.btnlast.TabIndex = 13;
            this.btnlast.Text = "&Last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnnext.Location = new System.Drawing.Point(156, 269);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(64, 39);
            this.btnnext.TabIndex = 14;
            this.btnnext.Text = "Nex&t";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnpreview.Location = new System.Drawing.Point(226, 269);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(64, 39);
            this.btnpreview.TabIndex = 15;
            this.btnpreview.Text = "P&review";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(350, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search By:";
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // cmbfeild
            // 
            this.cmbfeild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfeild.FormattingEnabled = true;
            this.cmbfeild.Items.AddRange(new object[] {
            "FirstName",
            "LastName",
            "PhoneNumber",
            "Address"});
            this.cmbfeild.Location = new System.Drawing.Point(440, 7);
            this.cmbfeild.Name = "cmbfeild";
            this.cmbfeild.Size = new System.Drawing.Size(193, 21);
            this.cmbfeild.TabIndex = 17;
            this.cmbfeild.SelectedIndexChanged += new System.EventHandler(this.cmbfeild_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(350, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search for:";
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(440, 39);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.ReadOnly = true;
            this.txtsearch.Size = new System.Drawing.Size(193, 20);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Enabled = false;
            this.btnsearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsearch.Location = new System.Drawing.Point(677, 9);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(80, 47);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(403, 214);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(769, 325);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbfeild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txttell);
            this.Controls.Add(this.txtfamily);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbltell);
            this.Controls.Add(this.lblfamiy);
            this.Controls.Add(this.lblname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblfamiy;
        private System.Windows.Forms.Label lbltell;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttell;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfamily;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbfeild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

