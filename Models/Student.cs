using System.ComponentModel.DataAnnotations;

namespace FirstWebApp.Models
{
    public class Student
    {
        [Required (ErrorMessage ="İsminizi Giriniz.")]
        public string name { get; set; }

        [Required (ErrorMessage ="Email Giriniz")]
        [EmailAddress(ErrorMessage ="Maili Düzgün Giriniz")]
        public string email { get; set; }

        [Required (ErrorMessage =   "Telefon numarası Giriniz")]
        public string phone { get; set; }

        [Required (ErrorMessage ="Katılım Durumunuzu Belirtiniz")]
        public bool? confirm { get; set; }
    }
}