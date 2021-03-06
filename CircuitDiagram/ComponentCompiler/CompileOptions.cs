﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cdcompile
{
    class CompileOptions
    {
        public string Output { get; set; }
        public string Input { get; set; }
        public List<string> IconPaths { get; private set; }
        public string DefaultIconPath { get; set; }
        public bool Sign { get; set; }
        public string CertificateThumbprint { get; set; }

        public CompileOptions()
        {
            IconPaths = new List<string>();
        }
    }
}
