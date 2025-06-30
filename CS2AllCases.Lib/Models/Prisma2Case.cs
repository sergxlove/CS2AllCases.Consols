using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class Prisma2Case : ICases
    {
        public Prisma2Case(ProbabilitiesDropOptions? options = null)
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
            [Description("R8 Revolver | Bone Forged")]
            R8RevolverBoneForged = 1,
            [Description("Negev | Prototype")]
            NegevPrototype = 2,
            [Description("MP5-SD | Desert Strike")]
            MP5SDDesertStrike = 3,
            [Description("Desert Eagle | Blue Ply")]
            DesertEagleBluePly = 4,
            [Description("CZ75-Auto | Distressed")]
            CZ75AutoDistressed = 5,
            [Description("AWP | Capillary")]
            AWPCapillary = 6,
            [Description("AUG | Tom Cat")]
            AUGTomCat = 7,
            [Description("SSG 08 | Fever Dream")]
            SSG08FeverDream = 8,
            [Description("SG 553 | Darkwing")]
            SG553Darkwing = 9,
            [Description("SCAR-20 | Enforcer")]
            SCAR20Enforcer = 10,
            [Description("Sawed-Off | Apocalypto")]
            SawedOffApocalypto = 11,
            [Description("P2000 | Acid Etched")]
            P2000AcidEtched = 12,
            [Description("MAG-7 | Justice")]
            MAG7Justice = 13,
            [Description("MAC-10 | Disco Tech")]
            MAC10DiscoTech = 14,
            [Description("AK-47 | Phantom Disruptor")]
            AK47PhantomDisruptor = 15,
            [Description("M4A1-S | Player Two")]
            M4A1SPlayerTwo = 16,
            [Description("Glock-18 | Bullet Queen")]
            Glock18BulletQueen = 17,
            [Description("Talon Knife | Doppler Ruby")]
            TalonKnifeDopplerRuby = 18,
            [Description("Talon Knife | Doppler Sapphire")]
            TalonKnifeDopplerSapphire = 19,
            [Description("Talon Knife | Doppler Black Pearl")]
            TalonKnifeDopplerBlackPearl = 20,
            [Description("Talon Knife | Doppler Phase 2")]
            TalonKnifeDopplerPhase2 = 21,
            [Description("Talon Knife | Doppler Phase 4")]
            TalonKnifeDopplerPhase4 = 22,
            [Description("Talon Knife | Doppler Phase 3")]
            TalonKnifeDopplerPhase3 = 23,
            [Description("Talon Knife | Doppler Phase 1")]
            TalonKnifeDopplerPhase1 = 24,
            [Description("Talon Knife | Marble Fade")]
            TalonKnifeMarbleFade = 25,
            [Description("Talon Knife | Ultraviolet")]
            TalonKnifeUltraviolet = 26,
            [Description("Talon Knife | Tiger Tooth")]
            TalonKnifeTigerTooth = 27,
            [Description("Talon Knife | Damascus Steel")]
            TalonKnifeDamascusSteel = 28,
            [Description("Talon Knife | Rust Coat")]
            TalonKnifeRustCoat = 29,
            [Description("Stiletto Knife | Doppler Ruby")]
            StilettoKnifeDopplerRuby = 30,
            [Description("Stiletto Knife | Doppler Sapphire")]
            StilettoKnifeDopplerSapphire = 31,
            [Description("Stiletto Knife | Doppler Black Pearl")]
            StilettoKnifeDopplerBlackPearl = 32,
            [Description("Stiletto Knife | Doppler Phase 2")]
            StilettoKnifeDopplerPhase2 = 33,
            [Description("Stiletto Knife | Doppler Phase 1")]
            StilettoKnifeDopplerPhase1 = 34,
            [Description("Stiletto Knife | Doppler Phase 4")]
            StilettoKnifeDopplerPhase4 = 35,
            [Description("Stiletto Knife | Doppler Phase 3")]
            StilettoKnifeDopplerPhase3 = 36,
            [Description("Stiletto Knife | Marble Fade")]
            StilettoKnifeMarbleFade = 37,
            [Description("Stiletto Knife | Ultraviolet")]
            StilettoKnifeUltraviolet = 38,
            [Description("Stiletto Knife | Tiger Tooth")]
            StilettoKnifeTigerTooth = 39,
            [Description("Stiletto Knife | Damascus Steel")]
            StilettoKnifeDamascusSteel = 40,
            [Description("Stiletto Knife | Rust Coat")]
            StilettoKnifeRustCoat = 41,
            [Description("Ursus Knife | Doppler Ruby")]
            UrsusKnifeDopplerRuby = 42,
            [Description("Ursus Knife | Doppler Black Pearl")]
            UrsusKnifeDopplerBlackPearl = 43,
            [Description("Ursus Knife | Doppler Sapphire")]
            UrsusKnifeDopplerSapphire = 44,
            [Description("Ursus Knife | Doppler Phase 2")]
            UrsusKnifeDopplerPhase2 = 45,
            [Description("Ursus Knife | Doppler Phase 4")]
            UrsusKnifeDopplerPhase4 = 46,
            [Description("Ursus Knife | Doppler Phase 1")]
            UrsusKnifeDopplerPhase1 = 47,
            [Description("Ursus Knife | Doppler Phase 3")]
            UrsusKnifeDopplerPhase3 = 48,
            [Description("Ursus Knife | Ultraviolet")]
            UrsusKnifeUltraviolet = 49,
            [Description("Ursus Knife | Marble Fade")]
            UrsusKnifeMarbleFade = 50,
            [Description("Ursus Knife | Tiger Tooth")]
            UrsusKnifeTigerTooth = 51,
            [Description("Ursus Knife | Damascus Steel")]
            UrsusKnifeDamascusSteel = 52,
            [Description("Ursus Knife | Rust Coat")]
            UrsusKnifeRustCoat = 53,
            [Description("Navaja Knife | Doppler Black Pearl")]
            NavajaKnifeDopplerBlackPearl = 54,
            [Description("Navaja Knife | Doppler Ruby")]
            NavajaKnifeDopplerRuby = 55,
            [Description("Navaja Knife | Doppler Sapphire")]
            NavajaKnifeDopplerSapphire = 56,
            [Description("Navaja Knife | Doppler Phase 2")]
            NavajaKnifeDopplerPhase2 = 57,
            [Description("Navaja Knife | Doppler Phase 4")]
            NavajaKnifeDopplerPhase4 = 58,
            [Description("Navaja Knife | Doppler Phase 1")]
            NavajaKnifeDopplerPhase1 = 59,
            [Description("Navaja Knife | Doppler Phase 3")]
            NavajaKnifeDopplerPhase3 = 60,
            [Description("Navaja Knife | Marble Fade")]
            NavajaKnifeMarbleFade = 61,
            [Description("Navaja Knife | Tiger Tooth")]
            NavajaKnifeTigerTooth = 62,
            [Description("Navaja Knife | Ultraviolet")]
            NavajaKnifeUltraviolet = 63,
            [Description("Navaja Knife | Damascus Steel")]
            NavajaKnifeDamascusSteel = 64,
            [Description("Navaja Knife | Rust Coat")]
            NavajaKnifeRustCoat = 65
        }

        private List<Skins> SkinsArmy =
        [
            Skins.R8RevolverBoneForged,
            Skins.NegevPrototype,
            Skins.MP5SDDesertStrike,
            Skins.DesertEagleBluePly,
            Skins.CZ75AutoDistressed,
            Skins.AWPCapillary,
            Skins.AUGTomCat
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SSG08FeverDream,
            Skins.SG553Darkwing,
            Skins.SCAR20Enforcer,
            Skins.SawedOffApocalypto,
            Skins.P2000AcidEtched
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.MAG7Justice, 
            Skins.MAC10DiscoTech,
            Skins.AK47PhantomDisruptor
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.M4A1SPlayerTwo,
            Skins.Glock18BulletQueen
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.TalonKnifeDopplerRuby,
            Skins.TalonKnifeDopplerSapphire,
            Skins.TalonKnifeDopplerBlackPearl,
            Skins.TalonKnifeDopplerPhase2,
            Skins.TalonKnifeDopplerPhase4,
            Skins.TalonKnifeDopplerPhase3,
            Skins.TalonKnifeDopplerPhase1,
            Skins.TalonKnifeMarbleFade,
            Skins.TalonKnifeUltraviolet,
            Skins.TalonKnifeTigerTooth,
            Skins.TalonKnifeDamascusSteel,
            Skins.TalonKnifeRustCoat,
            Skins.StilettoKnifeDopplerRuby,
            Skins.StilettoKnifeDopplerSapphire,
            Skins.StilettoKnifeDopplerBlackPearl,
            Skins.StilettoKnifeDopplerPhase2,
            Skins.StilettoKnifeDopplerPhase1,
            Skins.StilettoKnifeDopplerPhase4,
            Skins.StilettoKnifeDopplerPhase3,
            Skins.StilettoKnifeMarbleFade,
            Skins.StilettoKnifeUltraviolet,
            Skins.StilettoKnifeTigerTooth,
            Skins.StilettoKnifeDamascusSteel,
            Skins.StilettoKnifeRustCoat,
            Skins.UrsusKnifeDopplerRuby,
            Skins.UrsusKnifeDopplerBlackPearl,
            Skins.UrsusKnifeDopplerSapphire,
            Skins.UrsusKnifeDopplerPhase2,
            Skins.UrsusKnifeDopplerPhase4,
            Skins.UrsusKnifeDopplerPhase1,
            Skins.UrsusKnifeDopplerPhase3,
            Skins.UrsusKnifeUltraviolet,
            Skins.UrsusKnifeMarbleFade,
            Skins.UrsusKnifeTigerTooth,
            Skins.UrsusKnifeDamascusSteel,
            Skins.UrsusKnifeRustCoat,
            Skins.NavajaKnifeDopplerBlackPearl,
            Skins.NavajaKnifeDopplerRuby,
            Skins.NavajaKnifeDopplerSapphire,
            Skins.NavajaKnifeDopplerPhase2,
            Skins.NavajaKnifeDopplerPhase4,
            Skins.NavajaKnifeDopplerPhase1,
            Skins.NavajaKnifeDopplerPhase3,
            Skins.NavajaKnifeMarbleFade,
            Skins.NavajaKnifeTigerTooth,
            Skins.NavajaKnifeUltraviolet,
            Skins.NavajaKnifeDamascusSteel,
            Skins.NavajaKnifeRustCoat
        ];
    }
}
