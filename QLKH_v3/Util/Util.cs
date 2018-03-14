using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH_v3.Util
{
    class Util
    {
        public void Show_Message_Error(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Show_Message_Notification(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool Show_Message_YesNo(string title, string message)
        {
            bool check = false;
            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                check = true;
                return check;
            }
            else if (dialogResult == DialogResult.No)
            {
                check = false;
                return check;
            }
            return check;
        }
        public int Cnv_Int(string val)
        {
            int dtrt = 0;
            try
            {
                dtrt =  int.Parse(val.Trim().ToLower());
            }
            catch (Exception)
            {
                dtrt = 0;
            }
            return dtrt;
        }
        public DataTable ConvertToDataTable<T>(IList<T> data)               // chuyển list thành bảng
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
