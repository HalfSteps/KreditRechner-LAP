
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace _DB_AG__Online_Kredit.BusinessLogic
{

using System;
    using System.Collections.Generic;
    
public partial class FinanzielleSituation
{

    public int ID { get; set; }

    public Nullable<decimal> MonatsEinkommenNetto { get; set; }

    public Nullable<decimal> Wohnkosten { get; set; }

    public Nullable<decimal> EinkuenfteAlimenteUnterhalt { get; set; }

    public Nullable<decimal> AusgabenAlimenteUnterhalt { get; set; }

    public Nullable<decimal> Raten { get; set; }



    public virtual Kunde Kunde { get; set; }

}

}