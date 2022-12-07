using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class BackpackProcessor
    {
        private List<Backpack> _backpacks;

        public BackpackProcessor()
        {
            _backpacks = new List<Backpack>();
        }
        internal void ProcessBackpackData(IEnumerable<string> data)
        {
            foreach (string s in data)
            {
                _backpacks.Add(new Backpack(s));
            }
        }

        internal int GetValueOfMissplacedItems()
        {
            var res = 0;
            foreach (var item in _backpacks)
            {
                res += item.CharValue;
            }

            return res;
        }
    }

    internal class Backpack
    {
        private List<string> _compartments;
        internal char? MatchingCharacter => MatchingChar();
        internal int CharValue => MatchingChar() != null ? GetCharValue((char)MatchingChar()) : 0;
        public Backpack(string items)
        {
            _compartments = new List<string>();
            var len = items.Length/2;
            _compartments.Add(items.Remove(len));
            _compartments.Add(items.Substring(len));
        }

        private char? MatchingChar()
        {
            if (_compartments.Count == 2)
            {
                var res = _compartments[0].Intersect(_compartments[1]);
                return res.FirstOrDefault();
            }
            
            return null;
        }

        private int GetCharValue(char c)
        {
            bool isUpper = char.IsUpper(c);
            int index = char.ToUpper(c) - ('A' - 1);
            return isUpper ? index + 26 : index;
        }
    }
}
