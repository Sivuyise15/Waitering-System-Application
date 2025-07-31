using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteringSystem.Properties;

namespace WaiteringSystem.Database
{
    public class BD
    {
        public string strConn = Settings.Default.EmployeeDatabaseConnectionString;
        public SqlConnection cnMain;
        public DataSet dsMain;
        public SqlDataAdapter daMain;

        public BD() {
            using (cnMain = new SqlConnection(strConn))
            {
                try
                {
                    cnMain.Open();
                    this.dsMain = new DataSet();

                    cnMain.Close();
                }
                catch (Exception e) {
                    Console.WriteLine("Error occured when opening the connection " + e.ToString());
                }
            }
        }

        public void FillDataSet(string aSQLstring, string aTable)
        {
            try {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " " + e.StackTrace);
            }
        }

        public bool UpdateDataSource(string sqlLocal, string table) {
            bool success;
            try {
                cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();

                SqlCommand selectCommand = new SqlCommand(sqlLocal, cnMain);
                daMain.SelectCommand = selectCommand;

                daMain.Fill(dsMain, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + " " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;

        }
    }
}
