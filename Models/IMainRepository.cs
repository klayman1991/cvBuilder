using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CvNetCore2.Models
{
    public interface IMainRepository
    {
        //User
        IQueryable<UserDetails> UserDetails { get; }
        void SaveUser(UserDetails userDetails);

        //UserAdress
        IQueryable<UserAdress> UserAdresses { get; }
        void SaveAdress(UserAdress type);

        //About
        IQueryable<About> Abouts { get; }
        void SaveAbout(About type);

        //Courses
        IQueryable<Courses> Courses { get; }
        void SaveCourses(Courses type);
        Courses DeleteCourse (int CoursesID);

        //Hobbies
        IQueryable<Hobby> Hobbies { get; }
        void SaveHobbies(Hobby type);
        Hobby DeleteHobbies(int HobbiesID);

        //Languages
        IQueryable<Language> Languages { get; }
        void SaveLanguages(Language type);
        Language DeleteLanguages(int LanguagesID);

        //Skills
        IQueryable<Skills> Skills { get; }
        void SaveSkills(Skills type);
        Skills DeleteSkills(int SkillsID);

        //Work
        IQueryable<Work> Works { get; }
        void SaveWork(Work type);
        Work DeleteWork(int WorkID);
    }
}
