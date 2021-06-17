using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDemo
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter dAdapt;

        public Form1()
        {
            InitializeComponent();
            initDataSet();
            checkDuplicate();
        }

        public void initDataSet()
        {

            string cnTrs = @"Data Source=.\sqlexpress;Initial Catalog=pubs;Integrated Security=True";

            dAdapt = new SqlDataAdapter("Select * From jobs", cnTrs);
            SqlConnection connection = new SqlConnection(cnTrs);

            SqlCommandBuilder invBulder = new SqlCommandBuilder(dAdapt);

            // string query = "Select * From jobs";
            // connection.Open();
            // SqlCommand command = new SqlCommand(query, connection);
            // DataTable data = new DataTable();
            //// SqlDataAdapter dAdapt = new SqlDataAdapter(command);
            // dAdapt.Fill(data);
            // connection.Close();
            // dtgv1.DataSource = data;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewData();
        }
        public void addNewData()
        {
            checkDuplicate();
            DataRow newjob = myDs.Tables["jobs"].NewRow();
            newjob["job_id"] = int.Parse(this.txtJobID.Text);
            newjob["job_desc"] = this.txtJobDesc.Text;

            newjob["min_lvl"] = int.Parse(this.txtmin.Text);

            newjob["max_lvl"] = int.Parse(this.txtmax.Text);
            myDs.Tables["jobs"].Rows.Add(newjob);



            try {
                dAdapt.Update(myDs.Tables["jobs"]);
            }
            catch (Exception e) {
                MessageBox.Show("Sorry! Error canceling request"+ e.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        public void LoadData()
        {
            try {
                dAdapt.Fill(myDs, "jobs");
                dtgv1.DataSource = myDs.Tables["jobs"];
            }
            catch (Exception e) {
                MessageBox.Show("Can't load data" + e.Message);
                dtgv1.DataSource = null;
                throw;
            }
        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInfo();
        }
        public void updateInfo()
        {
            DataRow[] jobRowToUpDate = myDs.Tables["jobs"].Select(string.Format("job_id = '{0}'", this.txtJobID.Text));
            jobRowToUpDate[0]["max_lvl"] = int.Parse(this.txtmax.Text);
            jobRowToUpDate[0]["min_lvl"] = int.Parse(this.txtmin.Text);
            jobRowToUpDate[0]["job_desc"] = this.txtJobDesc.Text;

            try {
                dAdapt.Update(myDs.Tables["jobs"]);
            }
            catch {
                MessageBox.Show("Sorry! Error canceling request");
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        public void deleteData()
        {
            try {
                foreach (DataGridViewRow item in this.dtgv1.SelectedRows) {
                    dtgv1.Rows.RemoveAt(item.Index);
                }
                dAdapt.Update(myDs.Tables["jobs"]);




            }
            catch (Exception e) {

                MessageBox.Show("Sorry  Error! Canceling request: " + e.Message);
            }
        }

        private void dtgv1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int index = dtgv1.CurrentRow.Index;

            this.txtJobID.Text = dtgv1.Rows[index].Cells[0].Value.ToString();
            this.txtJobDesc.Text = dtgv1.Rows[index].Cells[1].Value.ToString();
            this.txtmin.Text = dtgv1.Rows[index].Cells[2].Value.ToString();
            this.txtmax.Text = dtgv1.Rows[index].Cells[3].Value.ToString();
        }


        public void checkDuplicate()
        {
            for (int i = 0; i < dtgv1.RowCount; i++) //compare data
  {
                var R = dtgv1.Rows[i];
                var V = R.Cells[0].Value.ToString() + R.Cells[1].Value.ToString().ToUpper();
                var DupRows = dtgv1.Rows.Cast<DataGridViewRow>().Skip(i + 1).
                                Where(r => r.Cells[0].Value.ToString() + r.Cells[1].Value.ToString().ToUpper() == V);
                R.Cells[2].Value = (int)R.Cells[2].Value + DupRows.Sum(r => (int)r.Cells[2].Value);

                foreach (var DupRow in DupRows)
                    DupRow.Tag = "Del";
            }

            for (int i = 0; i < dtgv1.RowCount; i++) {
                var R = dtgv1.Rows[i];
                if (R.Tag?.ToString() == "Del") {
                    dtgv1.Rows.Remove(R);
                    i--;
                }
            }
        }


    }
}

