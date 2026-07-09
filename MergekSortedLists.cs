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

// Input: lists = [[1,4,5],[1,3,4],[2,6]]
// Output: [1,1,2,3,4,4,5,6]

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        // Lista com ListNode com a priority como o próprio ListNode.val
        PriorityQueue<ListNode, int> pq = new();
        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        foreach (ListNode ln in lists)
        {
            if (ln != null)
            {
                pq.Enqueue(ln, ln.val);   
            }
        }

        while (pq.Count != 0)
        {
            // retiramos o menor nó
            ListNode menor = pq.Dequeue();

            // agora o menor nó está efetivamente na lista de resposta
            tail.next = menor;

            // agora o tail atual é o menor nó da resposta
            tail = tail.next;

            if (menor.next != null)
                pq.Enqueue(menor.next, menor.next.val);
        }

        return dummy.next; // teóricamente primeiro elemento da lista
    }
}