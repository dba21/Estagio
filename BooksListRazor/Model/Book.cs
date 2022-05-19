using System.ComponentModel.DataAnnotations;

namespace BooksListRazor.Model
{
    public class Book
    {
        //criar Id de forma automatica
        [Key]

        public int Id { get; set; }

        //Campo Name não pode ser nulo, liberta um alerta
        [Required]

        //Sempre que for feita alterações nesta class, tem de ser feito uma autualização na base dados
        //por ex. adicionar a nova propriedade ISBN,no PM > add-migration AddISBNToBookModel, enter, depois update-database 

        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
