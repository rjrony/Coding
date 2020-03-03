using System;
using System.Collections.Generic;

namespace Optiver
{
    public class DecodingMorseCode
    {
        static readonly string[] _values = { "---", ".--.", "-", "..", "...-", ".", ".-." };
        static Dictionary<string, char> _map = new Dictionary<string, char>();
        static List<string> _ans = new List<string>();
        const string OPTIVER = "OPTIVER";
        static List<string> decode_all_words(string code)
        {
            for (int i = 0; i < OPTIVER.Length; i++)
            {
                _map.Add(_values[i], OPTIVER[i]);
            }
            _ans.Clear();
            backtrack(0, string.Empty, code);
            //_ans.Sort();
            return _ans;
        }

        private static void backtrack(int pos, string res, string code)
        {
            if (pos == code.Length)
            {
                _ans.Add(res);
                return;
            }
            int mx = Math.Min(pos + 4, code.Length);
            for (int i = pos + 1; i <= mx; i++)
            {
                string key = code.Substring(pos, i-pos);
                char value;
                if (_map.TryGetValue(key, out value))
                {
                    Console.WriteLine("pos:"+pos+" i:"+i+" res: "+ res + value);
                    backtrack(i, res + value, code);
                }
            }
        }

        public static void Main2(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string code = ".-...-"; //Console.ReadLine();

            List<string> res = decode_all_words(code);
            Console.WriteLine(String.Join("\n", res));

            //textWriter.WriteLine(String.Join("\n", res));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
