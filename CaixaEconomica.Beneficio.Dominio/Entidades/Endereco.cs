﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public class Endereco: Entidade
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }

        /// <summary>
        ///  TipoEnderecoId =1: Residencial 
        ///  TipoEnderecoId =2: Trabalho 
        ///  
        /// </summary>
        public int TipoEnderecoId { get; set; }

        //Relacionamento de 1(Endereco) para 1(Pessoa)
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        
    }
}
