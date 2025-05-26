using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDescontoBaixaRenda
{
    public static class Util
    {
    }
    [Serializable]
    public class Usuario
    {
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = "";
        public List<UsuarioPrograma> UsuarioPrograma { get; set; } = new List<UsuarioPrograma>();
    }

    public enum UsuarioProgramaTipo { Nenhum = 0, Programacao, Contabilidade, Eletrica, Mecanica, ManutencaoIndustrial, InteligenciaArtificial, PacoteOffice, Culinaria,  }
    public enum Semana { Semana1 = 0, Semana2, Semana3, Semana4, Semana5 }
    [Serializable]
    public class UsuarioPrograma
    {
        public UsuarioProgramaTipo UsuarioProgramaTipo { get; set; } = UsuarioProgramaTipo.Programacao;
        public Semana Semana { get; set; } = Semana.Semana1;
    }
}
