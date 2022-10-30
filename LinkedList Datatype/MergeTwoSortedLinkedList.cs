using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList_Datatype
{

    public class MergeTwoSortedLinkedList
    {
        internal Node head;

        public void Run()
        {
            MergeTwoSortedLinkedList instance1 = new MergeTwoSortedLinkedList();

            //Inserting at End
            instance1.InsertAtBeginning(instance1, 50);
            instance1.InsertAtBeginning(instance1, 40);
            instance1.InsertAtBeginning(instance1, 30);
            instance1.InsertAtBeginning(instance1, 20);
            instance1.InsertAtBeginning(instance1, 10);

            MergeTwoSortedLinkedList instance2 = new MergeTwoSortedLinkedList();

            //Inserting at End
            instance2.InsertAtBeginning(instance2, 55);
            instance2.InsertAtBeginning(instance2, 44);
            instance2.InsertAtBeginning(instance2, 33);
            instance2.InsertAtBeginning(instance2, 22);
            instance2.InsertAtBeginning(instance2, 11);


            MergeTwoSortedLinkedList instance3 = new MergeTwoSortedLinkedList();


            Merge(instance1, instance2, instance3);

            PrintLinkedList(instance1);

            PrintLinkedList(instance2);
        }

        public MergeTwoSortedLinkedList Merge(MergeTwoSortedLinkedList instance1,
                                              MergeTwoSortedLinkedList instance2,
                                              MergeTwoSortedLinkedList instance3)
        {
            if (instance1.head is null)
                return instance2;

            if (instance2.head is null)
                return instance1;

            //if(instance1.head.next )


            return instance3;
        }

        public void InsertAtBeginning(MergeTwoSortedLinkedList instance1, int element)
        {
            Node new_node = new Node(element);
            new_node.next = instance1.head;
            instance1.head = new_node;
        }

        public void PrintLinkedList(MergeTwoSortedLinkedList instance)
        {
            Node temp = instance.head;

            while (temp != null)
            {
                Console.WriteLine("Element: " + temp.data);
                temp = temp.next;
            }
        }
    }
}
