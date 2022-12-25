using System.ComponentModel.DataAnnotations;
using BDParamsRefonteDraft.Models.Interfaces;

namespace BDParamsRefonteDraft.Models.Entities;

public class Parametre : IParametre
{
    [Key]
    public Guid ParametreId{get;set;}
    public string Nom{get;set;}
    public double Valeur{get;set;}
    public string Description{get;set;}

    public bool RegleValidation()
    {
        throw new NotImplementedException();
    }
}