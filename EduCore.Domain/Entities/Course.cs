using EduCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Domain.Entities;

public class Course : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsPublished { get; set; }
    public ICollection<CourseTeacher> CourseTeachers { get; set; } = new List<CourseTeacher>();
    public ICollection<Session> Sessions { get; set; } = new List<Session>();
}
