using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace __Soul___Talk__.Model
{
    public class Indtaegt // En registreret indtægt (inkl. evt. kørte kilometer).
    {
        public int Id { get; set; }

        public Kunde Kunde { get; set; } = null!;

        public DateTime Dato { get; set; }

        public decimal Timer { get; set; }

        public bool ErFysisk { get; set; }      // True = fysisk. False = online.

        public decimal Kilometer { get; set; }  // Kørte kilometer i forbindelse med denne indtægt. 0 hvis der ikke er kørt noget.

        public decimal Timepris { get; set; }   // Timepris som blev anvendt ved registreringen.

        public decimal Beloeb { get; set; }     // Samlet beløb for indtægten. Beregnet som Timer * Timepris.
    }
}

