using System.Linq;

namespace myapp
{
    class SocialDistance
    {
        public int MaxChanges(string s, int k)
        {
            int pos = 0;
            int changes = 0;
            while (pos < s.Length)
            {
                if (s[pos] == '1')
                {
                    pos += k + 1;
                }
                else if (GetSumOfNeighbours(pos, s, k) < 1)
                {
                    changes++;
                    pos += k + 1;
                }
                else
                {
                    pos++;
                }
            }
            return changes;
        }
        private int GetSumOfNeighbours(int pos, string s, int k)
        {
            int start = pos - k;
            int end = pos + k;
            //Start and end position are adjusted if we are at the start or end of the string.
            if (start < 0)
            {
                start = 0;
            }
            if (end > s.Length - 1)
            {
                end = s.Length - 1;
            }
            int stringLength = end - start + 1;
            // we count the numbers of occupied tables in the vicinity
            return s.Substring(start, stringLength).Count(x => (x.Equals('1')));
        }
    }
}