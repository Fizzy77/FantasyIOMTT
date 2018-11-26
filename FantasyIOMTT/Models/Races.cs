using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyIOMTT.Models
{
    public class Races
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public DateTime RaceDate { get; set; }
        public DateTime RaceTime { get; set; }
        public int Laps { get; set; }
        public Decimal RecordLapMPH { get; set; }
        public TimeSpan RecordLapTime { get; set; }
        public Decimal RecordRaceMPH { get; set; }
        public TimeSpan RecordRaceTime { get; set; }
    }
}
