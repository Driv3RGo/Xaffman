using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaffman
{
    public class Node
    {
        public byte? symbol;                 //Символ
        public int weight;                  //Частота
        public string code;                 //Код символа
        public Node parentNode;             //Родитель
        public Node leftChild;              //Левый потомок
        public Node rightChild;             //Правый потомок

        public Node(byte? symbol, int weight)    
        {
            this.symbol = symbol;
            this.weight = weight;
            leftChild = rightChild = parentNode = null;
            code = "";
        }

        public Node(Node node1, Node node2)     //Соединение 2-х узлов
        {
            code = "";
            parentNode = null;

            if (node1.weight >= node2.weight)
            {
                rightChild = node1;
                leftChild = node2;
                rightChild.parentNode = leftChild.parentNode = this;     
                symbol = null;
                weight = node1.weight + node2.weight;
            }
            else if (node1.weight < node2.weight)
            {
                rightChild = node2;
                leftChild = node1;
                leftChild.parentNode = rightChild.parentNode = this;   
                symbol = null;
                weight = node2.weight + node1.weight;
            }
        }
    }
}
