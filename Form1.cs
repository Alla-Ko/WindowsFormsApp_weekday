using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_weekday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ukrainianCulture = new CultureInfo("uk-UA");
            dayOfWeek = dateTimePicker1.Value.DayOfWeek;
            label1.Text = ukrainianCulture.DateTimeFormat.GetDayName(dayOfWeek);
        }
        CultureInfo ukrainianCulture;
        DayOfWeek dayOfWeek;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            dayOfWeek = dateTimePicker1.Value.DayOfWeek;
            label1.Text = ukrainianCulture.DateTimeFormat.GetDayName(dayOfWeek); 
        }
    }
}
