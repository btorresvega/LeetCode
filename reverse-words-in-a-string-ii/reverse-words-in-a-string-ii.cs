public class Solution {
    
           public  void reverse(char[] s, int left, int right)
        {
            while (left < right)
            {
                char tmp = s[left];
                s[left++] = s[right];
                s[right--] = tmp;
            }
        }

        public  void reverseEachWord(char[] s)
        {
            int n = s.Length;
            int start = 0, end = 0;

            while (start < n)
            {
                // go to the end of the word
                while (end < n && s[end] != ' ') ++end;
                // reverse the word
                reverse(s, start, end - 1);
                // move to the next word
                start = end + 1;
                ++end;
            }
        }

        public  void ReverseWords(char[] s)
        {
            // reverse the whole string
            reverse(s, 0, s.Length - 1);

            // reverse each word
            reverseEachWord(s);
        }
    }

