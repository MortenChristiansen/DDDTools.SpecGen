using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTools.SpecGen.TestClientLibrary
{
    static class Features
    {
        public const string PlanetBuster = "PlanetBuster";
        public const string WeaponBatteries = "WeaponBatteries";
        public const string FighterBays = "FighterBays";
        public const string Hangars = "Hangars";
    }

    static class Domains
    {
        public const string Weapons = "Weapons";
        public const string SpaceStations = "SpaceStations";
        public const string Spaceships = "Spaceships";
        public const string Power = "Power";
        public const string Personnel = "Personnel";
    }

    static class Modules
    {
        public const string StationBatteries = "StationBatteries";
        public const string ShipMounted = "ShipMounted";
        public const string Fighters = "Fighters";
        public const string Cruisers = "Cruisers";
        public const string Soldiers = "Soldiers";
        public const string Contractors = "Contractors";
        public const string Staff = "Staff";
    }
}
