//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AriaQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class FieldModel
    {
        public long ID { get; set; }
        public Nullable<double> CollimatorX1 { get; set; }
        public Nullable<double> CollimatorX2 { get; set; }
        public Nullable<double> CollimatorY1 { get; set; }
        public Nullable<double> CollimatorY2 { get; set; }
        public Nullable<double> CouchLat { get; set; }
        public Nullable<double> CouchLng { get; set; }
        public Nullable<double> CouchVrt { get; set; }
        public string CourseId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> DoseRate { get; set; }
        public Nullable<int> Energy { get; set; }
        public string FieldTechnique { get; set; }
        public Nullable<int> SetupFieldFlag { get; set; }
        public Nullable<double> GantryRotation { get; set; }
        public Nullable<int> GatingFlag { get; set; }
        public Nullable<double> IsoCenterPositionX { get; set; }
        public Nullable<double> IsoCenterPositionY { get; set; }
        public Nullable<double> IsoCenterPositionZ { get; set; }
        public Nullable<System.DateTime> LastTreatmentDate { get; set; }
        public string MachineId { get; set; }
        public string MachineScale { get; set; }
        public string PatientId { get; set; }
        public Nullable<double> PatientSupportAngle { get; set; }
        public Nullable<double> PlannedMu { get; set; }
        public string PlanSetupId { get; set; }
        public string PrimaryDosimeterUnit { get; set; }
        public string RadiationId { get; set; }
        public string RadiationName { get; set; }
        public string RadiationType { get; set; }
        public string SetupNote { get; set; }
        public Nullable<double> SSD { get; set; }
        public Nullable<double> StopAngle { get; set; }
        public string ToleranceId { get; set; }
        public string ToleranceTable { get; set; }
        public string TreatmentApprovalState { get; set; }
        public string AddOnId { get; set; }
        public string AddOnType { get; set; }
        public Nullable<double> TotalNumberOfFractionsPlanned { get; set; }
        public Nullable<double> NoFractionsTreated { get; set; }
        public Nullable<double> FixLightAzimuthAngle { get; set; }
        public Nullable<double> FixLightPolarPos { get; set; }
        public string GantryRtnDirection { get; set; }
        public string GantryRtnExt { get; set; }
        public Nullable<double> WedgeDose { get; set; }
        public Nullable<double> RefDose { get; set; }
        public string MLCPlanType { get; set; }
        public string IndexParameterType { get; set; }
        public Nullable<double> MURounded { get; set; }
        public Nullable<long> StructureSetSer { get; set; }
        public string HstryUserName { get; set; }
        public Nullable<System.DateTime> HstryDateTime { get; set; }
        public string CollMode { get; set; }
        public Nullable<double> CollRtn { get; set; }
        public Nullable<double> TreatmentTime { get; set; }
        public string IMRTOrRapidArc { get; set; }
        public Nullable<long> AddOnSer { get; set; }
        public Nullable<long> RadiationSer { get; set; }
        public Nullable<long> TechinqueSer { get; set; }
        public Nullable<long> ToleranceSer { get; set; }
        public Nullable<long> RefImageSer { get; set; }
        public Nullable<long> PlanSetupSer { get; set; }
        public Nullable<long> PatientSer { get; set; }
        public Nullable<long> MachineSer { get; set; }
        public Nullable<long> EnergyModeSer { get; set; }
        public Nullable<long> CourseSer { get; set; }
        public Nullable<long> RTPlanSer { get; set; }
        public Nullable<long> TechniqueSer { get; set; }
    }
}
