using System;
namespace InherenceConstructor
{
    public class Teacher : Person
    {
        public Teacher(string nama,int umur,string teacherid,string subject)
            :base (nama,umur)
        {
            TeacherId = teacherid;
            Subject = subject;
        }
        public string TeacherId { get; set; }
        public string Subject { get; set; }
    }
}
