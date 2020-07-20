﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public class Beneficio : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime  DataInicioVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public bool Ativo { get; set; }

        //Relacionamento de 1(Beneficio) Para Muitos(BeneficioPessoa)
        private readonly HashSet<BeneficioPessoa> _beneficioPessoas = new HashSet<BeneficioPessoa>();
        public IEnumerable<BeneficioPessoa> BeneficioPessoas => _beneficioPessoas.ToList().AsReadOnly();

    }
}
