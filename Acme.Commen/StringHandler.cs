﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            string result = string.Empty;
            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();//Remove any allready existing spaces
                        result += " ";

                    }
                    result += letter;

                }
                result = result.Trim();
            }
            return result;
        }
    }
}
