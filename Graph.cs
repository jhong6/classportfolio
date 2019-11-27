using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();
            myGraph.AddVertex("CSC101");
            myGraph.AddVertex("MAT101");
            myGraph.AddVertex("CSC180");
            myGraph.AddVertex("GEN ED");
            myGraph.AddVertex("CSC200");

            myGraph.AddEdge("CSC180", "CSC300");
            myGraph.PrintAdjacencyList();
        }
    }

    class Vertex
    {
        public string label;
        public bool wasVisisted;

        public Vertex(string name)
        {
            label = name;
        }
    }
    class Graph
    {
        // Graph = (Vertices, Edge)
        List<Vertex> listOfVertices;
        List<List<Vertex>> adjacencyList; // Adjacency list
        public Graph()
        {
            // Instantiates the list
            listOfVertices = new List<Vertex>();
            adjacencyList = new List<List<Vertex>>();
        }

        // Add vertex
        public void AddVertex(string name)
        {
            Vertex v = new Vertex(name);
            listOfVertices.Add(v);

            List<Vertex> list = new List<Vertex>();
            list.Add(v);
            adjacencyList.Add(list);
        }

        public void RemoveVertex(string name)
        {
            int i = 0;
            while (i < listOfVertices.Count)
            {
                if (listOfVertices[i].label == name)
                {
                    listOfVertices.RemoveAt(i);
                    break;
                }
                i++;
            }

            // Remove the list at position i in adjacencyList
            adjacencyList.RemoveAt(i);

            // Remove all nodes referring to name from adjacency list
            foreach(var list in adjacencyList)
            {
                for(int ii = list.Count-1; ii>=0; ii--)
                {
                    if (list[ii].label == name)
                        list.RemoveAt(ii);
                }
            }
        }

        // Add edges
        public void AddEdge(string start, string end)
        {
            int j = -1;
            // Find the row in adjacency list
            for(j = 0; j<listOfVertices.Count; j++)
            {
                if (listOfVertices[j].label == start)
                    break;
            }
            if(j == listOfVertices.Count)
            {
                throw new Exception(String.Format($"{start} was not found in the graph!"));
            }
            adjacencyList[j].Add(new Vertex(end));
        }
        public void RemoveEdge(string start, string end)
        {
            int j = -1;
            // Find the row in adjacency list
            for (j = 0; j < listOfVertices.Count; j++)
            {
                if (listOfVertices[j].label == start)
                    break;
            }
            if (j == listOfVertices.Count)
            {
                throw new Exception(String.Format($"{start} was not found in the graph!"));
            }
            for(int k = 0; k < adjacencyList[k].Count; k++)
            {
                if(adjacencyList[j][k].label == end)
                {
                    adjacencyList[j].RemoveAt(k);
                    break;
                }
            }
        }
        public void PrintAdjacencyList()
        {
            for(int i = 0; i<listOfVertices.Count; i++)
            {
                Console.Write(listOfVertices[i].label + "\t|\t");
                foreach(Vertex v in adjacencyList[i])
                {
                    Console.Write(v.label + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
