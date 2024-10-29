namespace GoAuction.Models
{
    public abstract class User
    {
        public int Id_user { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public Boolean Active { get; set; }

        protected User(int id_user, string name, string mail, string password, DateTime creationDate, bool active)
        {
            Id_user = id_user;
            Name = name;
            Mail = mail;
            Password = password;
            CreationDate = creationDate;
            Active = active;
        }

        public abstract bool PuedeComprar { get; }
        public abstract bool PuedeVender { get; }
        public abstract bool EsAdministrador { get; }

    }
}
