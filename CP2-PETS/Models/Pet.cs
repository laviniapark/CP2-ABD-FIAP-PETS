using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CP2_PETS.Models;

public class Pet
{
    [HiddenInput]
    public int Id { get; set; }
    
    public string Nome {get; set;}
    
    public TipoPet Tipo {get; set;}
    
    [Display(Name = "Raça")]
    public string? Raca {get; set;}
    
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento {get; set;}
    
    public SexoPet Sexo {get; set;}
    
    public double? Peso {get; set;}
    
    [Display(Name = "Nome Completo do Dono")]
    public string NomeDono {get; set;}
    
    [Display(Name = "Telefone do Dono")]
    public string ContatoDono { get; set; }
    
    [Display(Name = "É vacinado?")]
    public bool Vacinado {get; set;}

    public enum TipoPet
    {
        Cachorro,
        Gato,
        [Display(Name = "Pássaro")]
        Passaro,
        Peixe,
        Coelho,
        Hamster,
        [Display(Name = "Réptil")]
        Reptil,
        [Display(Name = "Porquinho Da Índia")]
        PorquinhoDaIndia,
        Cavalo,
        Outros
    }

    public enum SexoPet
    {
        Macho,
        [Display(Name = "Fêmea")]
        Femea
    }
}