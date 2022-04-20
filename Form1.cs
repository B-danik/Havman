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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
