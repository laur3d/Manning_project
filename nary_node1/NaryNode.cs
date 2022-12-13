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
            //string nodeValue = Value == null ? "null" : Value.ToString();

            //var sb = new StringBuilder();

            //foreach (var node in Children)
            //{
            //    sb.Append(" ");
            //    sb.Append(node.Value.ToString());
            //}

            //return $"{nodeValue}: {sb.ToString()}";
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

        public Queue<NaryNode<T>> TraversePreorder(Queue<NaryNode<T>> queue = null)
        {
            if (queue is null)
            {
                queue = new Queue<NaryNode<T>>();
            }

            queue.Enqueue(this);

            foreach(var child in Children)
            {
                queue = child.TraversePreorder(queue);
            }

            return queue;
        }



        public Queue<NaryNode<T>> TraversePostorder(Queue<NaryNode<T>> queue = null)
        {
            if (queue is null)
            {
                queue = new Queue<NaryNode<T>>();
            }

            foreach (var child in Children)
            {
                queue = child.TraversePostorder(queue);
            }

            queue.Enqueue(this);

            return queue;
        }

        public Queue<NaryNode<T>> TraverseBreadthFirst(Queue<NaryNode<T>> queue = null, bool skipAdd = false)
        {
            if (queue is null)
            {
                queue = new Queue<NaryNode<T>>();
            }


            if (!skipAdd)
            {
                queue.Enqueue(this);
            }

            foreach (var child in Children)
            {
                queue.Enqueue(child);
            }

            foreach (var child in Children)
            {
                queue = child.TraverseBreadthFirst(queue, true);
            }


            return queue;
        }
    }
}
