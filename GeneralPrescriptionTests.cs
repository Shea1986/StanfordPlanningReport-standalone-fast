﻿using System;
using System.Collections.Generic;
using System.Linq;

using PlanSetup = VMS.TPS.Common.Model.API.PlanSetup;

using AriaSysSmall;
using VMS.TPS.Common.Model.API;

namespace StanfordPlanningReport
{
    public class GeneralPrescriptionTests
    {
        private PlanSetup CurrentPlan;
        private string[] Doctors;
        private List<TestCase> fieldTestResults = new List<TestCase>();
        private List<TestCase> fieldTests = new List<TestCase>();

        // All field tests here
        private TestCase PrescriptionApprovalTestCase;
        private TestCase PrescriptionFractionationTestCase;
        private TestCase PrescriptionDosePerFractionTestCase;
        private TestCase PrescriptionDoseTestCase;
        private TestCase PrescribedDosePercentageTestCase;

        /* Constructor for FieldTest class to initialize the current plan object
         *
         * Updated: JB 6/13/18
         */
        public GeneralPrescriptionTests(PlanSetup cPlan, string[] doctors)
        {
            Doctors = doctors;
            CurrentPlan = cPlan;

            PrescriptionApprovalTestCase = new TestCase("Prescription Approval Check", "Test performed to check that prescription is approved by MD.", TestCase.PASS);
            this.fieldTests.Add(PrescriptionApprovalTestCase);

            PrescriptionFractionationTestCase = new TestCase("Prescription Fractionation Check", "Test performed to ensure planned fractionation matches linked prescription.", TestCase.PASS);
            this.fieldTests.Add(PrescriptionFractionationTestCase);

            PrescriptionDosePerFractionTestCase = new TestCase("Prescription Dose Per Fraction Check", "Test performed to ensure planned dose per fraction matches linked prescription.", TestCase.PASS);
            this.fieldTests.Add(PrescriptionDosePerFractionTestCase);

            PrescriptionDoseTestCase = new TestCase("Prescription Dose Check", "Test performed to ensure planned total dose matches linked prescription.", TestCase.PASS);
            this.fieldTests.Add(PrescriptionDoseTestCase);

            PrescribedDosePercentageTestCase = new TestCase("Prescribed Dose Percentage Check", "Test performed to ensure prescribed dose percentage is set to 100%.", TestCase.PASS);
            this.fieldTests.Add(PrescribedDosePercentageTestCase);
        }

        /* Getter method for List of field test results
         * 
         * Updated: JB 6/13/18
         */
        public List<TestCase> GetTestResults()
        {
            return fieldTestResults;
        }

        /* Iterates through each beam in the current plan and runs all field tests for each beam.
         * It modifies the fieldTestResults List to include the resulting test cases. 
         * It's organized such that failed tests will come before passed tests in the list (useful for later formatting).
         * 
         * Params: 
         *          None
         * Returns: 
         *          None
         *          
         * Updated: JB 6/13/18
         */
        public void ExecuteGeneralPrescriptionTests()
        {
            PrescribedDosePercentageCheck().AddToListOnFail(this.fieldTestResults, this.fieldTests);
            PrescriptionApprovalCheck().AddToListOnFail(this.fieldTestResults, this.fieldTests);
            PrescriptionFractionationCheck().AddToListOnFail(this.fieldTestResults, this.fieldTests);
            PrescriptionDosePerFractionCheck().AddToListOnFail(this.fieldTestResults, this.fieldTests);
            PrescriptionDoseCheck().AddToListOnFail(this.fieldTestResults, this.fieldTests);

            fieldTestResults.AddRange(this.fieldTests);
        }

        public TestCase PrescribedDosePercentageCheck()
        {
            try
            {
                if (CurrentPlan.PrescribedPercentage != 1.0) { PrescribedDosePercentageTestCase.SetResult(TestCase.FAIL); return PrescribedDosePercentageTestCase; }
                else {PrescribedDosePercentageTestCase.SetResult(TestCase.PASS); return PrescribedDosePercentageTestCase; }
            }
            catch { PrescribedDosePercentageTestCase.SetResult(TestCase.FAIL); return PrescribedDosePercentageTestCase; }
        }

