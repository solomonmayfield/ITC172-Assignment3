﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class BookReviewDbEntities2 : DbContext
{
    public BookReviewDbEntities2()
        : base("name=BookReviewDbEntities2")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<CheckinLog> CheckinLogs { get; set; }
    public virtual DbSet<Reviewer> Reviewers { get; set; }
}