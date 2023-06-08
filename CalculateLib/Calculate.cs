using System;
using DataTable = System.Data.DataTable;
using DataColumn = System.Data.DataColumn;
using DataRow = System.Data.DataRow;

namespace CalculateLib
{
    public class Calculate
    {
        public string Evaluate(string expression)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("expression", typeof(string), expression));
            DataRow dataRow = dataTable.NewRow();
            dataTable.Rows.Add(dataRow);
            return (string)dataRow["expression"];
        }
    }
}