        // Added by SL 03/10/2018  
        public TestCase PrescriptionApprovalCheck()
        {

            string rx_status = null;
            using (var aria = new AriaS())
            {
                try
                {
                    var patient = aria.Patients.Where(tmp => tmp.PatientId == CurrentPlan.Course.Patient.Id);
                    if (patient.Any())
                    {
                        var patientSer = patient.First().PatientSer;
                        var course = aria.Courses.Where(tmp => (tmp.PatientSer == patientSer && tmp.CourseId == CurrentPlan.Course.Id));
                        if (course.Any())
                        {
                            var courseSer = course.First().CourseSer;
                            // Note that we need to get the correct prescriptionser we need to have the plan id, not just course id (in case two more Rx in 1 course)
                            var prescription = aria.PlanSetups.Where(tmp => (tmp.CourseSer == courseSer && tmp.PlanSetupId == CurrentPlan.Id));
                            if (prescription.Any())
                            {
                                var prescriptionSer = prescription.First().PrescriptionSer;
                                var status = aria.Prescriptions.Where(tmp => (tmp.PrescriptionSer == prescriptionSer));
                                if (status.Any())
                                {
                                    rx_status = status.First().Status;
                                }
                            }
                        }
                    }

                    if (Doctors.Contains(CurrentPlan.RTPrescription.HistoryUserName) && rx_status.ToString().ToUpper().Contains("APPROVED"))
                    { PrescriptionApprovalTestCase.SetResult(TestCase.PASS); return PrescriptionApprovalTestCase; }
                    else { PrescriptionApprovalTestCase.SetResult(TestCase.FAIL); return PrescriptionApprovalTestCase; }
                }
                catch { PrescriptionApprovalTestCase.SetResult(TestCase.FAIL); return PrescriptionApprovalTestCase; }
            }
        }

        public TestCase PrescriptionFractionationCheck()
        {

            try
            {
                foreach (RTPrescriptionTarget t in CurrentPlan.RTPrescription.Targets)
                {
                    if (t.NumberOfFractions == CurrentPlan.UniqueFractionation.NumberOfFractions) { PrescriptionFractionationTestCase.SetResult(TestCase.PASS); return PrescriptionFractionationTestCase; }
                }
                PrescriptionFractionationTestCase.SetResult(TestCase.FAIL); return PrescriptionFractionationTestCase;
            }
            catch { PrescriptionFractionationTestCase.SetResult(TestCase.FAIL); return PrescriptionFractionationTestCase; }
        }

        public TestCase PrescriptionDosePerFractionCheck()
        {

            try
            {
                foreach (RTPrescriptionTarget t in CurrentPlan.RTPrescription.Targets)
                {
                    if ((t.DosePerFraction.Dose - CurrentPlan.UniqueFractionation.PrescribedDosePerFraction.Dose) <= CurrentPlan.UniqueFractionation.PrescribedDosePerFraction.Dose * 0.01) { PrescriptionDosePerFractionTestCase.SetResult(TestCase.PASS); return PrescriptionDosePerFractionTestCase; }
                }
                PrescriptionDosePerFractionTestCase.SetResult(TestCase.FAIL); return PrescriptionDosePerFractionTestCase;
            }
            catch { PrescriptionDosePerFractionTestCase.SetResult(TestCase.FAIL); return PrescriptionDosePerFractionTestCase; }
        }

        public TestCase PrescriptionDoseCheck()
        {

            try
            {
                foreach (RTPrescriptionTarget t in CurrentPlan.RTPrescription.Targets)
                {
                    if (Math.Abs(t.DosePerFraction.Dose * t.NumberOfFractions - CurrentPlan.UniqueFractionation.PrescribedDosePerFraction.Dose * 
                                                                                                                        CurrentPlan.UniqueFractionation.NumberOfFractions.Value) <= 0.1)
                                                                                                                            { PrescriptionDoseTestCase.SetResult(TestCase.PASS); return PrescriptionDoseTestCase; }
                }
                PrescriptionDoseTestCase.SetResult(TestCase.FAIL); return PrescriptionDoseTestCase;
            }
            catch { PrescriptionDoseTestCase.SetResult(TestCase.FAIL); return PrescriptionDoseTestCase; }
        }

    }
}

