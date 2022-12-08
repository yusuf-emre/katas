using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode();

        var currentNode = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }

        if (list1 != null)
        {
            currentNode.next = list1;
        }
        else
        {
            currentNode.next = list2;
        }
        return head.next;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var nodeD = new ListNode(213);
        var nodeC = new ListNode(177, nodeD);
        var nodeB = new ListNode(111, nodeC);
        var nodeA = new ListNode(43, nodeB);
        var node1 = new ListNode(27, nodeA);

        var nodeF = new ListNode(64);
        var nodeE = new ListNode(30, nodeF);        
        var node2 = new ListNode(11, nodeE);
        
        var current = ListNode.MergeTwoLists(node1, node2);

        var nodeList = new List<int>();
        while(current != null)
        {
            nodeList.Add(current.val);
            current = current.next;
        }
        Console.WriteLine($"[{string.Join(", ", nodeList)}]");
    }
}
