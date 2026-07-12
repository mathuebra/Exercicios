using System;

//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
            return;

        List<ListNode> nodes = new();

        while (head != null)
        {
            nodes.Add(head);
            head = head.next;
        }

        int i = 0;
        int j = nodes.Count - 1;

        while (i < j)
        {
            nodes[i].next = nodes[j];
            i++;

            if (i == j)
                break;

            nodes[j].next = nodes[i];
            j--;
        }

        nodes[i].next = null;
    }
}