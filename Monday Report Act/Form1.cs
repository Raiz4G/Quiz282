using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monday_Report_Act
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f=new OpenFileDialog();
            if(f.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Clear();
                List<string> lines=new List<string>();
                using(StreamReader r=new StreamReader(f.OpenFile()))
                {   
                    string line;
                    while((line=r.ReadLine())!=null)
                    {
                        listBox1.Itmes.Add(line);
                    }
                }
            }
        }
        
    }
}
