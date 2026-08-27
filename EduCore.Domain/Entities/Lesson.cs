using EduCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Domain.Entities;

public class Lesson : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Order { get; set; }
    public int SessionId { get; set; }
    public Session Session { get; set; } = null!;
}
