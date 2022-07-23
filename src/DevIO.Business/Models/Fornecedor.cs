﻿using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity 
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 11)]
        public string MyProperty { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */

        public IEnumerable<Produto> Produtos { get; set; }

    }
}
