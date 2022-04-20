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

        public List<Symbol> Get_symbol()
        {
            List<Symbol> list_sym = new List<Symbol>();
            string slovo = Convert.ToString(source_textBox.Text);  
    

            foreach (char Letter in slovo.Distinct().ToArray())
            {
                string str = list_sym.Find(x => x == Letter);
                list_sym.Add(new Symbol(Letter));
                
                //int Count = slovo.Count(chr => chr == Letter);              
                //if (Count > 1)
                //{
                //    Symbol symbol = new Symbol(Letter);
                //    symbol.incremCount();
                //   cryptographic_textBox.Text = ($"Слово состоит из различных символов {Letter} в количестве {Count}");
                //}
             
            }

            return list_sym;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
             Get_symbol();

        }
    }
}
