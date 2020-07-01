using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models
{
    public class EFMainRepository : IMainRepository
    {
        private AplicationDbContext context;

        public EFMainRepository(AplicationDbContext ctx)
        {
            context = ctx;
        }

        #region UserDetails repository
        public IQueryable<UserDetails> UserDetails => context.UserDetails;

        public void SaveUser(UserDetails user)
        {
            if(user.UserDetailsID == 0)
            {
                context.UserDetails.Add(user);
            }
            else
            {
                UserDetails dbEntry = context.UserDetails
                    .FirstOrDefault(p => p.UserDetailsID == user.UserDetailsID);
                if(dbEntry != null)
                {
                    dbEntry.Name = user.Name;
                    dbEntry.Surname = user.Surname;
                    dbEntry.Position = user.Position;
                    dbEntry.Mobile = user.Mobile;
                    dbEntry.Dateofbirth = user.Dateofbirth;
                    dbEntry.Email = user.Email;
                }
                
            }
            context.SaveChanges();
        }

        #endregion

        #region Courses repository
        public IQueryable<Courses> Courses => context.Courses;

        public void SaveCourses(Courses type)
        {
            if (type.CoursesID == 0)
            {
                context.Courses.Add(type);
            }
            else
            {
                Courses dbEntry = context.Courses
                    .FirstOrDefault(p => p.CoursesID == type.CoursesID);
                if (dbEntry != null)
                {
                    dbEntry.CoursesName = type.CoursesName;
                    dbEntry.CoursesDescription = type.CoursesDescription;
                    dbEntry.StartDate = type.StartDate;
                    dbEntry.EndDate = type.EndDate;

                }
            }
            context.SaveChanges();
        }

        public Courses DeleteCourse(int CoursesID)
        {
            Courses dbEntry = context.Courses
                .FirstOrDefault(p => p.CoursesID == CoursesID);
            if(dbEntry != null)
            {
                context.Courses.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        #endregion

        #region About repository
        public IQueryable<About> Abouts => context.Abouts;

        public void SaveAbout(About type)
        {
            if (type.AboutID == 0)
            {
                context.Abouts.Add(type);
            }
            else
            {
                About dbEntry = context.Abouts
                    .FirstOrDefault(p => p.AboutID == type.AboutID);
                if (dbEntry != null)
                {
                    dbEntry.AboutText = type.AboutText;

                }
            }
            context.SaveChanges();
        }

        #endregion

        #region Hobbies repository

        public IQueryable<Hobby> Hobbies => context.Hobbies;

        public void SaveHobbies(Hobby type)
        {
            if (type.HobbyID == 0)
            {
                context.Hobbies.Add(type);
            }
            else
            {
                Hobby dbEntry = context.Hobbies
                    .FirstOrDefault(p => p.HobbyID == type.HobbyID);
                if (dbEntry != null)
                {
                    dbEntry.HobbyText = type.HobbyText;

                }
            }
            context.SaveChanges();
        }

        public Hobby DeleteHobbies(int HobbyID)
        {
            Hobby dbEntry = context.Hobbies
                .FirstOrDefault(p => p.HobbyID == HobbyID);
            if (dbEntry != null)
            {
                context.Hobbies.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        #endregion

        #region Languages repository
        public IQueryable<Language> Languages => context.Languages;

        public void SaveLanguages(Language type)
        {
            if (type.LanguageID == 0)
            {
                context.Languages.Add(type);
            }
            else
            {
                Language dbEntry = context.Languages
                    .FirstOrDefault(p => p.LanguageID == type.LanguageID);
                if (dbEntry != null)
                {
                    dbEntry.LanguageName = type.LanguageName;
                    dbEntry.LanguageLevel = type.LanguageLevel;
                    dbEntry.LanguageDescription = type.LanguageDescription;

                }
            }
            context.SaveChanges();
        }

        public Language DeleteLanguages(int LanguagesID)
        {
            Language dbEntry = context.Languages
                .FirstOrDefault(p => p.LanguageID == LanguagesID);
            if (dbEntry != null)
            {
                context.Languages.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        #endregion

        #region Skills repository
        public IQueryable<Skills> Skills => context.Skills;

        public void SaveSkills(Skills type)
        {
            if (type.SkillsID == 0)
            {
                context.Skills.Add(type);
            }
            else
            {
                Skills dbEntry = context.Skills
                    .FirstOrDefault(p => p.SkillsID == type.SkillsID);
                if (dbEntry != null)
                {
                    dbEntry.SkillName = type.SkillName;
                    dbEntry.SkillLevel = type.SkillLevel;
                    dbEntry.SkillDescription = type.SkillDescription;
                   

                }
            }
            context.SaveChanges();
        }

        public Skills DeleteSkills(int SkillsID)
        {
            Skills dbEntry = context.Skills
                .FirstOrDefault(p => p.SkillsID == SkillsID);
            if (dbEntry != null)
            {
                context.Skills.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        #endregion

        #region UserAdress repository
        public IQueryable<UserAdress> UserAdresses => context.UserAdress;

        public void SaveAdress(UserAdress type)
        {
            if (type.UserAdressID == 0)
            {
                context.UserAdress.Add(type);
            }
            else
            {
                UserAdress dbEntry = context.UserAdress
                    .FirstOrDefault(p => p.UserAdressID == type.UserAdressID);
                if (dbEntry != null)
                {
                    dbEntry.Line1 = type.Line1;
                    dbEntry.Line2 = type.Line2;
                    dbEntry.Line3 = type.Line3;
                    dbEntry.City = type.City;
                    dbEntry.Postcode = type.Postcode;

                }
            }
            context.SaveChanges();
        }

       

        #endregion

        #region Work repository
        public IQueryable<Work> Works => context.Works;

        public void SaveWork(Work type)
        {
            if (type.WorkID == 0)
            {
                context.Works.Add(type);
            }
            else
            {
                Work dbEntry = context.Works
                    .FirstOrDefault(p => p.WorkID == type.WorkID);
                if (dbEntry != null)
                {
                    dbEntry.WorkName = type.WorkName;
                    dbEntry.WorkPosition = type.WorkPosition;
                    dbEntry.WorkStartDate = type.WorkStartDate;
                    dbEntry.WorkEndDate = type.WorkEndDate;
                   

                }
            }
            context.SaveChanges();
        }

        public Work DeleteWork(int WorkID)
        {
            Work dbEntry = context.Works
                .FirstOrDefault(p => p.WorkID == WorkID);
            if (dbEntry != null)
            {
                context.Works.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
        #endregion
    }
}
