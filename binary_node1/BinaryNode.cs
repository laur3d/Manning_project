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

        public BinaryNode<T>? FindNode(T value)
        {
            BinaryNode<T>? node = null;

            if (Value.Equals(value)) return this;

            if(LeftChild is not null)
            {
                node = LeftChild.FindNode(value);
                if(node != null)
                {
                    return node;
                }
            }

            if (RightChild is not null)
            {
                node = RightChild.FindNode(value);
                if (node != null)
                {
                    return node;
                }
            }

            return node;
        }

        public Queue<BinaryNode<T>> TraversePreorder(Queue<BinaryNode<T>> queue = null)
        {
            if( queue is null)
            {
                queue = new Queue<BinaryNode<T>>();
            }

            queue.Enqueue(this);

            if(LeftChild is not null)
            {
                queue = LeftChild.TraversePreorder(queue);
            }

            if(RightChild is not null)
            {
                queue = RightChild.TraversePreorder(queue);
            }

            return queue;
        }


        public Queue<BinaryNode<T>> TraverseInorder(Queue<BinaryNode<T>> queue = null)
        {
            if (queue is null)
            {
                queue = new Queue<BinaryNode<T>>();
            }

            if (LeftChild is not null)
            {
                queue = LeftChild.TraverseInorder(queue);
            }

            queue.Enqueue(this);

            
            if (RightChild is not null)
            {
                queue = RightChild.TraverseInorder(queue);
            }

            return queue;
        }

        public Queue<BinaryNode<T>> TraversePostorder(Queue<BinaryNode<T>> queue = null)
        {
            if (queue is null)
            {
                queue = new Queue<BinaryNode<T>>();
            }

            if (LeftChild is not null)
            {
                queue = LeftChild.TraversePostorder(queue);
            }

            if (RightChild is not null)
            {
                queue = RightChild.TraversePostorder(queue);
            }

            queue.Enqueue(this);

            return queue;
        }

        public Queue<BinaryNode<T>> TraverseBreadthFirst(Queue<BinaryNode<T>> queue = null, bool skipAdd = false)
        {
            if (queue is null)
            {
                queue = new Queue<BinaryNode<T>>();
            }


            if (!skipAdd)
            {
                queue.Enqueue(this);
            }


            if (LeftChild is not null)
            {
                queue.Enqueue(LeftChild);
               
            }

            if (RightChild is not null)
            {
                queue.Enqueue(RightChild);
            }

            if (LeftChild is not null)
            {
                queue = LeftChild.TraverseBreadthFirst(queue, true);
            }


            if (RightChild is not null)
            {
                queue = RightChild.TraverseBreadthFirst(queue, true);
            }


            return queue;
        }
    }
}
