public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // 先建立第一層
        ListNode result = new ListNode();
        // 參考 result 位置
        ListNode current = result;

        if (list1 == null)
            return list2;
        else if (list2 == null)
            return list1;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                // current.next 的參考位置被改為 list1 的參考位置
                // list1 的參考位置被改為 list1.next 的參考位置
                // 所以 current.next 裡面的值不會被改動
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            // 不管往下參考幾層，都會將物件存回 result 物件
            current = current.next;
        }

        // 當如果其中一個空資料時，放入另一個剩下的物件
        current.next = list1 ?? list2!;

        // 第一層不包含 list1 和 list2，所以要拿他 next 的物件
        return result.next;
    }
}