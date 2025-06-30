using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class RecoilCase : ICases
    {
        public RecoilCase(ProbabilitiesDropOptions? options = null)
        {
            options ??= new ProbabilitiesDropOptions();
            _options = options;

            QuantityaArmy = SkinsArmy.Count;
            QuantityForbidden = SkinsForbidden.Count;
            QuantityClassified = SkinsClassified.Count;
            QuantitySecret = SkinsSecret.Count;
            QuantityRareItem = SkinsRareItem.Count;
        }
        private readonly ProbabilitiesDropOptions _options;

        public int QuantityaArmy;
        public int QuantityForbidden;
        public int QuantityClassified;
        public int QuantitySecret;
        public int QuantityRareItem;

        public ResultsItems GetDrop()
        {
            return PropertyItems.GetDrop(_options, new ListSkinsRequest<Skins>()
            {
                SkinsArmy = SkinsArmy,
                SkinsForbidden = SkinsForbidden,
                SkinsClassified = SkinsClassified,
                SkinsSecret = SkinsSecret,
                SkinsRareItem = SkinsRareItem,
                QuantityaArmy = QuantityaArmy,
                QuantityClassified = QuantityClassified,
                QuantityForbidden = QuantityForbidden,
                QuantitySecret = QuantitySecret,
                QuantityRareItem = QuantityRareItem
            });
        }

        public string GetNameSkinsAll(bool IsSkinArmy = false, bool isSkinForbidden = false,
            bool isSkinClassified = false, bool isSkinSecret = false, bool isSkinRareItem = false)
        {
            return PropertyItems.GetAllNamesSkin(new OnlyListSkinsRequest<Skins>
            {
                SkinsArmy = SkinsArmy,
                SkinsForbidden = SkinsForbidden,
                SkinsClassified = SkinsClassified,
                SkinsSecret = SkinsSecret,
                SkinsRareItem = SkinsRareItem
            },
            IsSkinArmy, isSkinForbidden, isSkinClassified, isSkinSecret, isSkinRareItem);
        }

        public string GetNameSkinsAll()
        {
            return GetNameSkinsAll(true, true, true, true, true);
        }

        public enum Skins
        {
            [Description("None")]
            None = 0,
            [Description("UMP-45 | Roadblock")]
            UMP45Roadblock = 1,
            [Description("Negev | Drop Me")]
            NegevDropMe = 2,
            [Description("MAC-10 | Monkeyflage")]
            MAC10Monkeyflage = 3,
            [Description("M4A4 | Poly Mag")]
            M4A4PolyMag = 4,
            [Description("Glock-18 | Winterized")]
            Glock18Winterized = 5,
            [Description("Galil AR | Destroyer")]
            GalilARDestroyer = 6,
            [Description("FAMAS | Meow 36")]
            FAMASMeow36 = 7,
            [Description("SG 553 | Dragon Tech")]
            SG553DragonTech = 8,
            [Description("R8 Revolver | Crazy 8")]
            R8RevolverCrazy8 = 9,
            [Description("P90 | Vent Rush")]
            P90VentRush = 10,
            [Description("M249 | Downtown")]
            M249Downtown = 11,
            [Description("Dual Berettas | Flora Carnivora")]
            DualBerettasFloraCarnivora = 12,
            [Description("Sawed-Off | Kiss♥Love")]
            SawedOffKissLove = 13,
            [Description("P250 | Visions")]
            P250Visions = 14,
            [Description("AK-47 | Ice Coaled")]
            AK47IceCoaled = 15,
            [Description("USP-S | Printstream")]
            USPSPrintstream = 16,
            [Description("AWP | Chromatic Aberration")]
            AWPChromaticAberration = 17,
            [Description("Specialist Gloves | Marble Fade")]
            SpecialistGlovesMarbleFade = 18,
            [Description("Sport Gloves | Slingshot")]
            SportGlovesSlingshot = 19,
            [Description("Sport Gloves | Nocts")]
            SportGlovesNocts = 20,
            [Description("Sport Gloves | Big Game")]
            SportGlovesBigGame = 21,
            [Description("Driver Gloves | Snow Leopard")]
            DriverGlovesSnowLeopard = 22,
            [Description("Hand Wraps | CAUTION!")]
            HandWrapsCAUTION = 23,
            [Description("Moto Gloves | Finish Line")]
            MotoGlovesFinishLine = 24,
            [Description("Specialist Gloves | Tiger Strike")]
            SpecialistGlovesTigerStrike = 25,
            [Description("Driver Gloves | Rezan the Red")]
            DriverGlovesRezanTheRed = 26,
            [Description("Broken Fang Gloves | Jade")]
            BrokenFangGlovesJade = 27,
            [Description("Sport Gloves | Scarlet Shamagh")]
            SportGlovesScarletShamagh = 28,
            [Description("Specialist Gloves | Field Agent")]
            SpecialistGlovesFieldAgent = 29,
            [Description("Driver Gloves | Black Tie")]
            DriverGlovesBlackTie = 30,
            [Description("Driver Gloves | Queen Jaguar")]
            DriverGlovesQueenJaguar = 31,
            [Description("Broken Fang Gloves | Yellow-banded")]
            BrokenFangGlovesYellowBanded = 32,
            [Description("Hand Wraps | Giraffe")]
            HandWrapsGiraffe = 33,
            [Description("Specialist Gloves | Lt. Commander")]
            SpecialistGlovesLtCommander = 34,
            [Description("Moto Gloves | Blood Pressure")]
            MotoGlovesBloodPressure = 35,
            [Description("Moto Gloves | Smoke Out")]
            MotoGlovesSmokeOut = 36,
            [Description("Hand Wraps | Constrictor")]
            HandWrapsConstrictor = 37,
            [Description("Broken Fang Gloves | Needle Point")]
            BrokenFangGlovesNeedlePoint = 38,
            [Description("Moto Gloves | 3rd Commando Company")]
            MotoGloves3rdCommandoCompany = 39,
            [Description("Broken Fang Gloves | Unhinged")]
            BrokenFangGlovesUnhinged = 40,
            [Description("Hand Wraps | Desert Shamagh")]
            HandWrapsDesertShamagh = 41
        }

        private List<Skins> SkinsArmy =
        [
            Skins.UMP45Roadblock,
            Skins.NegevDropMe,
            Skins.MAC10Monkeyflage,
            Skins.M4A4PolyMag,
            Skins.Glock18Winterized,
            Skins.GalilARDestroyer,
            Skins.FAMASMeow36
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SG553DragonTech,
            Skins.R8RevolverCrazy8,
            Skins.P90VentRush,
            Skins.M249Downtown,
            Skins.DualBerettasFloraCarnivora
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.SawedOffKissLove,
            Skins.P250Visions,
            Skins.AK47IceCoaled
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.USPSPrintstream,
            Skins.AWPChromaticAberration
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.SpecialistGlovesMarbleFade,
            Skins.SportGlovesSlingshot,
            Skins.SportGlovesNocts,
            Skins.SportGlovesBigGame,
            Skins.DriverGlovesSnowLeopard,
            Skins.HandWrapsCAUTION,
            Skins.MotoGlovesFinishLine,
            Skins.SpecialistGlovesTigerStrike,
            Skins.DriverGlovesRezanTheRed,
            Skins.BrokenFangGlovesJade,
            Skins.SportGlovesScarletShamagh,
            Skins.SpecialistGlovesFieldAgent,
            Skins.DriverGlovesBlackTie,
            Skins.DriverGlovesQueenJaguar,
            Skins.BrokenFangGlovesYellowBanded,
            Skins.HandWrapsGiraffe,
            Skins.SpecialistGlovesLtCommander,
            Skins.MotoGlovesBloodPressure,
            Skins.MotoGlovesSmokeOut,
            Skins.HandWrapsConstrictor,
            Skins.BrokenFangGlovesNeedlePoint,
            Skins.MotoGloves3rdCommandoCompany,
            Skins.BrokenFangGlovesUnhinged,
            Skins.HandWrapsDesertShamagh
        ];
    }
}
