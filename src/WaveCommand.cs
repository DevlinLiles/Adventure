﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class WaveCommand : BaseCommand, ICommand
    {
   
        public bool IsValid(string input)
        {
            return IsFirstWord(input, "wave");
        }
        public void Execute(string input)
        {
            var output = GetAllButFirstWord(input);
            Console.WriteLine(String.Format("You wave at {0}.", output));
        }
    }
}
