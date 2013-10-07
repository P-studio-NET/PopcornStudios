﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program1
    {
        internal static void Main1(string[] args)
        {
            AircraftDataAnalysisWcfService.AircraftService serv
                = new AircraftDataAnalysisWcfService.AircraftService();
            //serv.DeleteAircraft("F4D");
            serv.AddOrUpdateAircraftModel(
                new FlightDataEntities.AircraftModel()
                {
                    ModelName = "F4D",
                    Caption = "机型F4D Aircraft",
                    LastUsed = DateTime.Now
                });

            var models = serv.GetAllAircraftModels();

            foreach (var m in models)
            {
                m.ToString();
            }

            Console.ReadLine();
        }

        internal static void Main2(string[] args)
        {
            AircraftDataAnalysisWcfService.AircraftService serv
                = new AircraftDataAnalysisWcfService.AircraftService();
            //serv.DeleteAircraft("F4D");
            serv.AddOrUpdateAircraftInstance(
                new FlightDataEntities.AircraftInstance()
                {
                    AircraftModel =
                        new FlightDataEntities.AircraftModel()
                        {
                            ModelName = "F4D",
                            Caption = "机型F4D Aircraft",
                            LastUsed = DateTime.Now
                        },
                    AircraftNumber = "0004",
                    LastUsed = DateTime.Now
                }
                );

            IEnumerable<FlightDataEntities.AircraftInstance> instances
                = serv.GetAllAircraftInstances();

            foreach (var m in instances)
            {
                m.ToString();
            }

            Console.ReadLine();
        }

        internal static void Main3(string[] args)
        {
            FlightDataEntities.FlightParameter[] parameters = ReadXmlParameters("F4D", @"C:\Users\LibreK\SkyDrive\Coding\AircraftAnalysis\FlyParaPro\FlyParamBusiness\FlyParameter.xml");

            AircraftDataAnalysisWcfService.AircraftService serv
                = new AircraftDataAnalysisWcfService.AircraftService();

            serv.AddOrUpdateFlyParameter(parameters);

            IEnumerable<FlightDataEntities.FlightParameter> instances
                = serv.GetAllFlightParameters("F4D");

            foreach (var m in instances)
            {
                m.ToString();
            }

            Console.ReadLine();
        }

        private static FlightDataEntities.FlightParameter[] ReadXmlParameters(string modelName, string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                XElement root = XElement.Load(reader);
                IEnumerable<XElement> elements = root.Elements("Parameter");
                if (elements != null && elements.Count() > 0)
                {
                    var result = from one in elements
                                 select new FlightDataEntities.FlightParameter()
                                 {
                                     IsConcerned = true,
                                     Frequence = Convert.ToInt32(one.Attribute("Frequence").Value),
                                     Caption = one.Attribute("Caption").Value,
                                     ParameterID = modelName + "_" + one.Attribute("Index").Value + "_" + one.Attribute("SubIndex").Value,
                                     Index = Convert.ToInt32(one.Attribute("Index").Value),
                                     ModelName = modelName,
                                     SubIndex = Convert.ToInt32(one.Attribute("SubIndex").Value),
                                     Unit = one.Attribute("Unit").Value
                                 };

                    return result.ToArray();
                }
            }
            return new FlightDataEntities.FlightParameter[] { };
        }
    }
}
