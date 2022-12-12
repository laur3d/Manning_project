using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node1
{
    public class NaryNode<T>
    {
        public T Value { get; private set; }
        
        public List<NaryNode<T>> Children { get; private set; }

        public NaryNode(T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        public void AddChild(NaryNode<T> node)
        {
            Children.Add(node);
        }

        public override string ToString()
        {
            string nodeValue = Value == null ? "null" : Value.ToString();

            var sb = new StringBuilder();

            foreach (var node in Children)
            {
                sb.Append(" ");
                sb.Append(node.Value.ToString());
            }

            return $"{nodeValue}: {sb.ToString()}";
        }
    }
}
