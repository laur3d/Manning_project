// See https://aka.ms/new-console-template for more information
using nary_node1;

Console.WriteLine("Hello, World!");

// Craete nodes 
NaryNode<string> root = new("Root");
NaryNode<string> NodeA = new("A");
NaryNode<string> NodeB = new("B");
NaryNode<string> NodeC = new("C");
NaryNode<string> NodeD = new("D");
NaryNode<string> NodeE = new("E");
NaryNode<string> NodeF = new("F");
NaryNode<string> NodeG = new("G");
NaryNode<string> NodeH = new("H");
NaryNode<string> NodeI = new("I");

// create hierarchy

NodeF.AddChild(NodeH);
NodeF.AddChild(NodeI);

NodeC.AddChild(NodeF);

NodeD.AddChild(NodeG);

NodeA.AddChild(NodeD);
NodeA.AddChild(NodeE);

root.AddChild(NodeA);
root.AddChild(NodeB);
root.AddChild(NodeC);

Console.WriteLine(root);

Console.WriteLine(NodeA);

// Find some values.
FindValue(root, "Root");
FindValue(root, "E");
FindValue(root, "F");
FindValue(root, "Q");

// Find F in the C subtree.
FindValue(NodeC, "F");
// Find F in the B subtree.

Console.ReadLine();

void FindValue(NaryNode<string> node, string value)
{
    var result = node.FindNode(value);
    if (result is not null)
    {
        Console.WriteLine($"Found {value}");
    }
    else
    {
        Console.WriteLine($"Value {value} not found");
    }
}