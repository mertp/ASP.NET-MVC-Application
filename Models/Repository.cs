using System.Collections.Generic;

namespace FirstWebApp.Models
{
    public static class Repository
    {
        private static List<Student> _students=new List<Student>(); 

        public static List<Student> Students{
            get{
                return _students;
            }
        }  //Repository.Students diyerek erişebilirim.

        public static  void AddStudent(Student std){
            _students.Add(std);
        }  //Repository.AddStudent(std) ile kayıt eklenebilir. 
    }
}