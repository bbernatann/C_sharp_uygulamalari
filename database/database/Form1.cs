using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\BERNA TAN\\Documents\\Database1.accdb\"");

        private void showInformation()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Information", Aconnection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            showInformation();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            OleDbCommand save = new OleDbCommand("INSERT INTO Information (Name,Surname,Mail,mPosition) VALUES (@p1,@p2,@p3,@p4)",Aconnection);
            save.Parameters.AddWithValue("@p1",txtName.Text);
            save.Parameters.AddWithValue("@p2", txtSurname.Text);
            save.Parameters.AddWithValue("@p3", txtMail.Text);
            save.Parameters.AddWithValue("@p4", comboBox1.Text);

            save.ExecuteNonQuery();
            Aconnection.Close();
            MessageBox.Show("Saved in the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            comboBox1.ResetText();

            showInformation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            OleDbCommand delete = new OleDbCommand("DELETE FROM Information Where ID=@p1",Aconnection);
            delete.Parameters.AddWithValue("@p1",txtId);
            delete.ExecuteNonQuery();
            Aconnection.Close();
            MessageBox.Show("Deleted in the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            comboBox1.ResetText();

            showInformation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Aconnection.Open();
            OleDbCommand update = new OleDbCommand("UPDATE Information SET Name=@p1,Surname=@p2,Mail=@p3,mPosition=@p4 WHERE ID=@p5",Aconnection);
            update.Parameters.AddWithValue("@p1", txtName.Text);
            update.Parameters.AddWithValue("@p2",txtSurname.Text);
            update.Parameters.AddWithValue("@p3", txtMail.Text);
            update.Parameters.AddWithValue("@p4", comboBox1.Text);
            update.Parameters.AddWithValue("@p5", txtId.Text);

            update.ExecuteNonQuery();
            Aconnection.Close();
            MessageBox.Show("Updated in the system.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            comboBox1.ResetText();
            
            showInformation();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
        }
    }
}