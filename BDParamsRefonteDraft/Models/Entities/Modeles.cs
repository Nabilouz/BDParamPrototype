using System.ComponentModel.DataAnnotations;

namespace BDParamsRefonteDraft.Models.Entities;

public class Modele
{
    [Key]
    public Guid ModeleID{get;set;}
    public string Nom{get;set;}
    public List<Parametre> Parametres{get;set;}

}