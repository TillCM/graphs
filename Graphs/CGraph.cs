using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class CGraph
    {
        private Dictionary<int, CNode<string>> nodeLookup= new Dictionary<int, CNode<string>>();
       
            public void addNode(int id,string data)
            {
                nodeLookup.Add(id, new CNode<string>(data,id));
            }

            public CNode<string>  getNode(int id)
            {
                 return nodeLookup[id];

            }

        public void addEdges (int source ,int destintation )
        {
            CNode<string> s = getNode(source);
            CNode<string> d = getNode(destintation);

            s.adjencies.AddFirst(d);
        }

        public bool hasPathDFS(int source, int destination)
        {

            CNode<string> s = getNode(source);
            CNode<string> d = getNode(destination);
            HashSet<int> visited = new HashSet<int>();

            return hasPathDFS(s, d, visited);
            
        }

        private bool hasPathDFS(CNode<string> source, CNode<string> destination, HashSet<int> visited)
        {
            if(visited.Contains(source.id))
            {
                return false;
            }

            visited.Add(source.id);


                if (source == destination)
                {
                    return true;
                }

            foreach (CNode<string> child in source.adjencies)
            {
                if (hasPathDFS(child, destination, visited))
                    {
                         return true;
                    }
            }

            return false;

        }

        public bool hasPathBFS(int source, int destination)
        {
            return hasPathBFS(getNode(source), getNode(destination));
        }

        private bool hasPathBFS(CNode<string> source, CNode<string> destination)
        {

            Queue<CNode<string>> nexttovisit = new Queue<CNode<string>>();
            HashSet<int> visited = new HashSet<int>();
            nexttovisit.Enqueue(source);

            while (nexttovisit.Count > 0)
            {
                CNode<string> Node = nexttovisit.Dequeue();

                if(Node == destination)
                {
                    return true;
                }

                if (visited.Contains(Node.id))
                {
                    continue;
                }

                visited.Add(Node.id);

                foreach (CNode<string> child in Node.adjencies)
                {
                    nexttovisit.Enqueue(child);
                }
            }

            return false;

        }





    }
}
