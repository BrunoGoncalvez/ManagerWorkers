using ManagerWorkers.Core.Exceptions;

namespace ManagerWorkers.Core.Entities
{
    public class User : EntityBase
    {

        public User(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Nome é obrigatório");

            if (string.IsNullOrWhiteSpace(email))
                throw new DomainException("Email é obrigatório");

            Name = name;
            Email = email;
            CreatedIn = DateTime.UtcNow;
        }

        public string Name { get; private set; } = String.Empty;

        public string Email { get; private set; } = String.Empty;

        public string Password { get; private set; } = String.Empty;

        public DateTime CreatedIn { get; private set; }

        public DateTime UpdatedIn { get; private set; }

        // Foreign Key
        public int RoleId { get; private set; }

        // Navegação
        public Role Role { get; private set; } = new();


        /* Métodos */
        public void SetPassword(string passwordHash)
        {

            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new DomainException("Senha inválida.");

            Password = passwordHash;
            UpdatedIn = DateTime.UtcNow;
        }

    }
}
