using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace unique_words
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Dictionary<string, int> GetCount(string inputText)
        {
            var results = new Dictionary<string, int>();
            foreach (var word in inputText.Split(' '))
            {
                if (results.ContainsKey(word))
                {
                    results[word] += 1;
                }
                else
                {
                    results.Add(word, 1);
                }
            }
            return results;
        }
    }
}