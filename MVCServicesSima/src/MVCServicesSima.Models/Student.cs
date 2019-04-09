using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCServicesSima.Models
{
  public class Student
    {
       [Key]
       public long StudentId { set; get; }
       
       public string FirstName { set; get; }

       public string MidName { set; get; }

       public string LastName { set; get; }

       public string IdCardNo { set; get; }

       public char NationalCode { set; get; }

       public int IdCardSerial { set; get; }

       public string IdCardSeri { set; get; }

       public int IssueCityId { set; get; }

       public string FatherName { set; get; }

       public int BirthCityId { set; get; }

       public DateTime BirthDate { set; get; }

       public int MaritalStatusId { set; get; }

       public char Sex { set; get; }

       public string Address { set; get; }

       public char PostalCode { set; get; }

       public long Phone { set; get; }

       public long Mobile { set; get; }
       
       public int SacrificeId { set; get; }

       public bool IsSupportiv { set; get; }
       
       public int GradeId{ set; get; }

       public bool IsEmployed { set; get; }
      
       public bool IsScholarship { set; get; }
       
       public DateTime RegisterOn { set; get; }

       public string StartOn { set; get; }

       public int SemesterId { set; get; }

       public int EducationalStatusId { set; get; }

       public int TractId { set; get; }

       public int CenterId { set; get; }

       public int CollegeGroupId { set; get; }

       public int CollegeId { set; get; }

       public int UniversityId { set; get; }

       public bool IsForeign { set; get; }
       
       public int NationalityId { set; get; }

       public string ForeignCode { set; get; }

       public int CuontryId { set; get; }

       public int OrganizationId { set; get; }

       public int DiplomaTypeId { set; get; }

       public int PreUniversityId { set; get; }

       public double ThirdAVG { set; get; }

       public double LastAVG { set; get; }

       public int ReligionId { set; get; }

       public int DisabilityId { set; get; }

       public int MilitaryServiceId { set; get; }
    }
}
