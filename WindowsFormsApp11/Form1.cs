using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public static List<string> checkedList = new List<string>();
        Form2 form2=new Form2();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedList.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedList.Add(item.ToString());
            }

            form2.ShowDialog();
        }
    }
}
