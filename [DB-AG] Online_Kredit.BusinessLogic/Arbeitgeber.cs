
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
    using System.Collections.Generic;
    
public partial class Arbeitgeber
{

    public int ID { get; set; }

    public string Firma { get; set; }

    public int FKBeschaeftigungsArt { get; set; }

    public Nullable<int> FKBranche { get; set; }

    public Nullable<System.DateTime> BeschaeftigtSeit { get; set; }



    public virtual BeschaeftigungsArt BeschaeftigungsArt { get; set; }

    public virtual Branche Branche { get; set; }

    public virtual Kunde Kunde { get; set; }

}

}
