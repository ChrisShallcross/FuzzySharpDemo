using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzySharp;

namespace FuzzySharpDemo
{
    public partial class Form1 : Form
    {
        private IList<string> cedantNames;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCedantNames();
            PopulateEntityNames();
        }

        private void LoadCedantNames()
        {
            cedantNames  = new List<string>();

            string line;
            var file = new System.IO.StreamReader("CedantNames.txt");
            while ((line = file.ReadLine()) != null)
            {
                cedantNames.Add(line.Trim());
            }
        }

        private void PopulateEntityNames()
        {
            cbEntityName.Items.Clear();

            string line;
            var file = new System.IO.StreamReader("EntityNames.txt");
            while ((line = file.ReadLine()) != null)
            {
                cbEntityName.Items.Add(line.Trim());
            }

            cbEntityName.SelectedItem = cbEntityName.Items[0];
        }

        private void cbEntityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvResults.Items.Clear();

            var entityName = cbEntityName.SelectedItem.ToString();

            // Can use limit or add Where(l => l.Score > 50)
            var results = Process.ExtractTop(entityName, cedantNames, limit: 20);
//            var results = Process.ExtractSorted(entityName, cedantNames).ToList();
            foreach (var item in results) {
                lvResults.Items.Add(item.Value).SubItems.Add(item.Score.ToString());
            }
        }
    }
}
