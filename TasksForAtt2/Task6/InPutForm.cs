using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Task6
{
    public partial class InPutForm : Form
    {
        public InPutForm()
        {
            InitializeComponent();
        }
        public List<string> strprop;

        public InPutForm(ParameterInfo[] types)
        {
            InitializeComponent();
            BooksDGV.RowCount = types.Length;
            for (int i = 0; i < types.Length; i++)
            {
                BooksDGV[0, i].Value = types[i].Name;
            }
            strprop = new List<string>();
            BooksDGV.ColumnCount = 2;
        }

        private void DoBttn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BooksDGV.RowCount; i++)
                strprop.Add(BooksDGV[1, i].Value.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
