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
            string left = LeftChild == null ? "null" : LeftChild.Value.ToString();

            string right = RightChild == null ? "null" : RightChild.Value.ToString();

            string nodeValue = Value == null ? "null" : Value.ToString();

            return $"{nodeValue}: {left} {right}";
        }
    }
}
