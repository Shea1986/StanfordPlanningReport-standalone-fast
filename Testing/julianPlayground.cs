﻿using System;
using System.Linq;
using CommandLine;
using Application = VMS.TPS.Common.Model.API.Application;
using PlanSetup = VMS.TPS.Common.Model.API.PlanSetup;
using Patient = VMS.TPS.Common.Model.API.Patient;
using Course = VMS.TPS.Common.Model.API.Course;

namespace VMS.TPS
{
    class Program2
    {
        // Define a class to receive parsed values
        class Options
        {
            [Option('p', "pid", Required = true,
              HelpText = "Patient ID to be processed.")]
            public string PatientID { get; set; }

            [ParserState]
            public IParserState LastParserState { get; set; }
        }

        [STAThread]
        static void Main(string[] args)
        {
            var options = new Options();

            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                try
                {
                    using (Application app = Application.CreateApplication("SysAdmin", "SysAdmin2"))
                    {
                        ExecuteTestingEnv(app, options.PatientID);
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.ToString());
                }
            }
        }

        static void ExecuteTestingEnv(Application app, string PID)
        {
            // Set develpoment folder path. This is not the same path as the one used for system script. 
            Environment.SetEnvironmentVariable("ROOT_PATH", @"Z:\\Users\\Jbertini\\ESAPI\\StanfordPlanningReport-standalone-fast");

            Patient patient = app.OpenPatientById(PID);
            Course course = patient.Courses.Last();
            PlanSetup currentPlan = course.PlanSetups.Last();

            PhysicsCheck physics = new PhysicsCheck(currentPlan);

            // PDF CREATION
            MasterReport report = new MasterReport(patient, course, currentPlan)
            {
                TestResults = physics.Results
            };
            
            report.CreateReports();
            report.ShowReports();
        }

    }
}
