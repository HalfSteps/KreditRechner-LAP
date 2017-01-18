using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _DB_AG__Online_Kredit.Controllers
{
    public class FreigabeController : Controller
    {
        [HttpGet]
        public ActionResult Index(bool erfolgreich)
        {
            Debug.WriteLine("");
            Debug.Indent();
            //Models.ZusammenfassungsModel model = null;
            //model = context.AlleKreditWünsche.Where(x => x.ID == k_id).FirstOrDefault();
            //_DB_AG__Online_Kredit.Models.ZusammenfassungsModel Daten = new Models.ZusammenfassungsModel();
            
            Debug.WriteLine("HttpGet: KreditVerwaltung/Zusammenfassung");

            Models.ZusammenfassungsModel model = new Models.ZusammenfassungsModel();

            model.ID_Kunde = int.Parse(Request.Cookies["id"].Value);
            Response.Cookies.Add(new HttpCookie("zsmid", "true"));

            BusinessLogic.Kunde aktKunde = BusinessLogic.KreditVerwaltung.KundeLaden(model.ID_Kunde);
            BusinessLogic.Ort aktKundenOrt = BusinessLogic.KreditVerwaltung.OrtDatenLaden(model.ID_Kunde);

            model.Betrag = (int)aktKunde.KreditWunsch.Betrag;
            model.Laufzeit = aktKunde.KreditWunsch.Laufzeit;

            model.Betrag = (int)aktKunde.KreditWunsch.Betrag;
            model.Laufzeit = aktKunde.KreditWunsch.Laufzeit;

            model.MonatsNettoEinkommen = (double)aktKunde.FinanzielleSituation.MonatsEinkommenNetto.Value;
            model.Wohnkosten = (double)aktKunde.FinanzielleSituation.Wohnkosten.Value;
            model.EinkuenfteAlimenteUnterhalt = (double)aktKunde.FinanzielleSituation.EinkuenfteAlimenteUnterhalt.Value;
            model.AusgabenAlimenteUnterhalt = (double)aktKunde.FinanzielleSituation.AusgabenAlimenteUnterhalt.Value;
            model.Raten = (double)aktKunde.FinanzielleSituation.Raten.Value;

            model.Geschlecht = aktKunde.Geschlecht == "m" ? "Herr" : "Frau";
            model.Vorname = aktKunde.Vorname;
            model.Nachname = aktKunde.Nachname;
            model.Titel = aktKunde.Titel?.Bezeichnung;
            model.Geburtsdatum = DateTime.Now;
            model.Staatsangehoerigkeit = aktKunde.Staatsangehoerigkeit?.Bezeichnung;
            model.Familienstand = aktKunde.Familienstand?.Bezeichnung;
            model.Wohnart = aktKunde.Wohnart?.Bezeichnung;
            model.Schulabschluss = aktKunde.Schulabschluss?.Bezeichnung;
            model.IdentifikationsArt = aktKunde.IdentifikationsArt?.Bezeichnung;
            model.IdentifikationsNummer = aktKunde.IdentifikationsNummer;

            model.FirmaName = aktKunde.Arbeitgeber?.Firma;
            model.Branche = aktKunde.Arbeitgeber?.Branche?.Bezeichnung;
            model.BeschaeftigungsArt = aktKunde.Arbeitgeber?.BeschaeftigungsArt?.Bezeichnung;
            model.BeschaeftigtSeit = aktKunde.Arbeitgeber?.BeschaeftigtSeit.Value.ToShortDateString();

            model.Strasse = aktKunde.KontaktDaten?.Strasse;
            model.Hausnummer = aktKunde.KontaktDaten?.Hausnummer;
            model.Land = aktKundenOrt.FKLand;
            model.Ort = aktKundenOrt.Bezeichnung;
            model.PLZ = aktKundenOrt.PLZ;
            model.EMail = aktKunde.KontaktDaten?.EMail;
            model.Telefonnummer = aktKunde.KontaktDaten?.Telefonnummer;

            model.NeuesKonto = (bool)aktKunde.KontoDaten?.HatKonto;
            model.Bank = aktKunde.KontoDaten?.Bank;
            model.IBAN = aktKunde.KontoDaten?.IBAN;
            model.BIC = aktKunde.KontoDaten?.BIC;

            var tuple = new Tuple<Models.ZusammenfassungsModel, Boolean? >(model, erfolgreich);

            Debug.Unindent();
            return View(tuple);
        }
    }
}