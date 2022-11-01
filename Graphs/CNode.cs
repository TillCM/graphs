using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    class CNode <T>
    {
        public  int id;
        T data;
       public  LinkedList<CNode<T>> adjencies = new LinkedList<CNode<T>>();

        public CNode(T data, int id)
        {
            this.data = data;
            this.id= id;
        }
        
    }
}
