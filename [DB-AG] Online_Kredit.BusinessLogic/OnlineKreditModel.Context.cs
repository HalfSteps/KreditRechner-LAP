﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------


namespace _DB_AG__Online_Kredit.BusinessLogic
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class dbKreditRechnerEntities : DbContext
{
    public dbKreditRechnerEntities()
        : base("name=dbKreditRechnerEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Arbeitgeber> AlleArbeitgeber { get; set; }

    public DbSet<BeschaeftigungsArt> AlleBeschaeftigungsArten { get; set; }

    public DbSet<Branche> AlleBranchen { get; set; }

    public DbSet<Einstellungen> AlleEinstellungen { get; set; }

    public DbSet<Familienstand> AlleFamilienstandAngaben { get; set; }

    public DbSet<FinanzielleSituation> AlleFinanzielleSituationen { get; set; }

    public DbSet<IdentifikationsArt> AlleIdentifikationsArten { get; set; }

    public DbSet<KontaktDaten> AlleKontaktDaten { get; set; }

    public DbSet<KontoDaten> AlleKontoDaten { get; set; }

    public DbSet<Kunde> AlleKunden { get; set; }

    public DbSet<Land> AlleLänder { get; set; }

    public DbSet<Ort> AlleOrte { get; set; }

    public DbSet<Schulabschluss> AlleSchulabschluesse { get; set; }

    public DbSet<Titel> AlleTitel { get; set; }

    public DbSet<Wohnart> AlleWohnarten { get; set; }

    public DbSet<KreditWunsch> AlleKreditWünsche { get; set; }

    public DbSet<Zahlungsbestätigung> tblZahlungsbestätigung { get; set; }

    public DbSet<Bearbeitungsgebühr> tblBearbeitungsgebühr { get; set; }

}

}

