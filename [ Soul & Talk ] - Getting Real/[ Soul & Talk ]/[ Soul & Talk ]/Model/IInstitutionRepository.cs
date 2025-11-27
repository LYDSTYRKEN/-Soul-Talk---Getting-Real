using System;
using System.Collections.Generic;
using System.Text;

namespace __Soul___Talk__.Model
{
    public interface IInstitutionRepository
    {
        IReadOnlyCollection<Institution> HentAlle();
        Institution? HentVedId(int id);
        Institution Gem(Institution institution);
    }
}

