// See https://aka.ms/new-console-template for more information
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

//Console.WriteLine(nodeParent.ToString());
//Console.WriteLine(NodeA.ToString());
//Console.WriteLine(NodeB.ToString());
//Console.WriteLine(NodeC.ToString());
//Console.WriteLine(NodeD.ToString());
//Console.WriteLine(NodeE.ToString());
//Console.WriteLine(NodeF.ToString());

Console.Write(nodeParent);


Console.Write(NodeA);


Console.ReadKey();