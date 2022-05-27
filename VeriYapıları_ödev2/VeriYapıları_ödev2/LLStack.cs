using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_ödev2
{
    class LLStack:Istack
    {
        Node top;
        public LLStack()
        {
            this.top = null;
        }
        public Node GetNode(object data)
        {
            Node node = new Node(data);
            return node;
        }
        public void Push(object item)
        {
            Node newNode = GetNode(item);
            if (top == null)
            {
                top = newNode;
                return;
            }
            newNode.next = top;
            top = newNode;
        }
        public object Pop()
        {
            object peek = -1;
            if (top != null)
            {
                peek = top.data;
                top = top.next;
            }
            return peek;
        }
        public object Peek()
        {
            if (top != null)
            {
                return top.data;
            }
            return -1;
        }
    }
}
