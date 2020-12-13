using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentOneDemo
{
    public partial class Form1 : Form
    {
        private List<CheckItem> OrinItems = new List<CheckItem>();
        private List<CheckItem> CurrItems = new List<CheckItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrinItems.Clear();

            for (int i = 0; i < 1000; i++)
            {
                OrinItems.Add(new CheckItem { Name = $"item {i}", Value = i });
            }

            c1CheckList1.BindingInfo.DataSource = OrinItems;
            c1CheckList1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var txt = textBox1.Text;
            this.CurrItems = OrinItems.AsParallel().WithDegreeOfParallelism(5).Where(m => m.Name.Contains(txt)).ToList();
            this.c1CheckList1.BindingInfo.DataSource = this.CurrItems;
            this.c1CheckList1.Refresh();
        }
    }

    public class CheckItem
    {
        public string Name { get; set; }

        public int Value { get; set; }
    }
}
