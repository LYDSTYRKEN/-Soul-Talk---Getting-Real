using System;
using System.Collections.Generic;
using System.Text;

namespace __Soul___Talk__.Model
{
    public interface IKundeRepository
    {
        IReadOnlyCollection<Kunde> HentAlle();
        IReadOnlyCollection<Kunde> HentPrivateKunder();
        IReadOnlyCollection<Kunde> HentForInstitution(int institutionId);

        Kunde? HentVedId(int id);
        Kunde Gem(Kunde kunde);
    }
}

