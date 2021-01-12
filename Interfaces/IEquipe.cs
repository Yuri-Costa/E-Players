using System.Collections.Generic;
using ASPNET_core.Models;

namespace ASPNET_core.Interfaces
{
    public interface IEquipe
    {
         void Create(Equipe e);

        List<Equipe> ReadAll();

        void Update(Equipe e);

        void Delete(int id);
    }
}