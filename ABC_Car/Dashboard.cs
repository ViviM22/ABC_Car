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

namespace ABC_Car
{
    public partial class Dashboard : Form
    {
        string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txtToday.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LoadNewOrdersCount();
            LoadPendingOrdersCount();
            LoadCarsAvailableCount();
        }
        private void LoadNewOrdersCount()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "SELECT COUNT(*) FROM Orders WHERE CAST(OrderDate AS DATE) = @today";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@today", today);
                var count = cmd.ExecuteScalar();
                txtNewOrders.Text = count.ToString();
            }
        }
        private void LoadPendingOrdersCount()
        {
            string query = "SELECT COUNT(*) FROM Orders WHERE Status = 'Pending'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                var count = cmd.ExecuteScalar();
                txtPendingOrders.Text = count.ToString();
            }
        }
        private void LoadCarsAvailableCount()
        {
            string query = "SELECT COUNT(*) FROM Cars WHERE Status1 = 'Available'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                var count = cmd.ExecuteScalar();
                txtCarsAvailable.Text = count.ToString();
            }
        }

        private void txtPendingOrders_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
