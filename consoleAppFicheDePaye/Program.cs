using Microsoft.VisualBasic;

namespace consoleAppFicheDePaye
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string nom;
            Console.WriteLine("Quel est votre nom ? ");
            nom = Console.ReadLine();

            string prenom;
            Console.WriteLine("Quel est votre prénom ? ");
            prenom = Console.ReadLine();

            string mois;
            Console.WriteLine("Quel est le mois de la fiche de paie ? ");
            mois = Console.ReadLine();

            decimal horaireMensuel;
            Console.WriteLine("Combien d'heure travaillé par mois ? ");
            horaireMensuel = decimal.Parse(Console.ReadLine());

            decimal salaireHoraire;
            Console.WriteLine("Quel est le salaire horaire ? ");
            salaireHoraire = decimal.Parse(Console.ReadLine());

            decimal salairebrut = horaireMensuel * salaireHoraire;

            decimal tauxComplementaireSanté = 20m;
            //decimal complementaireSanté = salairebrut - tauxComplementaireSanté;

            decimal tauxVieillesse = 0.073m;
            decimal vieillesse = salairebrut * tauxVieillesse;

            decimal tauxRetraiteComplémentaire = 0.0315m;
            decimal retraiteComplémentaire = salairebrut * tauxRetraiteComplémentaire;

            decimal tauxContributionEquilibrGénéral = 0.0086m;
            decimal contributionEquilibrGénéral = salairebrut * tauxContributionEquilibrGénéral;

            decimal tauxCSGDéductible = 0.068m;
            decimal CSGDéductible = salairebrut * tauxCSGDéductible;

            decimal tauxCSGNonDéductible = 0.024m;
            decimal CSGNonDéductible = salairebrut * tauxCSGNonDéductible;

            decimal tauxCRDS = 0.005m;
            decimal CRDS = salairebrut * tauxCRDS;

            decimal totalCotisations = tauxComplementaireSanté + vieillesse + retraiteComplémentaire + contributionEquilibrGénéral + CSGDéductible + CSGNonDéductible + CRDS;

            decimal tauxComplementaireSantéPatron = 20m;

            decimal TauxMaladie = 0.073m;
            decimal Maladie = salairebrut * TauxMaladie;

            decimal tauxCotisationAccidentsDuTravail = 0.0224m;
            decimal cotisationAccidentsDuTravail = salairebrut * tauxCotisationAccidentsDuTravail;

            decimal tauxVieillessePatron = 0.001045m;
            decimal vieillessePatron = salairebrut * tauxVieillessePatron;

            decimal tauxRetraiteComplémentairePatron = 0.0472m;
            decimal retraiteComplémentairePatron = salairebrut * tauxRetraiteComplémentairePatron;  

            decimal tauxContributionEquilibrGénéralPatron = 0.0129m;
            decimal contributionEquilibrGénéralPatron = salairebrut * tauxContributionEquilibrGénéralPatron;

            decimal tauxAllocationsFamiliales = 0.0345m;
            decimal allocationsFamiliales = salairebrut * tauxAllocationsFamiliales;

            decimal tauxContributionauFondsNationalAideauLogement = 0.001m;
            decimal contributionauFondsNationalAideauLogement = salairebrut * tauxContributionauFondsNationalAideauLogement;

            decimal tauxChômage = 0.0405m;
            decimal chômage = salairebrut * tauxChômage;

            decimal tauxCotisationAuRégimeDeGarantieDesSalaires = 0.015m;
            decimal cotisationAuRégimeDeGarantieDesSalaires = salairebrut * tauxCotisationAuRégimeDeGarantieDesSalaires;

            decimal tauxFormationProfessionnelle = 0.055m;
            decimal formationProfessionnelle = salairebrut * tauxFormationProfessionnelle;

            decimal tauxTaxeApprentissage = 0.068m;
            decimal taxeApprentissage = salairebrut * tauxTaxeApprentissage;

            decimal tauxContributionAuDialogueSocial = 0.0002m;
            decimal contributionAuDialogueSocial = salairebrut * tauxContributionAuDialogueSocial;

            decimal ExonérationsCotisationsPatronales = 0.32m;
            decimal exonérationsCotisationsPatronales = salairebrut * ExonérationsCotisationsPatronales;

            decimal totalCotisationsPatronales = tauxComplementaireSantéPatron + Maladie + cotisationAccidentsDuTravail + vieillessePatron + retraiteComplémentairePatron + contributionEquilibrGénéralPatron + allocationsFamiliales + contributionauFondsNationalAideauLogement + chômage + cotisationAuRégimeDeGarantieDesSalaires + formationProfessionnelle + taxeApprentissage + contributionAuDialogueSocial - exonérationsCotisationsPatronales;

            decimal salaireNet = salairebrut - totalCotisations;

            decimal salairTotal = salairebrut + totalCotisationsPatronales;


            Console.WriteLine($"Complémentaire Santé: {tauxComplementaireSanté:C}");
            Console.WriteLine($"Vieillesse: {vieillesse:C}");
            Console.WriteLine($"Retraite Complémentaire: {retraiteComplémentaire:C}");
            Console.WriteLine($"Contribution Équilibrée Générale: {contributionEquilibrGénéral:C}");
            Console.WriteLine($"CSG Déductible: {CSGDéductible:C}");
            Console.WriteLine($"CSG Non Déductible: {CSGNonDéductible:C}");
            Console.WriteLine($"CRDS: {CRDS:C}");
            Console.WriteLine($"total Cotisations: {totalCotisations:C}\n \n");
            Console.WriteLine($"Cotisations patronales:");


        }
    }
}
