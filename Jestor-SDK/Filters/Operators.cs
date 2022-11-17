using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jestor_SDK.Filters
{
    public enum Operators
    {
        [Display(Name = "Igual")]
        equal,
        [Display(Name = "Diferente")]
        not_equal,
        [Display(Name = "Contém")]
        like,
        [Display(Name = "Não contém")]
        notLike,
        [Display(Name = "Começa com")]
        startsWith,
        [Display(Name = "Na lista")]
        list,
        [Display(Name = "Fora da lista")]
        notInList,
        [Display(Name = "Nulo")]
        is_null,
        [Display(Name = "Nulo ou vazio")]
        nullOrEmpty,
        [Display(Name = "Não é nulo")]
        is_not_null,
        [Display(Name = "Não é nulo ou não é vazio")]
        nullOrFilled,
        [Display(Name = "Maior que")]
        gt,
        [Display(Name = "Maior ou igual que")]
        gte,
        [Display(Name = "Menor que")]
        lt,
        [Display(Name = "Menor ou igual que")]
        lte
    }
}
