using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF2e_Probability_Calculator
{
    public partial class ConditionTable : UserControl
    {
        public Conditions conditions = new Conditions();
        public ConditionTable()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 1;
          
            foreach (PropertyInfo prop in typeof(Conditions).GetProperties())
            {
                if(prop.PropertyType.Name == "Boolean")
                {
                    AddBooleanChoice(prop.Name);
                } else
                {
                    AddNumericChoice(prop.Name);
                }
            }           

        }

        private void AddBooleanChoice(string name)
        {
            CheckBox cb = new CheckBox
            {
                Text = "",
                Dock = DockStyle.Fill,
                Name = "cb" + name,
                MaximumSize = new Size(30, 20),
                Tag = name                
            };
            _ = cb.DataBindings.Add("Checked", conditions, name);

            Label lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Name = "lbl" + name,
                Text = name
            };

            tableLayoutPanel1.Controls.Add(lbl);
            tableLayoutPanel1.Controls.Add(cb);
        }

        private void AddNumericChoice(string name)
        {
            NumericUpDown num = new NumericUpDown
            {
                Dock = DockStyle.Fill,
                Name = "num" + name,
                Tag = name,
                Width = 30,
                MaximumSize = new Size(30,20),
                Maximum = 9
            };
            _ = num.DataBindings.Add("Value", conditions, name);

            Label lbl = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Name = "lbl" + name,
                Text = name
            };

            tableLayoutPanel1.Controls.Add(lbl);
            tableLayoutPanel1.Controls.Add(num);
        }
    }
}
