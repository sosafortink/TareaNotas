using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Calcularbutton1_Click(object sender, EventArgs e)
        {
            decimal parcial1 = Convert.ToDecimal(textBox1.Text);
            decimal parcial2 = Convert.ToDecimal(textBox2.Text);
            decimal parcial3 = Convert.ToDecimal(textBox3.Text);
            decimal parcial4 = Convert.ToDecimal(textBox4.Text);

            decimal promedio = await PromedioAsync(parcial1, parcial2, parcial3, parcial4);

            MessageBox.Show($"El promedio de los 4 parciales es: {promedio}");
        }

    private async Task<decimal> PromedioAsync(decimal p1, decimal p2, decimal p3, decimal p4)
    {
        decimal promedio = await Task.Run(() => { return (p1 + p2 + p3 + p4) / 4; });

        return promedio;
    }
}
}