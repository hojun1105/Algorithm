public class Solution {
    public int RomanToInt(string s) {
        var d = new List<int>();
        int rst =0;
        for(int i=0; i<s.Length; i++)
        {
            switch(s[i])
            {
                case 'I':
                    d.Add(1);
                    break;
                case 'V':
                    d.Add(5);
                    break;
                case 'X':
                    d.Add(10);
                    break;
                case 'L':
                    d.Add(50);
                    break;
                case 'C':
                    d.Add(100);
                    break;
                case 'D':
                    d.Add(500);
                    break;
                case 'M':
                    d.Add(1000);
                    break;
            }
        }
        for(int i=0; i<d.Count-1; i++){
            if(d[i]>=d[i+1]){
                rst += d[i];
            }
            else{
                rst -= d[i];
            }
        }
        return rst+d[d.Count-1];
    }
}