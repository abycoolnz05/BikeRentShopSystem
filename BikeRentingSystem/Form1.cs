using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BikeRentingSystem
{
    public partial class Form1 : Form
    {
        public static string connString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(connString);
        int CustId = 0;
        int BikeID = 0;
        int RentedBikeID = 0;
        public DatabaseManager Databasemanager = new DatabaseManager(); //instantiate database manager class
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewCustomer.DataSource = GetCustomersList();
            dataGridViewBikes.DataSource = GetBikesList();
            dataGridViewRentals.DataSource = GetRentalsList();
            FillDataGridviewCustomers();
            FillDataGridviewBikes();
            FillDataGridviewRentalBikes();
        }

        private DataTable GetCustomersList()    // 1. Customers Database
        {
            using (SqlCommand sqlcmd = new SqlCommand(" SELECT * from Customer ", sqlconn))
            {
                DataTable dtCustomers = new DataTable();
                sqlconn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtCustomers.Load(reader);
                sqlconn.Close();
                return dtCustomers;
            }
        }
        private DataTable GetBikesList()    //2. Bikes Database
        {
            using (SqlCommand sqlcmd = new SqlCommand(" SELECT * from Bikes ", sqlconn))
            {
                DataTable dtBikes = new DataTable();
                sqlconn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtBikes.Load(reader);
                sqlconn.Close();
                return dtBikes;
            }
        }
        private DataTable GetRentalsList()    //3. Rental Bikes Database
        {

            using (SqlCommand sqlcmd = new SqlCommand("SELECT FirstName, LastName, Address, Title, RentalCost, Date_Rented, Date_Returned FROM Customer t1 INNER JOIN RentedBikes t2 ON t1.CustId = t2.CustIdFK INNER JOIN Bikes t3 ON t3.BikeID = t2.BikeIDFK", sqlconn))
            {
                DataTable dtRentalBikes = new DataTable();
                sqlconn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                dtRentalBikes.Load(reader);
                sqlconn.Close();
                return dtRentalBikes;
            }
        }
        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewBikes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void IssueBike()               // Issue Bike Function
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("IssueBike", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                    sqlcmd.Parameters.AddWithValue("@mode", "Issue");
                    sqlcmd.Parameters.AddWithValue("@RentedBikeID", 0);
                    sqlcmd.Parameters.AddWithValue("@first_name", dataGridViewCustomer.CurrentRow.Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@last_name", dataGridViewCustomer.CurrentRow.Cells[2].Value);
                    sqlcmd.Parameters.AddWithValue("@cust_address", dataGridViewCustomer.CurrentRow.Cells[3].Value);
                    sqlcmd.Parameters.AddWithValue("@Bike_title", dataGridViewBikes.CurrentRow.Cells[1].Value);
                    sqlcmd.Parameters.AddWithValue("@rental_cost", dataGridViewBikes.CurrentRow.Cells[5].Value);
                    sqlcmd.Parameters.AddWithValue("@dateRented", DateTime.Now);
                    sqlcmd.Parameters.AddWithValue("@dateReturned", DBNull.Value);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show(" Add Sucessful in Rental Database ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " : Error ! ");

            }
            sqlconn.Close();
        }

        private void btnIssueBike_Click(object sender, EventArgs e)         //Issue Bike Button
        {
            IssueBike();
        }

        public void ReturnBike()               // Return Bike Function
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("ReturnBike", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                    sqlcmd.Parameters.AddWithValue("@mode", "Return");

                    sqlcmd.Parameters.AddWithValue("@RentedBikeID", RentedBikeID);
                    sqlcmd.Parameters.AddWithValue("@dateReturned", DateTime.Now);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show(" Return Sucessful ! ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " : Error ! ");
            }
            sqlconn.Close();
        }

        public void btnReturnBike_Click(object sender, EventArgs e)        //Return Bike Button
        {
            ReturnBike();
        }


        private void tabPageCustomers_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBikes_Click(object sender, EventArgs e)
        {

        }

        private void AddCustbtn_Click(object sender, EventArgs e) // ADD Customer btn, changes to EDIT when editing query
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    if (AddCustbtn.Text == "Add Customer")
                    {
                        SqlCommand sqlcmd = new SqlCommand("CustAddorEdit", sqlconn);  // Sql coommand is used to enter data
                        sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                        sqlcmd.Parameters.AddWithValue("@mode", "Add");
                        sqlcmd.Parameters.AddWithValue("@CustId", 0);
                        sqlcmd.Parameters.AddWithValue("@firstname", textBoxFname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@lastname", textBoxLname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Add Sucessful in Database ! ");
                    }
                    else
                    {
                        SqlCommand sqlcmd = new SqlCommand("CustAddorEdit", sqlconn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlcmd.Parameters.AddWithValue("@CustId", CustId);
                        sqlcmd.Parameters.AddWithValue("@firstname", textBoxFname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@lastname", textBoxLname.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@phone", textBoxPhone.Text.Trim());
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Edit! Sucessful in Database ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error Message ", ex.Message);
            }
            sqlconn.Close();
        }
        private void AddBikebtn_Click(object sender, EventArgs e)  // ADD Bike btn, changes to EDIT when editing query
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                    if (AddBikebtn.Text == "Add Bike")
                    {
                        SqlCommand sqlcmd = new SqlCommand("BikesAddorEdit", sqlconn);  // Sql coommand is used to enter data
                        sqlcmd.CommandType = CommandType.StoredProcedure; // used to store  procedures
                        sqlcmd.Parameters.AddWithValue("@mode", "Add");
                        sqlcmd.Parameters.AddWithValue("@BikeId", 0);
                        sqlcmd.Parameters.AddWithValue("@title", textBoxTitle.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@year", textBoxYear.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@type", textBoxType.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rating", textBoxRating.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rentalcost", textBoxRentalCost.Text.Trim());

                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Add Sucessful in Customer Database ! ");
                    }
                    else
                    {
                        SqlCommand sqlcmd = new SqlCommand("BikesAddorEdit", sqlconn);
                        sqlcmd.CommandType = CommandType.StoredProcedure;

                        sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlcmd.Parameters.AddWithValue("@BikeId", BikeID);
                        sqlcmd.Parameters.AddWithValue("@title", textBoxTitle.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@year", textBoxYear.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@type", textBoxType.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rating", textBoxRating.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@rentalcost", textBoxRentalCost.Text.Trim());
                        

                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show(" Edit! Sucessful in Bikes Database ");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error Message ", ex.Message);
            }
            sqlconn.Close();                                                 // *****SEARCH FUNCTIONS ALL Start *****
        }
        public void FillDataGridviewCustomers()  //Search function for Customer Database
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("CustViewOrSearch", sqlconn);// Data Adapter is used to retrieve data 
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@CustName", textSearch.Text.Trim());
                DataTable dtSearch = new DataTable();
                sqlDa.Fill(dtSearch);                                      // search data is stored in dataTable search
                dataGridViewCustomer.DataSource = dtSearch;
                sqlconn.Close();
            }
        }

        public void FillDataGridviewBikes()  //Search function for Bikes Database
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("BikesViewOrSearch", sqlconn);// Data Adapter is used to retrieve data 
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@RentalBikeName", textSearch.Text.Trim());
                DataTable dtSearch = new DataTable();
                sqlDa.Fill(dtSearch);  // search data is stored in dataTable search
                dataGridViewBikes.DataSource = dtSearch;
                sqlconn.Close();
            }
        }
        public void FillDataGridviewRentalBikes()  //Search function fos Database
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("RentalBikesViewOrSearch", sqlconn);// Data Adapter is used to retrieve data 
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@RentalBikeName", textSearch.Text.Trim());
                DataTable dtSearch = new DataTable();
                sqlDa.Fill(dtSearch);// search data is stored in dataTable search
                dataGridViewRentals.DataSource = dtSearch;
                dataGridViewRentals.Columns[1].Visible = false;
                dataGridViewRentals.Columns[2].Visible = false;
                sqlconn.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e) //Search Button with functions
        {
            try
            {
                FillDataGridviewCustomers();
                FillDataGridviewBikes();
                FillDataGridviewRentalBikes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error Message ", ex.Message);
            }                                                                   // *****SEARCH FUNCTIONS ALL End******
        }

        private void dataGridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow.Index != -1)
            {
                CustId = Convert.ToInt32(dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString());
                textBoxFname.Text = dataGridViewCustomer.CurrentRow.Cells[1].Value.ToString();
                textBoxLname.Text = dataGridViewCustomer.CurrentRow.Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridViewCustomer.CurrentRow.Cells[3].Value.ToString();
                textBoxPhone.Text = dataGridViewCustomer.CurrentRow.Cells[4].Value.ToString();
                AddCustbtn.Text = " Update Customer";
                DeleteCustbtn.Enabled = true;
            }
        }

        private void DataGridViewCustomer_DoubleClick(object sender, EventArgs e)// Customer Database edit Query
        {
           
        }

        private void dataGridViewBikes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Bikes Database Edit
        {
            if (dataGridViewBikes.CurrentRow.Index != -1)
            {
                BikeID = Convert.ToInt32(dataGridViewBikes.CurrentRow.Cells[0].Value.ToString());
                textBoxTitle.Text = dataGridViewBikes.CurrentRow.Cells[1].Value.ToString();
                textBoxYear.Text = dataGridViewBikes.CurrentRow.Cells[2].Value.ToString();
                textBoxType.Text = dataGridViewBikes.CurrentRow.Cells[3].Value.ToString();
                textBoxRating.Text = dataGridViewBikes.CurrentRow.Cells[4].Value.ToString();
                textBoxRentalCost.Text = dataGridViewBikes.CurrentRow.Cells[5].Value.ToString();
                
                AddBikebtn.Text = " Update Bike";
                DeleteBikebtn.Enabled = true;
            }
        }

        private void dataGridViewRentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //RentedBikeID = Convert.ToInt32(dataGridViewRentals.CurrentRow.Cells[0].Value.ToString());
            //textBoxReturnDate.Text = dataGridViewRentals.CurrentRow.Cells[9].Value.ToString();

        }

        private void DeleteCustbtn_Click(object sender, EventArgs e)// DELETE CUSTOMER BUTTON
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();

                    SqlCommand sqlcmd = new SqlCommand("CustDelete", sqlconn);// Sql coommand is used to enter data
                    sqlcmd.CommandType = CommandType.StoredProcedure;// used to store  procedures                  
                    sqlcmd.Parameters.AddWithValue("@CustId", CustId);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show(" Delete! Sucessful in Database ! ");
                    FillDataGridviewCustomers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error Message ", ex.Message);
            }
        }

        private void DeleteBikebtn_Click(object sender, EventArgs e)// DELETE Bike BUTTON
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();

                SqlCommand sqlcmd = new SqlCommand("BikesDelete", sqlconn);// Sql coommand is used to enter data
                sqlcmd.CommandType = CommandType.StoredProcedure;// StoredProcedure is used to store  procedures

                sqlcmd.Parameters.AddWithValue("@BikeId", BikeID);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(" Delete! Sucessful in Database ! ");
                FillDataGridviewBikes();
            }
        }


        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCustbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
