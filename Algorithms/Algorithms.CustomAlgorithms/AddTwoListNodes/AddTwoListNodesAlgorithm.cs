using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CustomAlgorithms.AddTwoListNodes
{
    /// <summary>
    /// Adds two custom linked lists, each list represents a number splited by digits as items in the list node
    /// Input: 
    /// list1 = [2, 4, 3] = 342
    /// list2 = [5, 6, 4] = 465
    /// result =  [7, 0, 8] = 807
    /// </summary>
    public class AddTwoListNodesAlgorithm : ICustomAlgorithm<ListNode, AddTwoListNodesArguments>
    {
        public ListNode Run(AddTwoListNodesArguments param)
        {
            ListNode result = new ListNode(0);

            var iter1 = param.ListNode1;
            var iter2 = param.ListNode2;
            var iterresult = result;
            var carry = 0;
            var sum = 0;
            do
            {
                var val1 = iter1 != null ? iter1.val : 0;
                var val2 = iter2 != null ? iter2.val : 0;

                sum = val1 + val2 + carry;
                carry = 0;
                iterresult.next = new ListNode(sum);

                if (sum >= 10)
                {
                    carry = 1;
                    iterresult.next.val = sum - 10;
                }

                iter1 = iter1?.next;
                iter2 = iter2?.next;

                iterresult = iterresult.next;
            } while (iter1 != null || iter2 != null);

            if (carry > 0)
                iterresult.next = new ListNode(carry);


            return result.next;
        }
    }
}
