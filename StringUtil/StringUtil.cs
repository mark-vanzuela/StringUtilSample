using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilNS
{
    public class StringUtil
    {
        /// <summary>
        /// Returns the index of the first occurence of the subtext on the text. An optional startindex indicates where to start the comparison.
        /// </summary>
        /// <param name="text">The main text to search.</param>
        /// <param name="subText">The text to search on the main text.</param>
        /// <param name="startIndex">Optional parameter indicating where to start the comparison. This is zero based index.</param>
        /// <returns>The index of the first occurence of the sub text within the text. -1 if not found.</returns>
        public int IndexOf(string text, string subText, int startIndex = 0)
        {
            if (string.IsNullOrEmpty(text))
                return -1;

            if (string.IsNullOrEmpty(subText))
                return -1;

            if (subText.Length > text.Length)
                return -1;

            if (startIndex + subText.Length > text.Length)
                return -1;

            bool match;

            for (int i = startIndex ; i < text.Length - subText.Length + 1; ++i)
            {
                match = true;
                for (int j = 0; j < subText.Length; ++j)
                {
                    if (!text[i + j].ToString().ToLower().Equals(subText[j].ToString().ToLower()))
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i + 1;
            }

            return -1;
        }

        /// <summary>
        /// Returns a list of integers, the index of every occurence of the subtext within the text.
        /// </summary>
        /// <param name="text">The main text to search.</param>
        /// <param name="subText">The text to search within the main text.</param>
        /// <returns></returns>
        public List<int> IndexesOf(string text, string subText)
        {
            List<int> indexes = new List<int>();
            if (string.IsNullOrEmpty(text))
                return indexes;

            if (string.IsNullOrEmpty(subText))
                return indexes;

            if (subText.Length > text.Length)
                return indexes;

            for (int index = 0; ; index += subText.Length)
            {
                index = this.IndexOf(text, subText, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}
