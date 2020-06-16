using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _10FamilyDB
{
    public partial class Form1 : Form
    {

        // class fields to control the data access
        private SqlDataAdapter memberDataAdap;
        private DataSet memberDS;
        private SqlCommandBuilder cBuilder;
        private SqlConnection dbConn;
        private SqlCommand dbCmd;
        private string sConnection;
        private string sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void familyDBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familyDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nguyencuDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nguyencuDataSet.FamilyDB' table. You can move, or remove it, as needed.
            this.familyDBTableAdapter.Fill(this.nguyencuDataSet.FamilyDB);


        }


        private void familyDBBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.familyDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nguyencuDataSet);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                //construct our connection class to store 
                // the connectrion string data - provider
                sConnection =
                    "Data Source=stusql-cis151-101-fa19.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
                   "Initial Catalog=nguyencu; User Id=nguyencu; Password=897437";
                dbConn = new SqlConnection(sConnection);

                sql = "SELECT * FROM FamilyDB ORDER" +
                    " BY LastName ASC, FirstName ASC";
                // construct our commang object 
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;

                // tie the commang object to the connection 
                dbCmd.Connection = dbConn;

                //allocate dataadapter
                memberDataAdap = new SqlDataAdapter();
                memberDataAdap.SelectCommand = dbCmd;

                memberDS = new DataSet();
                memberDataAdap.Fill(memberDS, "memberTable");

                dataGridView1.DataSource = memberDS;
                dataGridView1.DataMember = "memberTable";
            }
            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void familyDBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new SqlCommandBuilder(memberDataAdap);
                memberDataAdap.Update(memberDS, "memberTable");

            }
            catch(Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.familyDBTableAdapter.FillByName1(this.nguyencuDataSet.FamilyDB, toolStripTextBox1.Text);
        }
    }
}
