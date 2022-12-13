﻿// See https://aka.ms/new-console-template for more information
using binary_node1;

Console.WriteLine("Hello, World!");

var nodeParent = new BinaryNode<string>("Root");

// setup nodes
var NodeA = new BinaryNode<string>("A");
var NodeB = new BinaryNode<string>("B");
var NodeC = new BinaryNode<string>("C");
var NodeD = new BinaryNode<string>("D");
var NodeE = new BinaryNode<string>("E");
var NodeF = new BinaryNode<string>("F");

// setup relations
NodeA.AddLeft(NodeC);
NodeA.AddRight(NodeD);

NodeB.AddRight(NodeE);
NodeE.AddLeft(NodeF);

nodeParent.AddLeft(NodeA);
nodeParent.AddRight(NodeB);


//FindValue(nodeParent, "Root");
//FindValue(nodeParent, "E");
//FindValue(nodeParent, "F");
//FindValue(nodeParent, "Q");

//// Find F in the B subtree.
//FindValue(NodeB, "F");

string result;
result = "Preorder:      ";
foreach (BinaryNode<string> node in nodeParent.TraversePreorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "InOrder:      ";
foreach (BinaryNode<string> node in nodeParent.TraverseInorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "PostOrder:      ";
foreach (BinaryNode<string> node in nodeParent.TraversePostorder())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);

result = "Breadth first:      ";
foreach (BinaryNode<string> node in nodeParent.TraverseBreadthFirst())
{
    result += string.Format("{0} ", node.Value);
}
Console.WriteLine(result);



Console.ReadKey();

void FindValue(BinaryNode<string> node, string value)
{
    var result = node.FindNode(value);
    if(result is not null)
    {
        Console.WriteLine($"Found {value}");
    } 
    else
    {
        Console.WriteLine($"Value {value} not found");
    }
}