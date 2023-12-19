public class Solution {
    public bool IsPalindrome(ListNode head) {
        var current = head;
        var stack = new Stack<int>();

        while (head?.next != null){
            stack.Push(head.next.val);
            head = head.next;
        }

        while (stack.Count > 0){
            if (stack.Pop() != current.val){
                return false;
            }
            current = current.next;
        }

        return true;
    }
}