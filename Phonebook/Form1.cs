using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        SqlConnection Conn ;
        SqlCommand Cmd = new SqlCommand();
        SqlDataAdapter Da = new SqlDataAdapter();
        DataSet Ds = new DataSet();
        CurrencyManager Cr;
        int Bfedit;

        public Form1()
        {
            Conn = new SqlConnection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //Dar ghesmat connection string data source system khod ra vared nameed(add data source ,full path data)
            Conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WindowsForm\Phonebook\Phonebook\Tellbook.mdf;Integrated Security=True";
            Conn.Open();
            Fillgrid();
        }

        void Fillgrid(string S = "Select * from Tbltell")
        {
            Cmd.CommandText = S;
            Cmd.Connection = Conn;
            Da.SelectCommand = Cmd;
            Ds.Clear();
            Da.Fill(Ds, "T1");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("Datasource", Ds, "T1");
            txtname.DataBindings.Clear();
            txtname.DataBindings.Add("Text", Ds, "T1.Firstname");
            txtfamily.DataBindings.Clear();
            txtfamily.DataBindings.Add("Text", Ds, "T1.Lastname");
            txttell.DataBindings.Clear();
            txttell.DataBindings.Add("Text", Ds, "T1.Phonenumber");
            txtaddress.DataBindings.Clear();
            txtaddress.DataBindings.Add("Text", Ds, "T1.Address");
            Cr = (CurrencyManager)this.BindingContext[Ds, "T1"];
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Setcurrentrec(Cr.Position + 1);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            Setcurrentrec(0);
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            Setcurrentrec(Cr.Position - 1);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            Setcurrentrec(Cr.Count - 1);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.ReadOnly = false;
            txtfamily.ReadOnly = false;
            txttell.ReadOnly = false;
            txtaddress.ReadOnly = false;
            txtname.Text = "";
            txtfamily.Text = "";
            txttell.Text = "";
            txtaddress.Text = "";
            btnnew.Enabled = false;
            btnsave.Enabled = true;
            txtname.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand C = new SqlCommand();
            C.CommandText = "Insert into Tbltell values(@P1,@P2,@P3,@P4)";
            C.Parameters.AddWithValue("P1", txtname.Text);
            C.Parameters.AddWithValue("P2", txtfamily.Text);
            C.Parameters.AddWithValue("P3", txttell.Text);
            C.Parameters.AddWithValue("P4", txtaddress.Text);
            C.Connection = Conn;

            if (txtname.Text == "" || txtfamily.Text == "" || txttell.Text == "")
            {
                MessageBox.Show("An error occarred! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnsave.Enabled = false;
                btnnew.Enabled = true;
                txtname.ReadOnly = true;
                txtfamily.ReadOnly = true;
                txttell.ReadOnly = true;
                txtaddress.ReadOnly = true;
                txtname.Text = "";
                txtfamily.Text = "";
                txttell.Text = "";
                txtaddress.Text = "";
                btnnew.Focus();
            }

            else
            {
                try
                {
                    C.ExecuteNonQuery();
                }
                catch(Exception m)
                {
                    MessageBox.Show(m.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnsave.Enabled = false;
                    btnnew.Enabled = true;
                    txtname.ReadOnly = true;
                    txtfamily.ReadOnly = true;
                    txttell.ReadOnly = true;
                    txtaddress.ReadOnly = true;
                    txtname.Focus();
                    Fillgrid();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Setcurrentrec(dataGridView1.CurrentCell.RowIndex);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult X= MessageBox.Show("Do you want to delete  '" + txtname.Text + " " + txtfamily.Text + "'?", "Deleting", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (X == DialogResult.No)
                return;

            SqlCommand C2 = new SqlCommand();
            C2.CommandText = "Delete from Tbltell where PhoneNumber=@P1";
            C2.Parameters.AddWithValue("P1", txttell.Text);
            C2.Connection = Conn;
            C2.ExecuteNonQuery();
            Fillgrid();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (btnedit.Text == "&Edit")
            {
                txtname.ReadOnly = false;
                txtfamily.ReadOnly = false;
                txttell.ReadOnly = true;
                txtaddress.ReadOnly = false;
                btnedit.Text = "&Apply";
                txtname.Focus();
                Bfedit = Cr.Position;
            }
            else
            {
                SqlCommand C3 = new SqlCommand();
                C3.CommandText = "Update Tbltell set FirstName=@P1,LastName=@P2,Address=@P3 where PhoneNumber=@P4";
                C3.Parameters.AddWithValue("P1", txtname.Text);
                C3.Parameters.AddWithValue("P2", txtfamily.Text);
                C3.Parameters.AddWithValue("P3", txtaddress.Text);
                C3.Parameters.AddWithValue("P4", txttell.Text);
                C3.Connection = Conn;
                C3.ExecuteNonQuery();
                Fillgrid();
                Setcurrentrec(Bfedit);
                txtname.ReadOnly = true;
                txtfamily.ReadOnly = true;
                txttell.ReadOnly = true;
                txtaddress.ReadOnly = true;
                btnedit.Text = "&Edit";
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string A;
            A = "Select * from Tbltell where " + cmbfeild.Text + " Like'" + txtsearch.Text + "%'";
            Fillgrid(A);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }

        void Setcurrentrec(int Currec)
        {
            if (Currec < 0 || Currec >= Cr.Count)
                return;
            Cr.Position = Currec;
            dataGridView1.CurrentCell = dataGridView1.Rows[Currec].Cells[dataGridView1.CurrentCell.ColumnIndex];
        }

        private void lblname_MouseMove(object sender, MouseEventArgs e)
        {
            lblname.ForeColor = Color.Red;
        }

        private void lblname_MouseLeave(object sender, EventArgs e)
        {
            lblname.ForeColor = Color.Black;
        }

        private void lblfamiy_MouseMove(object sender, MouseEventArgs e)
        {
            lblfamiy.ForeColor = Color.Red;
        }

        private void lblfamiy_MouseLeave(object sender, EventArgs e)
        {
            lblfamiy.ForeColor = Color.Black;
        }

        private void lbltell_MouseMove(object sender, MouseEventArgs e)
        {
            lbltell.ForeColor = Color.Red;
        }

        private void lbltell_MouseLeave(object sender, EventArgs e)
        {
            lbltell.ForeColor = Color.Black;
        }

        private void lbladdress_MouseMove(object sender, MouseEventArgs e)
        {
            lbladdress.ForeColor = Color.Red;
        }

        private void lbladdress_MouseLeave(object sender, EventArgs e)
        {
            lbladdress.ForeColor = Color.Black;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void txttell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbfeild_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbfeild.SelectedIndex!=4)
            {
                btnsearch.Enabled = true;
                txtsearch.ReadOnly = false;
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            Setcurrentrec(dataGridView1.CurrentCell.RowIndex);   
        }

        //Reza-Saneiyan-99121039
    }
}