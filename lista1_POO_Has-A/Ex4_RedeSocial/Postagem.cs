using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_RedeSocial
{
    class Postagem
    {
        #region Variáveis
        #region dataHora
        private DateTime dataHora;

        public DateTime GetSetDataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }
        #endregion

        #region Titulo
        private string Titulo;

        public string GetSetTitulo
        {
            get { return Titulo; }
            set { Titulo = value; }
        }
        #endregion

        #region Subtitulo
        private string Subtitulo;

        public string GetSetSubtitulo
        {
            get { return Subtitulo; }
            set { Subtitulo = value; }
        }
        #endregion
        #endregion

        #region Constructor
        public Postagem(DateTime DataHora, string titulo, string subtitulo)
        {
            this.dataHora = DataHora;
            this.Titulo = titulo;
            this.Subtitulo = subtitulo;
        }
        #endregion

        public string excluirPublicacao()
        {
            return "Postagem excluída";
        }

        public string editarSubtitulo(string subtit)
        {
            return "Subtítulo alterado para: " + subtit;
        }

        public string editarTitulo(string tit)
        {
            return "Título alterado para: " + tit;
        }
    }
}
