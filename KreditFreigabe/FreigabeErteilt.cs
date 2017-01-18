using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreditFreigabe
{
    public class FreigabeErteilt
    {


        public static bool Freigabe(
            string geschlecht,
            string vorname,
            string nachname,
            string familienStand,
            double monatsEinkommenNetto,
            double wohnKosten,
            double einkuenfteAlimenteUnterhalt,
            double ausgabenAlimenteUnterhalt,
            double raten)
        {
            Debug.WriteLine("KreditFreigabe - FreigabeErteilt");
            Debug.Indent();
            bool freigabe = false;

            if (string.IsNullOrEmpty(vorname))
                throw new ArgumentNullException(nameof(vorname));
            if (string.IsNullOrEmpty(nachname))
                throw new ArgumentNullException(nameof(nachname));
            if (monatsEinkommenNetto <= 0 || monatsEinkommenNetto > 100000)
                throw new ArgumentException($"Ungültigter Wert für {nameof(monatsEinkommenNetto)}");
            if (wohnKosten <= 0 || wohnKosten > 100000)
                throw new ArgumentException($"Ungültigter Wert für {nameof(wohnKosten)}");
            if (einkuenfteAlimenteUnterhalt <= 0 || einkuenfteAlimenteUnterhalt > 100000)
                throw new ArgumentException($"Ungültigter Wert für {nameof(einkuenfteAlimenteUnterhalt)}");
            if (ausgabenAlimenteUnterhalt <= 0 || ausgabenAlimenteUnterhalt > 100000)
                throw new ArgumentException($"Ungültigter Wert für {nameof(ausgabenAlimenteUnterhalt)}");
            if (raten <= 0 || raten > 100000)
                throw new ArgumentException($"Ungültigter Wert für {nameof(raten)}");

            double verfügbarerBetrag = monatsEinkommenNetto + einkuenfteAlimenteUnterhalt - wohnKosten - einkuenfteAlimenteUnterhalt - ausgabenAlimenteUnterhalt - raten;
            double verhältnisWohnkostenVerfügbarerBetrag = wohnKosten / verfügbarerBetrag;

            switch (familienStand)
            {
                case "ledig":
                case "Geschieden":
                case "verwitwet":
                    switch (geschlecht)
                    {
                        case "m":
                            freigabe = verfügbarerBetrag > wohnKosten * 2;
                            break;
                        case "w":
                            freigabe = verfügbarerBetrag > wohnKosten * 1.8;
                            break;
                        default:
                            throw new ArgumentException($"Ungültiger Wert für {nameof(geschlecht)}!\n\nNur 'm' oder 'w' erlaubt.");
                    }

                    break;
                case "in Partnerschaft":
                case "verheiratet":
                    if (verhältnisWohnkostenVerfügbarerBetrag < 0.5)
                    {
                        freigabe = verfügbarerBetrag > wohnKosten * 2.5;
                    }
                    else
                    {
                        freigabe = verfügbarerBetrag > wohnKosten * 3.5;
                    }
                    break;
                default:
                    throw new ArgumentException($"Ungültiger Wert für {nameof(familienStand)}!\n\nNur 'ledig', 'verwitwet', 'in Partnerschaft', 'verheiratet' erlaubt.");
            }

            Debug.Unindent();
            return freigabe;
        }

    }
}
