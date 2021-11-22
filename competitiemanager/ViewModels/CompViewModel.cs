using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class CompViewModel
    {

        public Competition Comp { get; set; }
        public List<int> teamDoelsaldo { get; set; }

        public CompViewModel(Competition comp)
        {

        }

    }

}

