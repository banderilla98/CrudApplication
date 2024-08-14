using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace CrudApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=BANDERILLA;Initial Catalog=crudapp;Integrated Security=True;");
            con.Open();
            string deleteQuery = "DELETE FROM crudapp WHERE id=@id";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            if(count > 0)
            {
                MessageBox.Show("Deleted Success!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //validaciones algo asi entendi xd
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("Please fill the form", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=BANDERILLA;Initial Catalog=crudapp;Integrated Security=True;");
                con.Open();
                string insertQuery = "INSERT INTO crudapp (email, name, username, password) VALUES (@email, @name, @username, @password)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Created successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error at creation", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
            SqlConnection con = new SqlConnection("Data Source=BANDERILLA;Initial Catalog=crudapp;Integrated Security=True;");
            string readQuery = "SELECT * FROM crudapp";
            SqlDataAdapter adaptador = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adaptador);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=BANDERILLA;Initial Catalog=crudapp;Integrated Security=True;");
            con.Open();
            string updateQuery = "UPDATE crudapp SET email=@email, name=@name, username=@username, password=@password WHERE id=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0){
                MessageBox.Show("Updated Success!", "info",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
