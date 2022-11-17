using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jestor_SDK.Types
{
    public enum Seats
    {
        [Display(Name = "Membro")]
        member,
        [Display(Name = "Desenvolvedor")]
        developer,
        [Display(Name = "Editor")]
        editor,
        [Display(Name = "Vazio")]
        empty_seat
    }
}
