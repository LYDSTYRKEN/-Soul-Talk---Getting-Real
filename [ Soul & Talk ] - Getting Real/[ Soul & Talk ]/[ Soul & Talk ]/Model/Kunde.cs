using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace __Soul___Talk__.Model
{
    public class Kunde
    {
        public int Id { get; set; }

        public string Navn { get; set; } = string.Empty;

        // <summary>
        // Null = privat kunde. Ikke null = institutionsklient.
        // </summary>
        public Institution? Institution { get; set; }

        public bool ErPrivatKunde => Institution is null;
    }
}
