using EduCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Domain.Entities;

public class Session : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Order {  get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}
