using MyCouse.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCouse.Models.ViewModels
{
    
    //Eredita tuttii campi di CourseView model in più ne aggiunge altri
    //tra cui il list delle lezioni che è di tipo LessonViewModel
    public class CourseDetailViewModel:CourseViewModel
    {
        public string Description { get; set; }
        public List<LessonViewModel> Lessons { get; set; }

        public TimeSpan TotalCourseDuration()
        {
            //get => TimeSpan.FromSeconds(Lessons?.Sum(l => l.Duration.TotalSeconds) ?? 0);
            TimeSpan total = TimeSpan.FromSeconds(0);
            foreach(LessonViewModel lesson in Lessons)
            {
                total = total + lesson.Duration;
            }

            return total;

        }

    }


}