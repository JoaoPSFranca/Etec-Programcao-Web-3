using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_Veiculo
{
    class Veiculo
    {
        #region Variáveis
        #region RENAVAM
        private double _RENAVAM;
        public double GetRENAVAM()
        {
            return _RENAVAM;
        }

        public void SetRENAVAM(double RENAVAM)
        {
            _RENAVAM = RENAVAM;
        }
        #endregion

        #region AnoFabricacao
        private int _AnoFabricacao;
        public int GetAnoFabricacao()
        {
            return _AnoFabricacao;
        }

        public void SetAnoFabricacao(int AnoFabricacao)
        {
            _AnoFabricacao = AnoFabricacao;
        }
        #endregion

        #region AnoModelo
        private int _AnoModelo;
        public int GetAnoModelo()
        {
            return _AnoModelo;
        }

        public void SetAnoModelo(int AnoModelo)
        {
            _AnoModelo = AnoModelo;
        }
        #endregion

        #region NomeModelo
        private string _NomeModelo;
        public string GetNomeModelo()
        {
            return _NomeModelo;
        }

        public void SetNomeModelo(string NomeModelo)
        {
            _NomeModelo = NomeModelo;
        }
        #endregion

        #region Proprietario
        private Proprietario _Proprietario;
        public Proprietario GetProprietario()
        {
            return _Proprietario;
        }

        public void SetPropietario(Proprietario Proprietario)
        {
            _Proprietario = Proprietario;
        }
        #endregion

        private bool onOff = false;
        #endregion

        #region Constructor
        public Veiculo ()
        {
        }
        #endregion

        public string LigarDesligar()
        {
            onOff = !onOff;
            if (onOff)
                return "O veículo Ligou ";
            else
                return "O veículo desligou ";
        }

        public string Acelerar()
        {
            return "O veículo está acelerando ";
        }

        public string Frear()
        {
            return "O veículo freou ";
        }
    }
}
