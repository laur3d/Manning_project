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
            return ToString("");
        }

        public string ToString(string spaces)
        {
            string lineRoot = $"{spaces}{Value}: \r\n";

            foreach(var child in Children)
            {
                lineRoot = $"{lineRoot} {child.ToString($"{spaces}  ")}";
            }

            return lineRoot;

        }
        public NaryNode<T>? FindNode(T value)
        {
            NaryNode<T>? node = null;

            if (Value.Equals(value)) return this;

            foreach(var child in Children)
            {
                node = child.FindNode(value);
                if(node is not null)
                {
                    return node;
                }
            }

            return node;
        }
    }
}
