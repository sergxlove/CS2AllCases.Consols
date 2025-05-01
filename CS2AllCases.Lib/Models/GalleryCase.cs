using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace CS2AllCases.Lib.Models
{
    public class GalleryCase : ICases
    {
        public GalleryCase(ProbabilitiesDropOptions? options = null)
        {
            _options ??= new ProbabilitiesDropOptions();

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
            return PropertyItems.PropertyItems.GetDrop(_options, new ListSkinsRequest<Skins>()
            {
                SkinsArmy = SkinsArmy,
                SkinsForbidden = SkinsForbidden,
                SkinsClassified = SkinsClassified,
                SkinsSecret = SkinsSecret,
                SkinsRareItem = SkinsRareItem,
                QuantityaArmy = QuantityaArmy,
                QuantityForbidden = QuantityForbidden,
                QuantityClassified = QuantityClassified,
                QuantitySecret = QuantitySecret,
                QuantityRareItem = QuantityRareItem
            });
        }

        public enum Skins
        {
            [Description("None")]
            None = 0,
            [Description("SCAR-20 Trail Blazer")]
            SCAR20TrailBlazer = 1,
            [Description("MP5-SD Statics")]
            MP5SDStatics = 2,
            [Description("M249 Hypnosis")]
            M249Hypnosis = 3,
            [Description("AUG Luxe Trim")]
            AUGLuxeTrim = 4,
            [Description("R8 Revolver Tango")]
            R8RevolverTango = 5,
            [Description("Desert Eagle Calligraffiti")]
            DesertEagleCalligraffiti = 6,
            [Description("P90 Randy Rush")]
            P90RandyRush = 7,
            [Description("Dual Berettas Hydro Strike")]
            DualBerettasHydroStrike = 8,
            [Description("MAC-10 Saiba Oni")]
            MAC10SaibaOni = 9,
            [Description("SSG 08 Rapid Transit")]
            SSG08RapidTransit = 10,
            [Description("M4A4 Turbine")]
            M4A4Turbine = 11,
            [Description("UMP-45 Neo-Noir")]
            UMP45NeoNoir = 12,
            [Description("P250 Epicenter")]
            P250Epicenter = 13,
            [Description("AK-47 The Outsiders")]
            AK47TheOutsiders = 14,
            [Description("Glock-18 Gold Toof")]
            Glock18GoldToof = 15,
            [Description("M4A1-S Vaporwave")]
            M4A1SVaporwave = 16,
            [Description("Kukri Knife Crimson Web")]
            KukriKnifeCrimsonWeb = 17,
            [Description("Kukri Knife Fade")]
            KukriKnifeFade = 18,
            [Description("Kukri Knife Slaughter")]
            KukriKnifeSlaughter = 19,
            [Description("Kukri Knife Vanilla")]
            KukriKnifeVanilla = 20,
            [Description("Kukri Knife Case Hardened")]
            KukriKnifeCaseHardened = 21,
            [Description("Kukri Knife Stained")]
            KukriKnifeStained = 22,
            [Description("Kukri Knife Blue Steel")]
            KukriKnifeBlueSteel = 23,
            [Description("Kukri Knife Night Stripe")]
            KukriKnifeNightStripe = 24,
            [Description("Kukri Knife Urban Masked")]
            KukriKnifeUrbanMasked = 25,
            [Description("Kukri Knife Scorched")]
            KukriKnifeScorched = 26,
            [Description("Kukri Knife Forest DDPAT")]
            KukriKnifeForestDDPAT = 27,
            [Description("Kukri Knife Boreal Forest")]
            KukriKnifeBorealForest = 28,
            [Description("Kukri Knife Safari Mesh")]
            KukriKnifeSafariMesh = 29
        }

        public static string GetSkinString(Skins value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString())!;
            DescriptionAttribute attribute = field?.GetCustomAttribute<DescriptionAttribute>()!;
            return attribute?.Description ?? value.ToString();
        }

        public string GetNameSkinsAll(bool IsSkinArmy = false, bool isSkinForbidden = false,
            bool isSkinClassified = false, bool isSkinSecret = false, bool isSkinRareItem = false)
        {
            return PropertyItems.PropertyItems.GetAllNamesSkin(new OnlyListSkinsRequest<Skins>
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

        private List<Skins> SkinsArmy = 
        [
            Skins.SCAR20TrailBlazer,
            Skins.M249Hypnosis,
            Skins.AUGLuxeTrim, 
            Skins.MP5SDStatics,
            Skins.R8RevolverTango,
            Skins.DesertEagleCalligraffiti
        ];

        private List<Skins> SkinsForbidden = 
        [
            Skins.P90RandyRush,
            Skins.MAC10SaibaOni,
            Skins.DualBerettasHydroStrike,
            Skins.SSG08RapidTransit,
            Skins.M4A4Turbine
        ];

        private List<Skins> SkinsClassified = 
        [
            Skins.UMP45NeoNoir,
            Skins.P250Epicenter,
            Skins.AK47TheOutsiders
        ];
        private List<Skins> SkinsSecret = 
        [
            Skins.Glock18GoldToof,
            Skins.M4A1SVaporwave
        ];

        private List<Skins> SkinsRareItem = 
        [
            Skins.KukriKnifeCrimsonWeb,
            Skins.KukriKnifeFade,
            Skins.KukriKnifeSlaughter,
            Skins.KukriKnifeVanilla,
            Skins.KukriKnifeCaseHardened,
            Skins.KukriKnifeStained,
            Skins.KukriKnifeBlueSteel,
            Skins.KukriKnifeNightStripe,
            Skins.KukriKnifeUrbanMasked,
            Skins.KukriKnifeScorched,
            Skins.KukriKnifeForestDDPAT,
            Skins.KukriKnifeBorealForest,
            Skins.KukriKnifeSafariMesh
        ];
    }
}
