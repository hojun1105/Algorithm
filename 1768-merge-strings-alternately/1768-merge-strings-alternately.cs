public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var min = Math.Min(word1.Length,word2.Length);
        var max = Math.Max(word1.Length,word2.Length);

        string rst="";
        for(int i =0; i<min; i++)
        {
            rst+=word1[i];
            rst+=word2[i];
        }
        for(int i=min; i<max; i++)
        {
            if(word2.Length==min)
            {rst += word1[i];}
            else
            {
                rst+=word2[i];
            }
        }
        return rst;
    }
}