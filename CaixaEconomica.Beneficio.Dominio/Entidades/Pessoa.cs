﻿using System.Collections.Generic;

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
        public virtual ICollection<Endereco> Enderecos { get; set; }

        public Pessoa()
        {
            Enderecos = new List<Endereco>();
        }




    }
}
