using System.Data;
using System.Data.SqlClient;

namespace Singleton.Data
{
    public class DataController
    {
        private const string CONNECTION_STRING = "Data Source=name.db";

        private static DataController _instance;
        private SqlConnection _connection;

        public static DataController Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DataController();
                }
                return _instance;
            }
        }

        public DataController()
        {
            _connection = new SqlConnection(CONNECTION_STRING);
            _connection.Open();
        }

        public DataView GetDataView(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("DataTable");
            dataAdapter.Fill(dataTable);
            return dataTable.DefaultView;
        }
    }
}