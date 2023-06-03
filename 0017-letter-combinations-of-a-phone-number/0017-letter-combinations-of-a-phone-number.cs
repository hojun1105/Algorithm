public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(string.IsNullOrEmpty(digits)) {return new List<string>();}
    
        var ans = new List<string>(){""};
        var mapping = new List<string>(){
            "","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        foreach(var digit in digits)
        {
            var backup = new List<string>();
            
            foreach(var chr in mapping[digit-'0'])
            {
                foreach(var answer in ans)
                {
                    backup.Add(answer+chr);
                }
            }
            ans = backup;
        }
        return ans;
        
    }
}