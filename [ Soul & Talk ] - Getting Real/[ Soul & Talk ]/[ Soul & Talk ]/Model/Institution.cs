using System;
using System.Collections.Generic;
using System.Text;

namespace __Soul___Talk__.Model
{
    public class Institution
    {
        public int Id { get; set; }

        public string Navn { get; set; } = string.Empty;

        public InstitutionType Type { get; set; }
    }
}

