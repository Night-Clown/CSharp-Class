using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Eating
{
    class DataLoginAccess:DataAccess
    {
        public static string judgeUser(string sql1,string sql2)
        {
            dataCon();
            oledbCon.Open();
            OleDbCommand oleDbCommand = new OleDbCommand(sql1, oledbCon);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataSet ds = new DataSet();
            oleDbDataAdapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                oleDbCommand = new OleDbCommand(sql2, oledbCon);
                oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
                ds.Clear();
                oleDbDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0) return null;
                else return "密码错误";
            }
            else
            {
                return "账号不存在";
            }
        }
    }
}
