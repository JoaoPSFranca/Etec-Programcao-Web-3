using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_Veiculo
{
    class Proprietario
    {
        #region Variáveis
        #region Nome
        private string _Nome;
        public string GetNome()
        {
            return _Nome;
        }

        public void SetNome(string Nome)
        {
            _Nome = Nome;
        }
        #endregion

        #region CPF
        private string _CPF;
        public string GetCPF()
        {
            return _CPF;
        }

        public void SetCPF(string CPF)
        {
            _CPF = CPF;
        }
        #endregion

        #region RG
        private string _RG;
        public string GetRG()
        {
            return _RG;
        }

        public void SetRG(string RG)
        {
            _RG = RG;
        }
        #endregion

        #region DataNascimento
        private DateTime _DataNascimento;
        public DateTime GetDataNascimento()
        {
            return _DataNascimento;
        }

        public void SetDataNascimento(DateTime DataNascimento)
        {
            _DataNascimento = DataNascimento;
        }
        #endregion

        #region CNH
        private double _CNH;
        public double GetCNH()
        {
            return _CNH;
        }

        public void SetCNH(double CNH)
        {
            _CNH = CNH;
        }
        #endregion

        #region CNHVencimento
        private DateTime _CNHVencimento;
        public DateTime GetCNHVencimento()
        {
            return _CNHVencimento;
        }

        public void SetCNHVencimento(DateTime CNHVencimento)
        {
            _CNHVencimento = CNHVencimento;
        }
        #endregion
        #endregion

        #region Constructor
        public Proprietario ()
        {
        }
        #endregion
    }
}
