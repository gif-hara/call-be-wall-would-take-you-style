using System.Collections.Generic;
using System.Linq;
using System.Text;
using Random = System.Random;

namespace HK.Soramimi
{
    public static class Soramimi
    {
        public static string Translate(string text, Database database)
        {
            var random = new Random();
            var result = new StringBuilder();
            var useDatabase = new List<Database.Data>();
            for (int i = 0; i < text.Length;)
            {
                for (int k = 1; k <= text.Length - i; ++k)
                {
                    var target = text.Substring(i, k);
                    var findDatabase = database.Get.Where(d => d.Key == target);
                    if (findDatabase.Any())
                    {
                        useDatabase.AddRange(findDatabase);
                    }
                    if(!findDatabase.Any() || k + 1 >= (text.Length - i))
                    {
                        var targetData = useDatabase[random.Next(useDatabase.Count - 1)];
                        result.Append(string.Format("{0} ", targetData.Value));
                        i += targetData.Key.Length;
                        useDatabase.Clear();
                        break;
                    }
                }
            }
            return result.ToString();
        }
    }
}
