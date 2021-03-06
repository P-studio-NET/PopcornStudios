﻿using FlightDataEntitiesRT.Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftDataAnalysisWinRT.Services
{
    /// <summary>
    /// 封装一些常用的数据导入到服务端的方法
    /// </summary>
    public class DataInputHelper
    {
        private static AircraftDataInput.AircraftDataInputClient GetClient()
        {
            if (!string.IsNullOrEmpty(ApplicationContext.Instance.DataInputServiceURL))
            {
                return new AircraftDataInput.AircraftDataInputClient(
                    AircraftDataInput.AircraftDataInputClient.EndpointConfiguration.BasicHttpBinding_IAircraftDataInput,
                    ApplicationContext.Instance.DataInputServiceURL);
            }
            return new AircraftDataInput.AircraftDataInputClient();
        }

        public static string AddOneParameterValue(FlightDataEntitiesRT.Flight flight, string parameterID,
            FlightDataEntitiesRT.Level1FlightRecord[] reducedRecords)
        {//TODO: test
            Task<string> task = AddOneParameterValueAsync(flight, parameterID, reducedRecords);
            task.Wait();
            return task.Result;
        }

        public static Task<string> AddOneParameterValueAsync(FlightDataEntitiesRT.Flight flight, string parameterID,
            FlightDataEntitiesRT.Level1FlightRecord[] reducedRecords)
        {//TODO: test
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);
            Task<string> task = client.AddOneParameterValueAsync(rtFlight, parameterID,
                RTConverter.ToDataInput(reducedRecords));
            return task;
        }

        public static Task<string> AddDecisionRecordsBatchAsync(FlightDataEntitiesRT.Flight flight,
            List<DecisionRecord> decisionRecords)
        {//TODO: test
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            Task<string> task = client.AddDecisionRecordsBatchAsync(rtFlight,
                RTConverter.ToDataInput(decisionRecords));
            return task;
        }

        public static string AddDecisionRecordsBatch(FlightDataEntitiesRT.Flight flight,
            List<DecisionRecord> decisionRecords)
        {//TODO: test
            Task<string> task = AddDecisionRecordsBatchAsync(flight, decisionRecords);
            task.Wait();
            return task.Result;
        }

        /// <summary>
        /// 删除架次并且删除相关信息
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public static Task<string> DeleteExistsDataAsync(FlightDataEntitiesRT.Flight flight)
        {//TODO: test
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);
            Task<string> task = client.DeleteExistsDataAsync(rtFlight);
            return task;
        }

        /// <summary>
        /// 删除架次并且删除相关信息
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public static string DeleteExistsData(FlightDataEntitiesRT.Flight flight)
        {//TODO: test
            Task<string> task = DeleteExistsDataAsync(flight);
            task.Wait();
            return task.Result;
        }

        /// <summary>
        /// 添加一个架次对象到数据库，必须先添加成功，否则后面数据没有架次作为参数是不行的
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public static Task<FlightDataEntitiesRT.Flight> AddOrReplaceFlightAsync(FlightDataEntitiesRT.Flight flight)
        {//TODO: test
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            Task<AircraftDataInput.Flight> task = client.AddOrReplaceFlightAsync(rtFlight);
            Task<FlightDataEntitiesRT.Flight> task2 = task.ContinueWith<FlightDataEntitiesRT.Flight>(
                new Func<Task, FlightDataEntitiesRT.Flight>(
                    delegate(Task task1)
                    {
                        task1.Wait();
                        var result = task.Result;
                        return RTConverter.FromDataInput(result);
                    }));

            return task2;
        }

        /// <summary>
        /// 添加一个架次对象到数据库，必须先添加成功，否则后面数据没有架次作为参数是不行的
        /// </summary>
        /// <param name="flight"></param>
        /// <returns></returns>
        public static FlightDataEntitiesRT.Flight AddOrReplaceFlight(FlightDataEntitiesRT.Flight flight)
        {//TODO: test
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            Task<AircraftDataInput.Flight> task = client.AddOrReplaceFlightAsync(rtFlight);
            task.Wait();
            return RTConverter.FromDataInput(task.Result);
        }

        internal static void AddLevelTopFlightRecords(FlightDataEntitiesRT.Flight flight,
            List<FlightDataEntitiesRT.LevelTopFlightRecord> topRecords)
        {
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            Task<string> task = client.AddLevelTopFlightRecordsAsync(
                RTConverter.ToDataInput(flight),
                new System.Collections.ObjectModel.ObservableCollection<AircraftDataInput.LevelTopFlightRecord>((
                    from one in topRecords select RTConverter.ToDataInput(one))));
            task.Wait();
            //return RTConverter.FromDataInput(task.Result);
        }

        internal static void AddFlightRawDataRelationPoints(FlightDataEntitiesRT.Flight flight,
            List<FlightDataEntitiesRT.FlightRawDataRelationPoint> flightRawDataRelationPoints)
        {
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            var points = from one in flightRawDataRelationPoints
                         select RTConverter.ToDataInput(one);
            var collection = new System.Collections.ObjectModel.ObservableCollection<
                AircraftDataInput.FlightRawDataRelationPoint>(points);

            Task<string> task = client.AddFlightRawDataRelationPointsAsync(rtFlight, collection);
            task.Wait();
        }

        internal static void AddOrReplaceFlightExtreme(FlightDataEntitiesRT.Flight flight,
            FlightDataEntitiesRT.ExtremumPointInfo[] extremumPointInfo)
        {
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            var points = from one in extremumPointInfo
                         select RTConverter.ToDataInput(one);
            var collection = new System.Collections.ObjectModel.ObservableCollection<
                AircraftDataInput.ExtremumPointInfo>(points);

            Task<string> task = client.AddOrReplaceFlightExtremeAsync(rtFlight, collection);
            task.Wait();
        }

        internal static void AddFlightConditionDecisionRecordsBatch(
            FlightDataEntitiesRT.Flight flight, List<DecisionRecord> decisionFlightRecords)
        {
            AircraftDataInput.AircraftDataInputClient client = GetClient();
            AircraftDataInput.Flight rtFlight = RTConverter.ToDataInput(flight);

            var collection = RTConverter.ToDataInput(decisionFlightRecords);

            Task<string> task = client.AddFlightConditionDecisionRecordsBatchAsync(rtFlight, collection);
            task.Wait();
        }
    }
}
