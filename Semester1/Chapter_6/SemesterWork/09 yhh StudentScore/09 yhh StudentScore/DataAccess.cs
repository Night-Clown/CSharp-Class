using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace _09_yhh_StudentScore
{
    class DataAccess
    {
        private string strDSN;
        OleDbConnection oledbCon;
        public void dataCon()
        {
            strDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + "\\Student.accdb";
            oledbCon = new OleDbConnection(strDSN);
        }
        public DataSet getDataSet(string sql)
        {
            oledbCon.Open();
            OleDbCommand oledbCmd = new OleDbCommand(sql, oledbCon);
            OleDbDataAdapter oledbA = new OleDbDataAdapter(oledbCmd);
            DataSet ds = new DataSet();
            oledbA.Fill(ds);
            oledbCon.Close();
            return ds;
        }
        public bool sqlExec(string sql)
        {
            try
            {
                oledbCon.Open();
            }
            catch
            {
                MessageBox.Show("数据库未连接");
            }
            try
            {
                OleDbCommand oledbCmd = new OleDbCommand(sql, oledbCon);
                oledbCmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "提示");
                return false;
            }
            finally
            {
                oledbCon.Close();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
            }
            return true;
        }
    }
}
