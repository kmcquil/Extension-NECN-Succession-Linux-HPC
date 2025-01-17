﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Landis.Library.Metadata;

namespace Landis.Extension.Succession.NECN
{
    public class MonthlyLog
    {
        [DataFieldAttribute(Unit = FieldUnits.Year, Desc = "Simulation Year")]
        public int Time {set; get;}

        [DataFieldAttribute(Unit = FieldUnits.Month, Desc = "Simulation Month")]
        public int Month { set; get; }

        [DataFieldAttribute(Desc = "Climate Region Name")]
        public string ClimateRegionName { set; get; }

        [DataFieldAttribute(Desc = "Climate Region Index")]
        public int ClimateRegionIndex { set; get; }

        [DataFieldAttribute(Unit = FieldUnits.Count, Desc = "Number of Sites")]
        public int NumSites { set; get; }

        [DataFieldAttribute(Unit = FieldUnits.cm, Desc = "Precipitation", Format = "0.0")]
        public double Precipitation {get; set;}

        [DataFieldAttribute(Unit = FieldUnits.DegreeC, Desc = "Air Temperature", Format = "0.0")]
        public double AirTemp { get; set; }

        [DataFieldAttribute(Unit = "g_C_m2_month1", Desc = "Total NPP C", Format = "0.00")]
        public double AvgTotalNPP_C { get; set; }

        [DataFieldAttribute(Unit = "g_C_m2_month1", Desc = "Heterotrophic Respiration", Format = "0.00")]
        public double AvgHeteroRespiration { get; set; }

        [DataFieldAttribute(Unit = "g_C_m2_month1", Desc = "Soil Respiration", Format = "0.00")]
        public double AvgSoilRespiration { get; set; }

        [DataFieldAttribute(Unit = "g_C_m2_month1", Desc = "Net Ecosystem Exchange", Format = "0.00")]
        public double avgNEE { get; set; }

        [DataFieldAttribute(Unit = "g_N_m2_month1", Desc = "N Deposition and Fixation", Format = "0.00")]
        public double Ndep { get; set; }

        [DataFieldAttribute(Unit = "g_N_m2_month1", Desc = "N Leaching", Format = "0.00")]
        public double StreamN { get; set; }

        [DataFieldAttribute(Unit = FieldUnits.cm, Desc = "Soil Water Content", Format = "0.00")]
        public double SoilWaterContent { get; set; }

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "Total Transpiration", Format = "0.00")] //
        public double AvgTranspiration { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "Add To Soil", Format = "0.00")] //
        public double AvgAddToSoil { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "Soil Evaporation", Format = "0.00")] //
        public double AvgEvaporation { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "Prior month available water min", Format = "0.00")] //
        public double AvgPriorAvailableWaterMin { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "Available water min ", Format = "0.00")] //
        public double AvgAvailableWaterMin { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "Available water max", Format = "0.00")] //
        public double AvgAvailableWaterMax { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "evaporated snow", Format = "0.00")] //
        public double AvgEvaporatedSnow { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "stormflow", Format = "0.00")] //
        public double AvgStormflow { get; set; } //

        [DataFieldAttribute(Unit = "cm_m2_month1", Desc = "swc-waterEmpty", Format = "0.00")] //
        public double AvgMaxWaterUse { get; set; } //

        [DataFieldAttribute(Unit = "kpa", Desc = "vpd", Format = "0.00")] //
        public double AvgVPD { get; set; } //

        [DataFieldAttribute(Unit = "cm", Desc = "accumulted precipitation", Format = "0.00")] //
        public double AccumPrecip { get; set; } //

        [DataFieldAttribute(Unit = "cm", Desc = "avg swc", Format = "0.00")] //
        public double SWC_Mid { get; set; } //
    }
}
