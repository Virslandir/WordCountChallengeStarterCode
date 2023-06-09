﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StefansStringProcessingLibrary
{
    public static class Factory
    {
        private static Regex CreateRegex()
        {
            return new Regex("[^a-zA-Z ]");
        }
     
        public static IStringProcessor CreateStringProcessor()
        {
            return new StringProcessor(CreateRegex());
        }


        public static IViewerEngine CreateViewerEngine()
        {
            return new ConsoleViewerEngine(CreateStringProcessor());
        }
    }
}
