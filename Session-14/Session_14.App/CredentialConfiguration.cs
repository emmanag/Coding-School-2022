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
    internal class CredentialConfiguration : IEntityTypeConfiguration<Credential>
    {
        public void Configure(EntityTypeBuilder<Credential> builder)
        {
            builder.Property(credential => credential.Username).HasMaxLength(15);
            builder.Property(credential => credential.Password).HasMaxLength(15);
            
        }
    }
}
