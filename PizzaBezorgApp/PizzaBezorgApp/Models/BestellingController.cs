﻿
using System.Collections.Generic;
using System.Linq;

namespace PizzaBezorgApp.Models
{
    public class BestellingController
    {
        public List<Bestelling> Bestellingen;
        public BestellingController()
        {
            Bestellingen = new List<Bestelling>();
            AddTestBestellingen();
        }

        //Geef een lijst terug van alle pizza bestellingen 
        public List<Bestelling> LoadBestelling()
        {
            var bestelQuery =
            from bestel in Bestellingen
            where bestel  is PizzaBestelling
            select bestel;
            return bestelQuery.ToList();
        }

        public void AddTestBestellingen()
        {
            //test
           Bestellingen.Add(new PizzaBestelling("Karel", "supreme","Breda", "Bergdreef 130", new List<string>{"Americana", "Supreme"}));
           Bestellingen.Add(new PizzaBestelling("Marnix", "Hawaii", "Breda", "Sleutelbloem 56", new List<string> { "Hawaii", "Chicken Kabab"}));
           Bestellingen.Add(new PizzaBestelling("Robert", "Hawaii", "Terheijden", "Wilgenstraat 3", new List<string> { "Hawaii", "Hawaii", "Hawaii" }));
           Bestellingen.Add(new PizzaBestelling("Jean-pierre", "champignons", "Breda", "Dotterbloem 2", new List<string> { "champignons", "Veggie Pizza" }));
        }
    }
}
