using EduCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduCore.Infrastructure.Data.Configurations;

public class CourseTeacherConfiguration : IEntityTypeConfiguration<CourseTeacher>
{
    public void Configure(EntityTypeBuilder<CourseTeacher> builder)
    {
        builder.ToTable("CourseTeachers", "education");

        builder.HasKey(x => new
        {
            x.CourseId,
            x.TeacherId
        });

        builder.HasOne(x => x.Course)
            .WithMany(c => c.CourseTeachers)
            .HasForeignKey(x => x.CourseId);

        builder.HasOne(x => x.Teacher)
            .WithMany(u => u.CourseTeachers)
            .HasForeignKey(x => x.TeacherId);

    }
}
