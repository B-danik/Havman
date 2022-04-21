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
        public class Node
        {
            public int num { get; set; }
            public string str { get; set; }
            public int hz { get; set; }
            public int left { get; set; }
            public int right{ get; set; }
            public int parent { get; set; }
            public int action { get; set; }

            public Node(int num, Symbol symbol) 
            {
                this.num = num;
                str = ""+ symbol.getSymbol();
                hz = symbol.getCount();
            }
            public Node(int num,string str,int hz,int left,int right)
            {
                this.num = num;
                this.str = str;
                this.hz = hz;
                this.left = left;
                this.right = right;
                this.parent = parent;
            }
            public static List<Node> convertList(List<Symbol> symbols)
            {
                List<Node> nodes = new List<Node>();
                int i = 1;
                foreach(Symbol sym in symbols)
                    nodes.Add(new Node(i++, sym));
                return nodes;
            }



        }
        public Form1()
        {
            InitializeComponent();
        }

        public List<Symbol> getSymbol()
        {
            List<Symbol> listSym = new List<Symbol>();
            string text = Convert.ToString(source_textBox.Text);
            foreach (char letter in text)
            {
                Predicate<Symbol> isHasOnList = (Symbol symbol) => symbol.getSymbol() == letter;
                int index = listSym.FindIndex(isHasOnList);

                if (index >= 0)
                {
                    listSym[index].incremCount();
                }
                else
                {
                    listSym.Add(new Symbol(letter));
                }
                
            }

            return listSym;
        }
        public List<Node> havmen()
        {
            List<Node> listNode = Node.convertList(getSymbol());
            int indexAction = 1;
            int minHz;
            while (true)
            {
                minHz = source_textBox.Text.Length;
                int indexFirst=-1;
                int i = 0;
                foreach(Node node in listNode)
                {
                    
                    if (node.action == 0)
                    {
                        if (node.hz < minHz)
                        {
                            minHz = node.hz;
                            indexFirst = i;
                        }
                    }
                    i++;
                }
                if (indexFirst == -1)
                    break;
                listNode[indexFirst].action = -1;

                minHz = source_textBox.Text.Length;
                int indexSecond = -1;
                i = 0;

                foreach (Node node in listNode)
                {

                    if (node.action == 0)
                    {
                        if (node.hz < minHz)
                        {
                            minHz = node.hz;
                            indexSecond = i;
                        }
                    }
                    i++;
                }
                if (indexSecond == -1)
                    break;
               
                string firstSecondStr = listNode[indexFirst].str + listNode[indexSecond].str;
                int firstSecondHz = listNode[indexFirst].hz + listNode[indexSecond].hz;

                int left, right;
                if (listNode[indexFirst].hz > listNode[indexSecond].hz)
                {
                    right = indexFirst + 1;
                    left = indexSecond + 1;
                }
                else
                {
                    right = indexSecond + 1;
                    left = indexFirst + 1;
                }

                listNode[indexFirst].parent = listNode.Count+1;
                listNode[indexSecond].parent = listNode.Count+1;

                listNode[indexFirst].action = indexAction;
                listNode[indexSecond].action = indexAction;
                indexAction++;

                listNode.Add(new Node(
                    listNode.Count + 1,
                    firstSecondStr,
                    firstSecondHz,
                    left,
                    right
                    ));
            }
            return listNode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {

        }

        private void kod_button_Click(object sender, EventArgs e)
        {
            havmen();
        }
    }
}
