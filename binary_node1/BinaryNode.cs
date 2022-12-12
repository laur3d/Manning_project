using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node1
{
    public class BinaryNode<T>
    {
        public T Value { get; private set; }
        public BinaryNode<T> LeftChild { get; private set; }
        public BinaryNode<T> RightChild { get; private set; }

        public BinaryNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public void AddRight (BinaryNode<T> node)
        {
            RightChild = node;
        }

        public void AddLeft( BinaryNode<T> node )
        {
            LeftChild = node;
        }

        public override string ToString()
        {
            return ToString("");

        }

        public string ToString(string spaces)
        {
            string lineRoot = $"{spaces}{Value}: \r\n";

            if(LeftChild != null)
            {
                lineRoot = $"{lineRoot} {LeftChild.ToString($"{spaces}  ")}";

            } else if( RightChild != null)
            {
                lineRoot = $"{lineRoot} {($"{spaces}  None")}  \r\n";

            }


            if (RightChild != null)
            {
                lineRoot = $"{lineRoot} {RightChild.ToString($"{spaces}  ")}";
            }
            else if (LeftChild != null)
            {
                lineRoot = $"{lineRoot} {($"{spaces}  None")} \r\n";

            }

            return lineRoot;
           
        }
    }
}
