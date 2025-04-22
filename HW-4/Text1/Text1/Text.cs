using System.Text.RegularExpressions;

public class Text
{
    /// <summary>
    /// Processes the input text to find duplicate words ending with "ing" and returns them sorted.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A semicolon-separated string of duplicate "ing" words, sorted alphabetically.</returns>
    public string СhangingText(string text)
    {
        /// <summary>
        /// Splits the text into sentences.
        /// </summary>
        string[] sentences = Regex.Split(text, "[.!?]");

        string allIngWords = "";

        /// <summary>
        /// Extracts words ending with "ing" from each sentence.
        /// </summary>
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(' ').Where(w => w != "").ToArray();

            for (int j = 0; j < words.Length; j++)
            {
                string cleanedSentences = Regex.Replace(words[j], "[^a-zA-Z]", "").ToLower();

                /// <summary>
                /// Checks if the word ends with "ing".
                /// </summary>
                if (cleanedSentences.Length >= 3 &&
                    cleanedSentences[cleanedSentences.Length - 3] == 'i' &&
                    cleanedSentences[cleanedSentences.Length - 2] == 'n' &&
                    cleanedSentences[cleanedSentences.Length - 1] == 'g')
                {
                    allIngWords += cleanedSentences + " ";
                }
            }
        }

        /// <summary>
        /// Creates an array of "ing" words.
        /// </summary>
        string[] ingWords = allIngWords.Split(' ').Where(w => w != "").ToArray();

        /// <summary>
        /// Array to store duplicate words.
        /// </summary>
        string[] duplicates = new string[ingWords.Length];
        int duplicatesCount = 0;

        /// <summary>
        /// Finds duplicate "ing" words and stores them in the duplicates array.
        /// </summary>
        for (int i = 0; i < ingWords.Length; i++)
        {
            if (ingWords[i] == "")
                continue;

            int count = 1;

            for (int j = i + 1; j < ingWords.Length; j++)
            {
                if (ingWords[i] == ingWords[j])
                {
                    count++;
                    ingWords[j] = ""; // Marks as already processed
                }
            }

            /// <summary>
            /// Adds the word to the duplicates array if it appears more than once.
            /// </summary>
            if (count > 1)
            {
                bool inArray = false;

                for (int k = 0; k < duplicatesCount; k++)
                {
                    if (duplicates[k] == ingWords[i])
                    {
                        inArray = true;
                        break;
                    }
                }

                if (!inArray)
                {
                    duplicates[duplicatesCount] = ingWords[i];
                    duplicatesCount++;
                }
            }
        }

        /// <summary>
        /// Sorts the duplicates array alphabetically.
        /// </summary>
        for (int i = 0; i < duplicatesCount - 1; i++)
        {
            for (int j = i + 1; j < duplicatesCount; j++)
            {
                if (string.Compare(duplicates[i], duplicates[j]) > 0)
                {
                    string help = duplicates[i];
                    duplicates[i] = duplicates[j];
                    duplicates[j] = help;
                }
            }
        }

        /// <summary>
        /// Forms the final result string from the duplicates array.
        /// </summary>
        string result = "";
        for (int i = 0; i < duplicatesCount; i++)
        {
            result += duplicates[i];
            if (i < duplicatesCount - 1)
                result += ";";
        }

        return result;
    }
}

