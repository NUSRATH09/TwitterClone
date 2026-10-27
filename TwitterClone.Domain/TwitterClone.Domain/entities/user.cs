using System.Reflection.Metadata.Ecma335;


namespace TwitterClone.Domain.entities
{
    public class user
    {
        private Guid _id;
        private string _firstname;
        private string lastname;
        private string email;
        public user()
        { 
            _id = Guid.NewGuid(); 
        }
        public Guid Id
        {
            get { retuen _id; }
        }
    
    public string Firstname()
        {
            get{ return _Firstname; }
            set{ _Firstname = value; }

        }
    }
}
