namespace DataClass
{
    public class User
    {
        public int UserId { get; set; }
        public string OfficeName { get; set; }
        public string RolName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - BirthDay.Year;

                if (BirthDay.Date > DateTime.Today.AddYears(-edad))
                    edad--;

                return edad;
            }
        }
        public bool Active { get; set; }
    }
}
