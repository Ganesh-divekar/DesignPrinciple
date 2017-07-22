using System;
using Models;
using System.Collections.Generic;
namespace TrainSignallingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

TrainController trainController = new TrainController();
trainController.Depart();
            var Stations = new List<Station>();            
            Stations.Add(new Station {Name = "s1" });
            Stations.Add(new Station {Name = "s2" });
            Stations.Add(new Station {Name = "s3" });
            Stations.Add(new Station {Name = "s4" });
            //var Routes = new 
        }
    }
}
