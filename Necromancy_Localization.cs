
using ModShardLauncher;
using ModShardLauncher.Mods;

namespace Necromancy;

public class Necromancy_Localization
{
    public static void SpeechPatching() 
    {
        Msl.InjectTableSpeechesLocalization(
            new LocalizationSpeech(
                id: "Bw_Bolt",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "In Nag Zur..."},
                    {ModLanguage.Chinese, "因纳戈祖尔……"},
                    {ModLanguage.Japanese, "イン・ナグ・ズール…"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Bw_Bolt",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "in Nag zu ...?"},
                }
            ),
            new LocalizationSpeech(
                id: "Wraith_Binding",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.Russian, "Korrug Namar!"},
                    {ModLanguage.English, "Lagura mithensa!"},
                    {ModLanguage.Chinese, "廓卢戈'纳玛尔！"},
                    {ModLanguage.German, "Korrug Namar!"},
                    {ModLanguage.Spanish, "¡Korrug Namar!"},
                    {ModLanguage.French, "Korrug Namar!"},
                    {ModLanguage.Italian, "Korrug Namar!"},
                    {ModLanguage.Portuguese, "Korrug Namar!"},
                    {ModLanguage.Polish, "Korrug Namar!"},
                    {ModLanguage.Turkish, "Korrug Namar!"},
                    {ModLanguage.Japanese, "コールグ・ナマール！"},
                    {ModLanguage.Korean, "Korrug Namar!"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Wraith_Binding",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.Russian, "Korrug Namar!"},
                    {ModLanguage.English, "Lagua ra metha ...?!"},
                    {ModLanguage.Chinese, "廓卢戈'纳玛尔！"},
                    {ModLanguage.German, "Korrug Namar!"},
                    {ModLanguage.Spanish, "¡Korrug Namar!"},
                    {ModLanguage.French, "Korrug Namar!"},
                    {ModLanguage.Italian, "Korrug Namar!"},
                    {ModLanguage.Portuguese, "Korrug Namar!"},
                    {ModLanguage.Polish, "Korrug Namar!"},
                    {ModLanguage.Turkish, "Korrug Namar!"},
                    {ModLanguage.Japanese, "コールグ・ナマール！"},
                    {ModLanguage.Korean, "Korrug Namar!"},
                }
            ),
            new LocalizationSpeech(
                id: "Bw_Resurrection",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Lagur! Lagur! Lagur!"},
                    {ModLanguage.Chinese, "拉古尔！拉古尔！拉古尔！"},
                    {ModLanguage.Spanish, "¡Lagur! ¡Lagur! ¡Lagur!"},
                    {ModLanguage.Japanese, "ラグール！ ラグール！ ラグール！"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Bw_Resurrection",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Lagu Lagu La ... ?!"},
                }
            ),
            new LocalizationSpeech(
                id: "Pcurse",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Shaggrath Azud..."},
                    {ModLanguage.Chinese, "沙格拉斯'阿祖得！"},
                    {ModLanguage.Japanese, "シャグラト・アズード！"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Pcurse",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Shagerath erm ...?"},
                }
            ),
            new LocalizationSpeech(
                id: "Death_Plague",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "En'thero !"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Death_Plague",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "En'tera"},
                }
            ),
            new LocalizationSpeech(
                id: "Lostsouls",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Lagura Lamera !"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Lostsouls",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Lagurera Mara ... ?!"},
                }
            ),
            new LocalizationSpeech(
                id: "Bw_Touch",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.Russian, "Korrug Namar!"},
                    {ModLanguage.English, "Korrug Namar!"},
                    {ModLanguage.Chinese, "廓卢戈'纳玛尔！"},
                    {ModLanguage.German, "Korrug Namar!"},
                    {ModLanguage.Spanish, "¡Korrug Namar!"},
                    {ModLanguage.French, "Korrug Namar!"},
                    {ModLanguage.Italian, "Korrug Namar!"},
                    {ModLanguage.Portuguese, "Korrug Namar!"},
                    {ModLanguage.Polish, "Korrug Namar!"},
                    {ModLanguage.Turkish, "Korrug Namar!"},
                    {ModLanguage.Japanese, "コールグ・ナマール！"},
                    {ModLanguage.Korean, "Korrug Namar!"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Bw_Touch",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.Russian, "Korrug Namar!"},
                    {ModLanguage.English, "Kogrug Nema ...?!"},
                    {ModLanguage.Chinese, "廓卢戈'纳玛尔！"},
                    {ModLanguage.German, "Korrug Namar!"},
                    {ModLanguage.Spanish, "¡Korrug Namar!"},
                    {ModLanguage.French, "Korrug Namar!"},
                    {ModLanguage.Italian, "Korrug Namar!"},
                    {ModLanguage.Portuguese, "Korrug Namar!"},
                    {ModLanguage.Polish, "Korrug Namar!"},
                    {ModLanguage.Turkish, "Korrug Namar!"},
                    {ModLanguage.Japanese, "コールグ・ナマール！"},
                    {ModLanguage.Korean, "Korrug Namar!"},
                }
            ),
            new LocalizationSpeech(
                id: "Bw_Bless",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Yagrak Atot!"},
                    {ModLanguage.Chinese, "亚格拉克'阿托特！"},
                    {ModLanguage.Japanese, "ヤグラク・アトット！"},
                }
            ),
            new LocalizationSpeech(
                id: "MC_Bw_Bless",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Yack Ato... ?!"},
                }
            )
        );
    }
}