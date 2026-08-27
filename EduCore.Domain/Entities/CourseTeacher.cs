using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Domain.Entities;

public class CourseTeacher
{
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public int TeacherId { get; set; }
    public ApplicationUser Teacher { get; set; } = null!; 
}
