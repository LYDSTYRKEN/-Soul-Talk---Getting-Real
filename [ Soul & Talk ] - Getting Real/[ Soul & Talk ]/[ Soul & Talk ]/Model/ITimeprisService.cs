using System;
using System.Collections.Generic;
using System.Text;

namespace __Soul___Talk__.Model
{
    public interface ITimeprisService
    {
        decimal HentTimepris(Kunde kunde, bool erFysisk);   // Returnerer timepris ud fra kundens type og om mødet er fysisk/online.
    }
}
