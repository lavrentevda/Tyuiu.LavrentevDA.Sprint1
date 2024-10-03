using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.LavrentevDA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            string sanitizedInput = "";
            foreach (char ch in value)
            {
                if (char.IsLetter(ch))
                {
                    sanitizedInput += char.ToLower(ch);
                }
            }


            for (int i = 0; i < sanitizedInput.Length - 1; i++)
            {
                if (sanitizedInput[i] > sanitizedInput[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
    


