using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// </summary>
    [DataContract]
    public partial class Drug : Substance
    {

        public interface IPrescriptionStatus : IWrapper { }
        public interface IPrescriptionStatus<T> : IPrescriptionStatus { new T Data { get; set; } }
        public class PrescriptionStatusDrugPrescriptionStatus : IPrescriptionStatus<DrugPrescriptionStatus>
        {
            object IWrapper.Data { get { return Data; } set { Data = (DrugPrescriptionStatus) value; } }
            public virtual DrugPrescriptionStatus Data { get; set; }
            public PrescriptionStatusDrugPrescriptionStatus () { }
            public PrescriptionStatusDrugPrescriptionStatus (DrugPrescriptionStatus data) { Data = data; }
            public static implicit operator PrescriptionStatusDrugPrescriptionStatus (DrugPrescriptionStatus data) { return new PrescriptionStatusDrugPrescriptionStatus (data); }
        }

        public class PrescriptionStatusstring : IPrescriptionStatus<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public PrescriptionStatusstring () { }
            public PrescriptionStatusstring (string data) { Data = data; }
            public static implicit operator PrescriptionStatusstring (string data) { return new PrescriptionStatusstring (data); }
        }


        public interface IWarning : IWrapper { }
        public interface IWarning<T> : IWarning { new T Data { get; set; } }
        public class Warningstring : IWarning<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Warningstring () { }
            public Warningstring (string data) { Data = data; }
            public static implicit operator Warningstring (string data) { return new Warningstring (data); }
        }

        public class WarningUri : IWarning<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public WarningUri () { }
            public WarningUri (Uri data) { Data = data; }
            public static implicit operator WarningUri (Uri data) { return new WarningUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Drug";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? ActiveIngredient { get; set; } 

        /// <summary>
        /// A route by which this drug may be administered, e.g. 'oral'.
        /// </summary>
        [DataMember(Name = "administrationRoute", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AdministrationRoute { get; set; } 

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        /// </summary>
        [DataMember(Name = "alcoholWarning", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AlcoholWarning { get; set; } 

        /// <summary>
        /// An available dosage strength for the drug.
        /// </summary>
        [DataMember(Name = "availableStrength", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DrugStrength>? AvailableStrength { get; set; } 

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        /// </summary>
        [DataMember(Name = "breastfeedingWarning", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BreastfeedingWarning { get; set; } 

        /// <summary>
        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
        /// </summary>
        [DataMember(Name = "clinicalPharmacology", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ClinicalPharmacology { get; set; } 

        /// <summary>
        /// Cost per unit of the drug, as reported by the source being tagged.
        /// </summary>
        [DataMember(Name = "cost", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DrugCost>? Cost { get; set; } 

        /// <summary>
        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        /// </summary>
        [DataMember(Name = "dosageForm", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DosageForm { get; set; } 

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        [DataMember(Name = "doseSchedule", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DoseSchedule>? DoseSchedule { get; set; } 

        /// <summary>
        /// The class of drug this belongs to (e.g., statins).
        /// </summary>
        [DataMember(Name = "drugClass", Order = 315)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DrugClass>? DrugClass { get; set; } 

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        [DataMember(Name = "drugUnit", Order = 316)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? DrugUnit { get; set; } 

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        /// </summary>
        [DataMember(Name = "foodWarning", Order = 317)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FoodWarning { get; set; } 

        /// <summary>
        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        /// </summary>
        [DataMember(Name = "interactingDrug", Order = 318)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Drug>? InteractingDrug { get; set; } 

        /// <summary>
        /// True if the drug is available in a generic form (regardless of name).
        /// </summary>
        [DataMember(Name = "isAvailableGenerically", Order = 319)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsAvailableGenerically { get; set; } 

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [DataMember(Name = "isProprietary", Order = 320)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsProprietary { get; set; } 

        /// <summary>
        /// Link to the drug's label details.
        /// </summary>
        [DataMember(Name = "labelDetails", Order = 321)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? LabelDetails { get; set; } 

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 322)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ILegalStatus>? LegalStatus { get; set; } //DrugLegalStatus, MedicalEnumeration?, string

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 323)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<MaximumDoseSchedule>? MaximumIntake { get; set; } 

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        [DataMember(Name = "mechanismOfAction", Order = 324)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MechanismOfAction { get; set; } 

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        [DataMember(Name = "nonProprietaryName", Order = 325)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? NonProprietaryName { get; set; } 

        /// <summary>
        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        /// </summary>
        [DataMember(Name = "overdosage", Order = 326)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Overdosage { get; set; } 

        /// <summary>
        /// Pregnancy category of this drug.
        /// </summary>
        [DataMember(Name = "pregnancyCategory", Order = 327)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DrugPregnancyCategory>? PregnancyCategory { get; set; } 

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        /// </summary>
        [DataMember(Name = "pregnancyWarning", Order = 328)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PregnancyWarning { get; set; } 

        /// <summary>
        /// Link to prescribing information for the drug.
        /// </summary>
        [DataMember(Name = "prescribingInfo", Order = 329)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? PrescribingInfo { get; set; } 

        /// <summary>
        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        /// </summary>
        [DataMember(Name = "prescriptionStatus", Order = 330)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPrescriptionStatus>? PrescriptionStatus { get; set; } //DrugPrescriptionStatus?, string

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [DataMember(Name = "proprietaryName", Order = 331)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProprietaryName { get; set; } 

        /// <summary>
        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        /// </summary>
        [DataMember(Name = "relatedDrug", Order = 332)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Drug>? RelatedDrug { get; set; } 

        /// <summary>
        /// The RxCUI drug identifier from RXNORM.
        /// </summary>
        [DataMember(Name = "rxcui", Order = 333)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Rxcui { get; set; } 

        /// <summary>
        /// Any FDA or other warnings about the drug (text or URL).
        /// </summary>
        [DataMember(Name = "warning", Order = 334)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IWarning>? Warning { get; set; } //string, Uri
    }
}
