using System;
using System.Collections.Generic;

namespace SuiviVaccinationCovidDBFirst.Modeles;

public partial class Vaccin
{
    public int VaccinId { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Dose> Doses { get; } = new List<Dose>();
}
