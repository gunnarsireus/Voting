using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingWeb.Models
{
    public class VotingViewModel
    {
        public string OptionValue { get; set; }
        private List<KeyValuePair<string, int>> votes = new List<KeyValuePair<string, int>>();
        public List<KeyValuePair<string, int>> Votes
        {
            set { votes = value; }
            get { return votes; }
        }
    }
  
}
