using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aflevering_1
{
    class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int score { get; set; }
        
        public User(string s)
        {
            var L = s.Split(';');
            id = L[0];
            name = L[1];
            age = int.Parse(L[2]);
            score = int.Parse(L[3]);
        }

        public string getListBoxInfo()
        {
            return "name: " + name + " id: " + id;
        }
    }
}
