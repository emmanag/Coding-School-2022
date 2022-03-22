using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_14.model;

namespace Session_14.App
{
    internal class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            builder.Property(serviceTask => serviceTask.Code).HasMaxLength(12);
            builder.Property(serviceTask => serviceTask.Description).HasMaxLength(12);
            builder.Property(serviceTask => serviceTask.Hours).HasMaxLength(12);
        }
    }
}
