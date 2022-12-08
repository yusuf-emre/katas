public class Program
{
    static void Main(string[] args)
    {
        var nodeD = new ListNode(213);
        var nodeC = new ListNode(177, nodeD);
        var nodeB = new ListNode(111, nodeC);
        var nodeA = new ListNode(43, nodeB);
        var node = new ListNode(27, nodeA);

        var reverseNode = ListNode.ReverseList(node);

        var reverseList = new List<int>();
        while (reverseNode != null)
        {
            reverseList.Add(reverseNode.val);
            reverseNode = reverseNode.next;
        }
        Console.WriteLine($"[{string.Join(", ", reverseList)}]");
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode ReverseList(ListNode head)
    {
        ListNode current = head;
        ListNode next = null;
        ListNode reversed = null;

        while (current != null)
        {
            next = current.next;
            current.next = reversed;
            reversed = current;
            current = next;
        }

        return reversed;
    }
}