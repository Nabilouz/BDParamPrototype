using System.ComponentModel.DataAnnotations;

namespace BDParamsRefonteDraft.Models.Entities;

public class Capteur
{
    [Key]
    public Guid CapteurId{get;set;}
    public string Nom{get;set;}
    public Modele Modele{get;set;}

}