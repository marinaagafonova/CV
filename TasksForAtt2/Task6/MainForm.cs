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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AssemblyLibr;

namespace Task6
{
    public partial class MainForm : Form
    {
        AssemblyInfo ai;
        AboutType type;
        public MainForm()
        {
            InitializeComponent();
        }
        public void UpdateClassInf()
        {
            FillComboBox(ClassesCB, ai.GetTypesNames());
        }
        private void UpdType()
        {
            FillComboBox(PropertiesCB, type.GetProperties());
            FillComboBox(MethodsCB, type.GetMethods());
            FillComboBox(InterfacesCB, type.GetInterfaces());
            FillComboBox(ConstructorsCB, type.GetConstructors());
        }
        private void FillComboBox(ComboBox CB, List<string> output)
        {
            CB.Items.Clear();
            foreach (var item in output)
            {
                CB.Items.Add(item);
            }
            CB.SelectedIndex = 0;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(ofd.FileName, Encoding.GetEncoding("windows-1251"));
            }
        }
        
       

        private void openDLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ai = new AssemblyInfo(openFileDialog1.FileName);
                UpdateClassInf();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == null)
                return;
            int index = MethodsCB.SelectedIndex;
            if (index >= 0 && index < type.Methods.Length)
            {
                List<Type> types = type.GetParametersOfMethod(index);
                List<object> param = InputParams(type.Methods[index].GetParameters()); if (param == null)
                    return;
                object ret = type.RunMethod(index, param.ToArray());
                if (ret != null)
                    MessageBox.Show(ret.ToString());
                else
                    MessageBox.Show("");
                UpdType();
            }
        }

        private void NewObjectBttn_Click(object sender, EventArgs e)
        {
            if (type == null)
                return;
            int index = ConstructorsCB.SelectedIndex;
            if (index >= 0 && index < type.Constructors.Length)
            {
                List<Type> types = type.GetParametersOfConstructor(index);
                List<object> param = InputParams(type.Constructors[index].GetParameters());
                if (param == null)
                    return;
                type.RunConstructor(index, param.ToArray());
                UpdType();
            }
        }


        private void ClassesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = new AboutType(ai.types[ClassesCB.SelectedIndex]);
            UpdType();

        }
        List<object> list;
        private List<object> InputParams(ParameterInfo[] types)
        {
            foreach (var item in types)
            {
                if (!(item.ParameterType == typeof(int) || item.ParameterType == typeof(string) || item.ParameterType == typeof(bool) || item.ParameterType == typeof(double)))
                    return null;
            }
            if(list==null||list.Count ==0)
            {
                list = new List<object>();
                List<string> strlist = new List<string>();
                InPutForm inputF = new InPutForm(types);
                if (inputF.ShowDialog() == DialogResult.OK)
                {
                    strlist = inputF.strprop;
                }
                int i = 0;
                foreach (var item in types)
                {
                    if (item.ParameterType == typeof(int))
                        list.Add(Convert.ToInt32(strlist[i]));
                    if (item.ParameterType == typeof(string))
                        list.Add(strlist[i]);
                    if (item.ParameterType == typeof(bool))
                        list.Add(Convert.ToBoolean(strlist[i]));
                    if (item.ParameterType == typeof(double))
                        list.Add(Convert.ToDouble(strlist[i]));
                    i++;
                }
            }
           
            return list;
        }

    }
}
