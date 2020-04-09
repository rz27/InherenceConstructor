using System;
namespace InherenceConstructor
{
    public class Students : Person
    {
        public Students(string nama,int umur,string studentid,string email)
            :base(nama,umur)
        {
            StudentId = studentid;
            Email = email;

        }
        public string StudentId { get; set; }
        public string Email { get; set; }
    }
}
