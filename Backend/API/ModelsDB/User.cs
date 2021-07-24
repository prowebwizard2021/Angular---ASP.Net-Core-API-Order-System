using System;
using System.Collections.Generic;

#nullable disable

namespace API.ModelsDB
{
    public partial class User
    {
        public User()
        {
            UserPhotos = new HashSet<UserPhoto>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] Passwordhash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<UserPhoto> UserPhotos { get; set; }
    }
}
