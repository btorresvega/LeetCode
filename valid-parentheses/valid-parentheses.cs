public class Solution {
    
    public bool IsValid(string s) 
    {
    
        Stack<char> parent = new Stack<char>();
        
        foreach(char i in s.ToCharArray())
        {
            if(i == '(')
                parent.Push(')');
            else if(i == '[')
                parent.Push(']');
            else if(i == '{')
                parent.Push('}');
            else if(parent.Count == 0 || parent.Pop() != i)
                return false;
        }
        
        
            return parent.Count == 0;
    }
}