
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
    
public partial class Titel
{

    public Titel()
    {

        this.Kunde = new HashSet<Kunde>();

    }


    public int ID { get; set; }

    public string Bezeichnung { get; set; }



    public virtual ICollection<Kunde> Kunde { get; set; }

}

}
