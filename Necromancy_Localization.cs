
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
    public static void BooksPatching()
    {
        Msl.InjectTableBooksLocalization(
            new LocalizationBook(
                id: "cgrimoir",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Occult Treatise I"},
                    {ModLanguage.Russian, "Оккультный трактат I"},
                },
                content: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @". . . I’ve done it. The rat came back to life, squirming its little body with all the energy of a healthy newborn around the dagger with which I pinned it to the table last night.#I had to redraw the sigil five times but finally, I have done the impossible. I was so close to hurling my grimoire into the fireplace.#I was ready to give up and travel to the Cathedral to throw myself on my knees and beg for forgiveness. But it worked. I have created life from death.##It didn’t live for long, and perhaps that is a mercy. It limped around the table when I removed the dagger, squealing with obvious pain and terror, unable to react to any of the stimuli I prepared.#Finally the sun rose, and in its light the thing curled up and went quiet. Obviously I have a long way to go. I can’t bring her back like this.##Morella, forgive me. I must continue my experiments. I won’t waste more time with rats and frogs. Perhaps their souls are too small or their bodies too weak to properly receive the energies which flow from my sigil and my incantations without being damaged.#Perhaps I merely require practice until I have perfected this ritual. But in either case, I don’t have time to play with these trivial creatures while my love decays in her tomb. I must have a human corpse.##Tonight, the graveyard will yield the subject of my next breakthrough. . ."},
                },
                midText: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"\""The Forbidden Sigil: Unveiling magic through proper rituals.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Desecration~/~#~lg~Painful Curse~/~#~lg~Essence Charge~/~##Reading this book grants some ~y~Experience~/~."},
                    {ModLanguage.Russian, @"\""Запретный сигил: Раскрытие магии через подобающие ритуалы.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Осквернение~/~#~lg~Мучительное проклятие~/~#~lg~Поглощение души~/~##Прочтение этой книги приносит ~y~опыт~/~."},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "More than half of this dusty journal is filled with meaningless expressions and references."},
                    {ModLanguage.Russian, "Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями."},
                },
                type: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Written by Silas the priest"},
                    {ModLanguage.Russian, "Автор: Силас, священнослужитель"},
                }
            ),
            new LocalizationBook(
                id: "cgrimoir2",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Occult Treatise II"},
                    {ModLanguage.Russian, "Оккультный трактат II"},
                },
                content: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @". . . His subservience thrills and disgusts me. It is as though his personality decayed with his flesh. He at least remembers what his name was in life and can answer my questions when I speak slowly and loudly and avoid abstraction.## But he will say nothing of his own volition, do nothing except gnaw on things and smack his head against the wall. What a pitiful condition. But he lives again, despite the noose still tied around his neck. And he is intelligent enough to follow commands.##And he is strong, stronger than his putrefying muscles could possibly allow.## When I ordered him to guard me last night as I dug him up a brother, we were set upon by a territorial ghoul, angry that I was raiding its larder.# My new servant seized its arm, ripped it off and proceeded to beat the creature to death with it.#How can he be possessed of such power? My theory is that the energies with which I brought him back to life have not dissipated but suffuse his body still.# Perhaps this means that flesh is not even necessary for reanimation.## I will perform the ritual on a skeleton! . . ."},
                },
                midText: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"\""Danger awaits as madness thrives through your mistakes.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Ritual of Resurrection~/~#~lg~Death's Blessing~/~#~y~Growing Madness~/~#~y~Absolute Darkness~/~##Reading this book grants some ~y~Experience~/~."},
                    {ModLanguage.Russian, @"\""Устланный пороком путь вспять уже не обернуть.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Ритуал воскрешения~/~#~lg~Дары Смерти~/~#~y~Расцветающее безумие~/~#~y~Абсолютная тьма~/~##Прочтение этой книги приносит ~y~опыт~/~."},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "More than half of this dusty journal is filled with meaningless expressions and references."},
                    {ModLanguage.Russian, "Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями."},
                },
                type: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Written by Silas the priest"},
                    {ModLanguage.Russian, "Автор: Силас, священнослужитель"},
                }
            ),
            new LocalizationBook(
                id: "cgrimoir3",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Occult Treatise III"},
                    {ModLanguage.Russian, "Оккультный трактат III"},
                },
                content: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @". . . My creatures still terrify me but oh, the excitement is molten gold in my veins. The grimoire sings in my hands. My staff twists and churns under my fingers like a dying thing. The moon is a door and I am opening it, and what secrets whisper to me from the other side! Morella, if only you were here to see the fruit of my research!##Morella… I have scarcely had time to think of you these past few weeks. The work has taken on a life of its own, so to speak. I understand I can never bring you back the way you were. At first I grieved at the realisation, defeated. I missed your fair hair and your rosy cheeks and your sparkling eyes. I choked at the thought of returning you to life in the rotting shell of your former self, or untouchable and freezing cold like the wraiths which pour like tears up from the earth when I weep.##But the work continued and my insight grew and the whispers taught me that there is beauty in decay. Decay is life! The mould that grows on our bones is alive and it sings in the voice of the trees, the forest, the stars. All life sings in the voice of death. It is a blessing. I don’t remember the way your voice sounded. But I will give you a new voice. You will sing for me again and the worms will writhe in delight at your song.##And we will have a kingdom of our own, my love. I have made us a court. I have made us an army. They are so many now. At first I could only seize one at a time in my mind’s fist but I have learned to link their souls in a lattice which holds them all together. The lattice is a pattern, a rhythm. Our soldiers stumble from room to room of our palace with this rhythm guiding their steps, as they guard your tomb. It is a dance. It is the rhythm of your song. The lyrics were written in the caverns of our ancestors. They are written between the stars. The song. . ."},
                },
                midText: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"\""A celestial choreography unfolds, as the hands intricately weave the fabric of ascension, bestowing upon us a true blessing.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Death Touch~/~#~y~Grasp of Chaos~/~#~y~Soul Sacrifice~/~##Reading this book grants some ~y~Experience~/~."},
                    {ModLanguage.Russian, @"\""И когда планеты встанут в ряд - начнётся твой обряд, и тогда руки твои соткут ткань вознесения, даруя истинное благословение.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Касание смерти~/~#~y~Пожинание хаоса~/~#~y~Жертвоприношение души~/~##Прочтение этой книги приносит ~y~опыт~/~."},
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "More than half of this dusty journal is filled with meaningless expressions and references."},
                    {ModLanguage.Russian, "Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями."},
                },
                type: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Written by Silas the priest"},
                    {ModLanguage.Russian, "Автор: Силас, священнослужитель"},
                }
            )
        );
    }
    public static void TextTreesPatching()
    {
        Msl.InjectTableTextTreesLocalization(
            new LocalizationTextTree(
                id: "Necromancy",
                tier: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Occultism"},
                    {ModLanguage.Russian, "Оккультизм"},
                },
                hover: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~"},
                    {ModLanguage.Russian, "Бросьте вызов магическим ограничениям и познайте энтропические тайны, лежащие за гранью жизни и смерти.##~y~Особенности:~/~#~w~Поддержка~/~, ~w~Призыв слуг~/~, ~w~Выживаемость~/~, ~w~Ослабление врагов~/~"},
                }
            )
        );
    }
    public static void TextRaritysPatching()
    {
        Msl.InjectTableTextRaritysLocalization(
            new LocalizationTextRarity(
                id: "10",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Unholy"},
                    {ModLanguage.Russian, "магический / магическая / магическое / магические"},
                    {ModLanguage.Chinese, "魔法"},
                    {ModLanguage.German, "magischer / magische / magisches / magische"},
                    {ModLanguage.Spanish, "mágico / mágica / mágicos / mágicas"},
                    {ModLanguage.French, "magique / magique / magiques / magiques"},
                    {ModLanguage.Italian, "oggetto magico - "},
                    {ModLanguage.Portuguese, "mágico"},
                    {ModLanguage.Polish, "Magiczny / Magiczna / Magiczne / Magiczne"},
                    {ModLanguage.Turkish, "büyülü"},
                    {ModLanguage.Japanese, "マジカル"},
                    {ModLanguage.Korean, "마법의"},
                }
            )
        );
    }
    public static void SkillsPatching()
    {
        
        Msl.InjectTableSkillsLocalization(
            new LocalizationSkill(
                id: "Soul_Explosion",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Mastery of Binding"},
                    {ModLanguage.Russian, "Жертвоприношение души"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~."},
                }
            ),
            new LocalizationSkill(
                id: "imortall",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Immortality"},
                    {ModLanguage.Russian, "Бессмертие"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration."},
                }
            ),
            new LocalizationSkill(
                id: "kingdead",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Archtheurgy"},
                    {ModLanguage.Russian, "Архитеургия"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~."},
                }
            ),
            new LocalizationSkill(
                id: "Lostsouls",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Triple Hand Reunion"},
                    {ModLanguage.Russian, "Великий ритуал воскрешения"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~."},
                }
            ),
            new LocalizationSkill(
                id: "Death_Plague",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Essence Leech"},
                    {ModLanguage.Russian, "Поглощение души"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration."},
                }
            ),
            new LocalizationSkill(
                id: "nmadness",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Blooming Madness"},
                    {ModLanguage.Russian, "Расцветающее безумие"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~."},
                }
            ),
            new LocalizationSkill(
                id: "unholymind",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Presence of Darkness"},
                    {ModLanguage.Russian, "Жатва хаоса"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn."},
                }
            ),
            new LocalizationSkill(
                id: "ndarkness",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Sealed Mind"},
                    {ModLanguage.Russian, "Абсолютная тьма"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance."},
                }
            ),
            new LocalizationSkill(
                id: "Pcurse",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Withering Curse"},
                    {ModLanguage.Russian, "Мучительное проклятие"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~)."},
                }
            ),
            new LocalizationSkill(
                id: "Bw_Bless",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Death's Blessing"},
                    {ModLanguage.Russian, "Дары Смерти"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection."},
                }
            ),
            new LocalizationSkill(
                id: "Bw_Bolt",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Desecration"},
                    {ModLanguage.Russian, "Осквернение"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack."},
                }
            ),
            new LocalizationSkill(
                id: "Bw_Resurrection",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Resurrection"},
                    {ModLanguage.Russian, "Воскрешение"},
                    {ModLanguage.Chinese, "低等起死还魂"},
                    {ModLanguage.German, "Kleines Ritual der Auferstehung"},
                    {ModLanguage.Italian, "Rituale di Resurrezione Inferiore"},
                    {ModLanguage.Japanese, "復活の簡易儀式"},
                    {ModLanguage.Korean, "소규모 부활 의식"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Reanimates a targeted corpse, replenishing it ~lg~66%~/~ Max Health and ~bl~66%~/~ Max Energy and sets Armor Durability to ~w~0%~/~.##Increases ~lg~morale~/~ (up to ~w~75%~/~).#Slowly decreases ~lg~Sanity~/~ but no less than ~r~60%~/~.##Risk of ~r~\""Obsession\""~/~: ~ur~High~/~#Summoning more than one Undead instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Undeads higher than level ~w~/*LEVL*/~/~.##~r~Prevents~/~ from receiving ~ly~\""Blessing\""~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~."},
                }
            ),
            new LocalizationSkill(
                id: "Bw_Touch",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Death Touch"},
                    {ModLanguage.Russian, "Касание смерти"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell."},
                }
            ),
            new LocalizationSkill(
                id: "Wraith_Binding",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Wraith Summoning"},
                    {ModLanguage.Russian, "Призыв умертвия"},
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~."},
                }
            )
        );
    }
    public static void SealOfPowerUpdate()
    {
        Msl.LoadGML("gml_GlobalScript_table_skills")
            .Apply(SealOfPowerIterator)
            .Save();
    }
    private static IEnumerable<string> SealOfPowerIterator(IEnumerable<string> input)
    {
        string sealofpower_en = "#~ur~Occultism:~/~ ~lg~+15%~/~ Magic Power, ~lg~+12.5%~/~ Weapon Damage, dealt as Unholy, ~lg~-5%~/~ Damage Taken, ~lg~-5%~/~ Cooldown Durations";

        foreach(string item in input)
        {
            if (item.Contains("\";skill_name_end"))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf(@"##Произнесение заклинаний ~lb~искусства магии"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Casting ~lb~Magic Mastery"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##催动~lb~“驭法”"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Das Wirken von ~lb~Zauberkunst~/~"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Lancer des sorts de ~lb~Maîtrise de la magie"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Lanciare incantesimi relativi all'~lb~Affinità Magica~/~"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Conjurar feitiços de ~lb~Maestria Mágica~/~"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Rzucanie zaklęć z drzewka ~lb~sztuki magicznej~/~"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"## ~lb~Büyü Ustalığı~/~ büyüleri kullanmak"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##~lb~魔術技能~/~ の魔術"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##~lb~마법 숙달~/~ 주문"), sealofpower_en);
                // TODO Español LATAM is still missing
                yield return newItem;
            }
            else
            {
                yield return item;
            }
        }
    }
}