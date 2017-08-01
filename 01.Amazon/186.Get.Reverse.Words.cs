namespace _01.Amazon
{

    public class _186GetReverseWords
    {

        public static void Answer()
        {
            var inputs = new [] {'a', ' ', 'b'};
            GetReverseWords(inputs);
        }

        static void GetReverseWords(char[] in_text)
        {
            int lindex = 0;
            int rindex = in_text.Length - 1;
            if (rindex > 1)
            {
                //reverse complete phrase
                in_text = GetReverseString(in_text, 0, rindex);

                //reverse each word in resultant reversed phrase
                for (rindex = 0; rindex <= in_text.Length; rindex++)
                {
                    if (rindex == in_text.Length || in_text[rindex] == ' ')
                    {
                        in_text = GetReverseString(in_text, lindex, rindex - 1);
                        lindex = rindex + 1;
                    }
                }
            }
        }

        static char[] GetReverseString(char[] intext, int lindex, int rindex)
        {
            char tempc;
            while (lindex < rindex)
            {
                tempc = intext[lindex];
                intext[lindex++] = intext[rindex];
                intext[rindex--] = tempc;
            }
            return intext;
        }

    }

}
