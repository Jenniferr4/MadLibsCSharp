using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadLibsCSharp.Models
{
    public class MessageModel
    {
        private string Name { get; set; }
        public string Message;

        public MessageModel(string name)
        {
            this.Name = name;
        }

        public string nameToUpper()
        {
            string n = Name.ToUpper();
            return n;
        }


    }
}
