using CaixaEconomica.Beneficio.Dominio.Notification;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public class Pessoa: Entidade  
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string SobreNome  { get; set; }

        public int Idade { get; set; }
        public int QuantidadeFilhos { get; set; }

        /*
         * 02 Empregado
         * 11 Profissional Liberal
         */
        public int CodigoOcupacao { get; set; }

        //Relacionamento de 1(Pessoa) para Muitos(Endereco)
        // Backing Field
        private readonly HashSet<Endereco> _enderecos = new HashSet<Endereco>();
        public IEnumerable<Endereco> Enderecos => _enderecos.ToList().AsReadOnly();

        public Pessoa()
        {
            // vai ficar dessa forma enquanto a injeção de dep.. não estiver configurado
            SetNotificacao(new NotificacaoDominio());
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            if(endereco == null)
            {
                NotificacaoDominio.AddErro("Erro: endereco deve ser instanciado");
            }
            else
            {
                // vai ficar dessa forma enquanto a injeção de dep.. não estiver configurado
                endereco.SetNotificacao(new NotificacaoDominio());

                endereco.Validar();
                if (endereco.EhValido())
                    _enderecos.Add(endereco);
                else
                    NotificacaoDominio.AddErro("Endereco não foi adicionado porque não é válido");                        
            }
        }

        //Relacionamento de 1(Pessoa) Para Muitos(BeneficioPessoa)
        // Backing Field
        private readonly HashSet<BeneficioPessoa> _beneficioPessoas = new HashSet<BeneficioPessoa>();
        public IEnumerable<BeneficioPessoa> BeneficioPessoas => _beneficioPessoas.ToList().AsReadOnly();
                                        
    }
}
