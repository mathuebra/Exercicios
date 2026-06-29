using System.Collections.Generic;

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
    public bool HasCycle(ListNode head) {
        List<ListNode> visited = new List<ListNode>();
        Dictionary<ListNode, bool> seen = new Dictionary<ListNode, bool>();
        ListNode current = head;

        while (current != null)
        {
            if (seen.ContainsKey(current))
            {
                return true;
            }

            seen[current] = true;
            visited.Add(current);
            current = current.next;
        }

        return false;
    }
}