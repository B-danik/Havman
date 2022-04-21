using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havman
{
    public partial class Form1 : Form
    {
        public class Symbol
        {
            protected char symbol;
            protected int count;
            public Symbol(char symbol)
            {
                this.symbol = symbol;
                count = 1;
            }
            public Symbol(String symbol)
            {
                this.symbol = symbol[0];
                count = 1;
            }
            public char getSymbol()
            {
                return symbol;
            }
            public int getCount()
            {
                return count;
            }
            public void incremCount()
            {
                count++;
            }
        }
        public Form1()
        {
            InitializeComponent();

            // dgv Simbol kod
            dgv.ColumnCount = 2;
            dgv.Columns[0].Width = dgv.Width / 2;
            dgv.Columns[1].Width = dgv.Width / 2;
            dgv.Columns[0].Name = "Simbol";
            dgv.Columns[1].Name = "Kod";

            // dgv 
            dgv_name.ColumnCount = 7;
            for (int i = 0;i<7;i++)
            dgv_name.Columns[i].Width = dgv_name.Width / 7;       

            dgv_name.Columns[0].Name = "№";
            dgv_name.Columns[1].Name = "Символ";
            dgv_name.Columns[2].Name = "Чистота";
            dgv_name.Columns[3].Name = "Левый";
            dgv_name.Columns[4].Name = "Правый";
            dgv_name.Columns[5].Name = "Предок";
            dgv_name.Columns[6].Name = "Действие";
           

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {

        }
    }
}
