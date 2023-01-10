using Microsoft.EntityFrameworkCore;
using SuiviVaccinationCovidCodeFirst.Modeles;

class Program
{
static void Main(string[] _)
{
    VaccinationContext context = new();
        
    Vaccin pfizer = new() { Nom = "Pfizer-BioNTech" };
    Vaccin moderna = new() { Nom = "Moderna" };
    Vaccin astrazenica = new() { Nom = "AstraZeneca" };
    Vaccin janssen = new() { Nom = "Janssen" };

    context.Vaccins.AddRange(pfizer, moderna, astrazenica, janssen);

    Dose dose1Mylene = new()
    {
        Date = new DateTime(2021, 06, 15),
        NAMPatient = "LAPM12345678",
        Vaccin = moderna
    };

    Dose dose2Mylene = new()
    {
        Date = DateTime.Today,
        NAMPatient = "LAPM12345678",
        Vaccin = moderna
    };

    Dose dose1Gaston = new()
    {
        Date = new DateTime(2021, 8, 22),
        NAMPatient = "BHEG12345678",
        Vaccin = pfizer
    };

    context.Doses.Add(dose1Mylene);
    context.Doses.Add(dose2Mylene);
    context.Doses.Add(dose1Gaston);
    context.SaveChanges();

    context.Remove(dose1Gaston);
    dose1Mylene.Vaccin = pfizer;
    context.SaveChanges();

    foreach (Dose v in context.Doses)
        Console.WriteLine(v);
    Console.ReadKey();
}
}
