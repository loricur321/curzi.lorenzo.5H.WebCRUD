using System.ComponentModel.DataAnnotations;

namespace curzi.lorenzo._5H.WebCRUDE.Models;
public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Titolo", Prompt = "Inserire il titolo....", Description = "Titolo del film")]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data di pubblicazione", Prompt = "Inserire la data di pubblicazione", Description = "Data di pubblicazione del film")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Genere", Prompt = "Inserire il genere del film", Description = "Genere del film")]
    public string? Genre { get; set; }

    [Display(Name = "Prezzo", Prompt = "Inserire il prezzo d'acquisto del film", Description = "Prezzo d'acquiesto del film in euro")]
    public decimal Price { get; set; }

}