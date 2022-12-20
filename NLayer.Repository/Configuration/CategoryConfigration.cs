﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configuration
{
    internal class CategoryConfigration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
           
            builder.Property(x => x.Id).UseIdentityColumn();//ıd değeri 1'er 1'er artacak.
            builder.Property(x => x.name).IsRequired().HasMaxLength(50);//Isrequired=null olmasın.
        }
    }
}
