# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        
        list1=list()
        list2=list()
        i=0
        
        # listNode -> list 자료형변환 
        
        while l1 or l2:
            if l1 != None:
                list1.append(l1.val)
                l1=l1.next
            if l2 != None:
                list2.append(l2.val)
                l2=l2.next
            i+=1
        
        # 주어진 문제대로 순서뒤집기
        list1.reverse()
        list2.reverse()
        
        # 배열 int->str->int 숫자 형태로 만들어서 더하기 위함
        # 이후 다시 list로 형변환
        num1 = int(''.join(str(a) for a in list1))
        num2 = int(''.join(str(a) for a in list2))
        result = list(str(num1+num2))
        result.reverse()
        
        
       
        result_Node=ListNode()
        
        #result를 list-> listNode로 만들어주기
        
        for i,num in enumerate(result):
            if i == 0 :
                result_Node.val = num
            else :
                node = result_Node
                while node.next != None:
                    node = node.next
                node.next = ListNode(num)
            
        return result_Node
    
    
        # 정호준