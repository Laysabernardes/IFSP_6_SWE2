namespace TP01.Models

// Laysa Bernardes Campos da Rocha -  CB3024873
// Lucas Lopes Cruz - CB3025284

{
    public class Author
    {
        public string Name { get; }
        public string Email { get; }
        public char Gender { get; }

        public Author(string name, string email, char gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public override string ToString() =>
            $"Author[name={Name}, email={Email}, gender={Gender}]";
    }
}
