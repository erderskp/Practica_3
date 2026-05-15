using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_3
{
    public interface IUsuarioServicio
    {
        Task<Usuario> GetUserAsync();
    }
}
