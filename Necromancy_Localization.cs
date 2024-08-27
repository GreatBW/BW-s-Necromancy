
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
    public static void ModifierPatching()
    {
        Msl.InjectTableModifiersLocalization(
            new LocalizationModifier(
                id: "o_db_takeover",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Obsession"},
                    {ModLanguage.Russian, "Одержимость"},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"The penalties change dynamically depending on the missing percentage of ~lg~Sanity~/~.##May Cause ~r~Confusion~/~ or ~r~Daze~/~.##Deals ~ur~1-3 Unholy Damage~/~ if sanity drops below ~r~33%~/~.##~r~Near death~/~: the character's Max Health is reduced every few turns."},
                    {ModLanguage.Russian, @"Штрафы меняются каждый ход в зависимости от недостающего ~lg~рассудка~/~.##Может вызвать ~r~Замешательство~/~ или ~r~Ошеломление~/~.##~r~Смерть близка~/~: каждые несколько ходов максимальное здоровье снижается."},
                }
            ),
            new LocalizationModifier(
                id: "o_b_angel_charm",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Ascension"},
                    {ModLanguage.Russian, "Вознесение"},
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_b_unbind",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Unbind"},
                    {ModLanguage.Russian, "Отвязать"},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Clicking on this icon instantly kills this undead and then advances a turn."},
                    {ModLanguage.Russian, @"Нажатие на иконку эффекта или клавиши ~r~N~/~ в этом окне моментально убивает эту нежить. Тратит ход."},
                }
            ),
            new LocalizationModifier(
                id: "o_b_darkenchant",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Dark Enchantment"},
                    {ModLanguage.Russian, "Тёмный договор"},
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_db_punishment",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Punishment"},
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_b_exceptional",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Disorder"},
                    {ModLanguage.Russian, "Исключительная душа"},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Negates penalties of ~r~Obsession~/~.##Prevents from receiving ~r~Obsession~/~.##When effect expires: ~r~unbinds~/~ all allied wraiths."},
                    {ModLanguage.Russian, @"Аннулирует штрафы от эффекта ~r~\""Одержимости\""~/~ и препятствует его получению.##Когда эффект заканчивает: ~r~возвращает в загробный мир~/~ всех союзных умертвий."},
                }
            ),
            new LocalizationModifier(
                id: "o_bw_sacrifice",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Soul Sacrifice"},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy.;Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy."},
                 }
            ),
            new LocalizationModifier(
                id: "o_b_servemaster",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Revivify"},
                    {ModLanguage.Russian, "Оживление"},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Considered as an ~r~Undead~/~: bringing it inside settlements is ~r~Crime~/~.##Capable of ~lg~Following~/~ you everywhere on the map.##~y~Left clicking~/~ this icon switches ~r~Aggressive~/~ and ~lg~Follow~/~ mode.#~y~Right clicking~/~ this icon switches ~lg~Idle~/~ and ~p~Autonomous~/~ mode.##Pressing ~y~V~/~ allows for selectable positioning."},
                    {ModLanguage.Russian, @"Считается ~r~нежитью~/~: привод в город является ~r~преступлением~/~.##Способно ~lg~следовать~/~ за вами по всей карте.##Нажатие по иконке ~y~левой кнопкой мыши~/~ переключает режим поведения юнита между ~lg~Следованием~/~ и ~r~Агрессией~/~.#Нажатие по иконке ~y~правой кнопкой мыши~/~ переключает режим поведения юнита между ~lg~Простоем~/~ и ~p~Автономией~/~.##Нажатие клавиши ~y~C~/~ позволяет задать точку для перемещения подконтрольной нежити.#Нажатие клавиши ~y~V~/~ позволяет задать цель для атаки подконтрольной нежити."},
                 }
            ),
            new LocalizationModifier(
                id: "o_b_charged_soul",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Essence Charge"},
                    {ModLanguage.Russian, "Поглощённая душа"},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of ~lg~Essence Charge~/~ grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration."},
                    {ModLanguage.Russian, @"Использование ~w~Заклинаний~/~ уменьшает степень эффекта на ~r~1~/~.##Повторное произнесение ~lg~Поглощения души~/~ увеличивает степень эффекта (вплоть до ~sy~IV~/~) и обновляет его длительность."},
                 }
            ),
            new LocalizationModifier(
                id: "o_b_deathbless",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Death's Blessing"},
                    {ModLanguage.Russian, "Дар Смерти"},
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_db_painful_curse",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Withering Curse"},
                    {ModLanguage.Russian, "Мучительное проклятие"},
                },
                description: null
            )
        );
    }
    public static void WeaponTextsPatching()
    {
        Msl.InjectTableWeaponTextsLocalization(
            new LocalizationWeaponText(
                id: "sinistercrown",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Sinister Crown"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "WIP"},
                }
            ),
            new LocalizationWeaponText(
                id: "hexermantle",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Hexer Mantle"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "WIP"},
                }
            ),
            new LocalizationWeaponText(
                id: "Skull Morion Ring",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Skull Morion Ring"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "WIP"},
                }
            )
        );
    }
}