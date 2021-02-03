using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Bubble Sort";
        }
         
  
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("") || textBox1.Text.Equals(null))
            {
                MessageBox.Show("Invalid Input");
            }
            else

            {
              bubblesort b = new bubblesort();
              char[] j = textBox1.Text.ToCharArray();
              label1.Text = "Sorted: "+ String.Join(" ",b.studs(j));
             
            }
            

       
        }
    }
}
