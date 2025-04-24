using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionOdemeSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string projeYolu = @"C:\Users\serce\Desktop\Odevler\ReflectionOdemeSistemi\ReflectionOdemeSistemi";

            if (!Directory.Exists(projeYolu))
            {
                MessageBox.Show("Klasör yolu bulunamadı.");
                return;
            }

            foreach (var klasor in Directory.GetDirectories(projeYolu))
            {
                listBox1.Items.Add("📁 " + Path.GetFileName(klasor));

                var classlar = Directory.GetFiles(klasor, "*.cs")
                                        .SelectMany(file => File.ReadLines(file)
                                                                .Where(line => line.Trim().StartsWith("public class"))
                                                                .Select(line => line.Split(' ')[2]))
                                        .ToList();

                foreach (var className in classlar)
                {
                    listBox1.Items.Add("   📄 " + className);
                }
            }
        }
    }
}

