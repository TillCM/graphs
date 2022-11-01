using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            CGraph pleasework = new CGraph();

            pleasework.addNode(1, "sam");
            pleasework.addNode(2, "pete");
            pleasework.addNode(3,"Mary");
            

            pleasework.addEdges(1, 2);
            pleasework.addEdges(2, 3);

           bool yes = pleasework.hasPathDFS(1, 3);

           if(yes)
            { 
                Console.WriteLine("Sam is related to Pete they be cousins!!");
            }

            else 
            {
                Console.WriteLine("NOOOOOOOOO");
            }


          bool BFSYes =   pleasework.hasPathBFS(1, 2);

            if (BFSYes)
            {
                Console.WriteLine("BFS PATH FOUND between Sam and Pete " );
            }
            else
            {
                Console.WriteLine("Noo");

            }


          }

        }
    }

