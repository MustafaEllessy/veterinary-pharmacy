using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace formApplication
{
    class DB
    {
        public static string name = "drugs.accdb";
        public static OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + name + ";Persist Security Info=True");
        public static OleDbCommand command = new OleDbCommand("", connection);
        public static OleDbDataAdapter dataAdapter = new OleDbDataAdapter("", connection);
        public static DataSet ds = new DataSet();
        public static void insertToDB(string tableName, string[] columnsNames,  object[] values  )
        {
            string command = "insert into "+tableName+" (";
            for (int i = 0; i < columnsNames.Length; i++)
            {
                if(i==columnsNames.Length-1)
                {
                    command += (columnsNames[i]);
                    break;
                }
                command += (columnsNames[i] + ", ");
            }
            command += ") ";
            command += "values(";
            for (int i = 0; i < values.Count(); i++)
            {
                if(i== values.Count()-1)
                {
                    if ((values[i]).GetType() != typeof(string))
                    {
                        command += (Convert.ToInt32(values[i]) );
                    }
                    else if (values[i].GetType() == typeof(string))
                    {
                        command +=("'"+ Convert.ToString(values[i])+"'" );
                    }
                    break;

                }

                if ((values[i]).GetType() != typeof(string))
                {
                    command += (Convert.ToInt32(values[i])+", ");
                }
                else if (values[i].GetType() == typeof(string))
                {
                    command += ("'" + Convert.ToString(values[i]) + "'" + ", ");
                }
            }
            command += ") ";
            DB.affectBuild(command);
        }
        public void UploadDataSet()
        {
            DataTable dtVisitor = Data("select * from visitor");
            DataTable dtVisitor_visit = Data("select * from visitor_visit");
            DataTable dtVisit = Data("select * from visit");
            DataTable dtDepartment = Data("select * from department");
            ds.Tables.Add(dtVisitor);
            ds.Tables.Add(dtVisitor_visit);
            ds.Tables.Add(dtVisit);
            ds.Tables.Add(dtDepartment);

        }
        public static void UpdateOnDbs(DataTable dt)
        {
            OleDbCommandBuilder accessCommandBuilder;
            accessCommandBuilder = new OleDbCommandBuilder(dataAdapter);
            dataAdapter.Update(dt);

        }
        public static void changeDB(string name)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + name + ";Persist Security Info=True";
            }
            else System.Windows.Forms.MessageBox.Show("Connection Is Opened With Another Database!");
        }
        public static void open()
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
        }
        public static void close()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
        }
        public static DataTable Data(string dbData)
        {
            command.CommandText = dbData;
            DataTable tbl = new DataTable();
            tbl.Load(command.ExecuteReader());
            return tbl;
        }

        public static void affectBuild(string dbBuilding)
        {
            command.CommandText = dbBuilding;
            command.ExecuteNonQuery();
        }
    }
}
