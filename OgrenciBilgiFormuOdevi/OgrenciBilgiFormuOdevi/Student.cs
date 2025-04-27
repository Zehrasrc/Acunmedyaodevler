using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiFormuOdevi
{
    public class Student
    {
        [NotEmptyAttribute(ErrorMessage = "Öğrenci Adı boş bırakılamaz.")]
        public string FirstName { get; set; }

        [NotEmptyAttribute(ErrorMessage = "Öğrenci Soyadı boş bırakılamaz.")]
        public string LastName { get; set; }

        [NotEmptyAttribute(ErrorMessage = "Bölüm boş bırakılamaz.")]
        public string Department { get; set; }

        [NotEmptyAttribute(ErrorMessage = "Cinsiyet boş bırakılamaz.")]
        public string Gender { get; set; }

        [NotEmptyAttribute(ErrorMessage = "Öğrenci Numarası boş bırakılamaz.")]
        public string StudentNumber { get; set; }

    }
}
