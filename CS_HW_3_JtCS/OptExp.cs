using System;

namespace JavaToCshap_HW
{
    class OptExp
    {
        private string exp;
        private int expSize;
        private char testCh, openPair;

        public Boolean testPair(string exp)
        {
            this.exp = exp;
            LinkedStack S = new LinkedStack();
            expSize = this.exp.Length;
            for(int i=0; i<expSize; i++)
            {
                char textCh = this.exp[i];
                switch(textCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.isEmpty())
                            return false;
                        else
                        {
                            openPair = S.pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
                                    || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }
                }
            }
            if (S.isEmpty())
                return true;
            else
                return false;
        }
    }
}
