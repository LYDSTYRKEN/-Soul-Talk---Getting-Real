using System;
using System.Collections.Generic;
using System.Text;

namespace __Soul___Talk__.Model
{
    public interface IIndtaegtRepository
    {
        IReadOnlyCollection<Indtaegt> HentForKunde(
            int kundeId,
            DateTime? fra = null,
            DateTime? til = null);

        Indtaegt Gem(Indtaegt indtaegt);
    }
}
