using System.Data.SqlClient;
using System.Data;
namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=TARAS;Initial Catalog=TestDatabase;Integrated Security=True";
            string sqlQuery = "SELECT * FROM MyLovelySongers";

            DataSet ds = new DataSet();
            SqlConnection connect = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connect);

            dataAdapter.Fill(ds, "Table");
            dataGridView1.DataSource = ds.Tables["Table"];
            
        }
    }
}