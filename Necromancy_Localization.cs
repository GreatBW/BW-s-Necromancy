
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
                    {ModLanguage.Chinese, "伊纳戈祖……？"}
                }
            ),
            new LocalizationSpeech(
                id: "Wraith_Binding",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.Russian, "Korrug Namar!"},
                    {ModLanguage.English, "Lagura mithensa!"},
                    {ModLanguage.Chinese, "拉古阿'密瑟萨！"},
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
                    {ModLanguage.Chinese, "拉古阿'纳'梅达……？"},
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
                    {ModLanguage.Chinese, "拉古'拉古'拉……？！"}
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
                    {ModLanguage.Chinese, "沙格拉斯'呃……？"}
                }
            ),
            new LocalizationSpeech(
                id: "Death_Plague",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "En'thero !"},
                    {ModLanguage.Chinese, "恩'泰罗！"}
                }
            ),
            new LocalizationSpeech(
                id: "MC_Death_Plague",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "En'tera"},
                    {ModLanguage.Chinese, "恩'特拉"}
                }
            ),
            new LocalizationSpeech(
                id: "Lostsouls",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Lagura Lamera !"},
                    {ModLanguage.Chinese, "拉古拉'拉梅拉！"}
                }
            ),
            new LocalizationSpeech(
                id: "MC_Lostsouls",
                new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Lagurera Mara ... ?!"},
                    {ModLanguage.Chinese, "拉古热拉'玛拉……？！"}
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
                    {ModLanguage.Chinese, "廓卢戈'勒玛……？！"},
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
                    {ModLanguage.Chinese, "亚克'阿托……?!"}
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
                    {ModLanguage.Chinese, "痴迷"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"The penalties change dynamically depending on the missing percentage of ~lg~Sanity~/~.##May Cause ~r~Confusion~/~ or ~r~Daze~/~.##Deals ~ur~1-3 Unholy Damage~/~ if sanity drops below ~r~33%~/~.##~r~Near death~/~: the character's Max Health is reduced every few turns."},
                    {ModLanguage.Russian, @"Штрафы меняются каждый ход в зависимости от недостающего ~lg~рассудка~/~.##Может вызвать ~r~Замешательство~/~ или ~r~Ошеломление~/~.##~r~Смерть близка~/~: каждые несколько ходов максимальное здоровье снижается."},
                    {ModLanguage.Chinese, @"根据~lg~神智~/~减少的百分比施加不同程度的惩罚。##可能会造成~r~慌乱~/~或~r~眩晕~/~。##如果神智降至~r~33%~/~以下，造成~ur~1-3点邪术伤害~/~。##~r~濒死~/~：角色的生命上限每隔几回合就会降低。"}
                }
            ),
            new LocalizationModifier(
                id: "o_b_angel_charm",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Ascension"},
                    {ModLanguage.Russian, "Вознесение"},
                    {ModLanguage.Chinese, "扬升"}
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_b_unbind",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Unbind"},
                    {ModLanguage.Russian, "Отвязать"},
                    {ModLanguage.Chinese, "解放"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Clicking on this icon instantly kills this undead and then advances a turn."},
                    {ModLanguage.Russian, @"Нажатие на иконку эффекта или клавиши ~r~N~/~ в этом окне моментально убивает эту нежить. Тратит ход."},
                    {ModLanguage.Chinese, @"点击该图标可立即杀死该亡灵，然后前进一回合。"}
                }
            ),
            new LocalizationModifier(
                id: "o_b_darkenchant",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Dark Enchantment"},
                    {ModLanguage.Russian, "Тёмный договор"},
                    {ModLanguage.Chinese, "黑暗魔力"}
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_db_punishment",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Punishment"},
                    {ModLanguage.Chinese, "惩罚"}
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_b_exceptional",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Disorder"},
                    {ModLanguage.Russian, "Исключительная душа"},
                    {ModLanguage.Chinese, "紊乱"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Negates penalties of ~r~Obsession~/~.##Prevents from receiving ~r~Obsession~/~.##When effect expires: ~r~unbinds~/~ all allied wraiths."},
                    {ModLanguage.Russian, @"Аннулирует штрафы от эффекта ~r~\""Одержимости\""~/~ и препятствует его получению.##Когда эффект заканчивает: ~r~возвращает в загробный мир~/~ всех союзных умертвий."},
                    {ModLanguage.Chinese, @"抵消~r~“痴迷”~/~的惩罚。##防止获得~r~“痴迷”~/~。##效果结束时：~r~解放~/~所有友方幽魂。"}
                }
            ),
            new LocalizationModifier(
                id: "o_bw_sacrifice",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Soul Sacrifice"},
                    {ModLanguage.Chinese, "灵魂献祭"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy.;Pressing ~r~K~/~ activates the effect and then advances a turn.##Activation consumes ~bl~10%~/~ of Max Energy."},
                    {ModLanguage.Chinese, @"按下 ~r~K~/~ 激活效果并前进一回合。##激活会消耗 ~bl~10%~/~ 精力上限的精力。；按下 ~r~K~/~ 会激活效果并前进一回合。##激活会消耗 ~bl~10%~/~ 精力上限的精力。"}
                 }
            ),
            new LocalizationModifier(
                id: "o_b_servemaster",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Revivify"},
                    {ModLanguage.Russian, "Оживление"},
                    {ModLanguage.Chinese, "复活"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Considered as an ~r~Undead~/~: bringing it inside settlements is ~r~Crime~/~.##Capable of ~lg~Following~/~ you everywhere on the map.##~y~Left clicking~/~ this icon switches ~r~Aggressive~/~ and ~lg~Follow~/~ mode.#~y~Right clicking~/~ this icon switches ~lg~Idle~/~ and ~p~Autonomous~/~ mode.##Pressing ~y~V~/~ allows for selectable positioning."},
                    {ModLanguage.Russian, @"Считается ~r~нежитью~/~: привод в город является ~r~преступлением~/~.##Способно ~lg~следовать~/~ за вами по всей карте.##Нажатие по иконке ~y~левой кнопкой мыши~/~ переключает режим поведения юнита между ~lg~Следованием~/~ и ~r~Агрессией~/~.#Нажатие по иконке ~y~правой кнопкой мыши~/~ переключает режим поведения юнита между ~lg~Простоем~/~ и ~p~Автономией~/~.##Нажатие клавиши ~y~C~/~ позволяет задать точку для перемещения подконтрольной нежити.#Нажатие клавиши ~y~V~/~ позволяет задать цель для атаки подконтрольной нежити."},
                    {ModLanguage.Chinese, @"被视为~r~亡灵~/~：将其带入定居点是~r~犯罪~/~。##可以在地图上的任何地方~lg~跟随~/~你。##~y~左键点击~/~此图标可切换~r~攻击~/~和~lg~跟随~/~模式。#~y~右键点击~/~此图标可切换~lg~闲置~/~和~p~自主~/~模式。##按下 ~y~V~/~ 可使其前往特定位置。"}
                 }
            ),
            new LocalizationModifier(
                id: "o_b_charged_soul",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Essence Charge"},
                    {ModLanguage.Russian, "Поглощённая душа"},
                    {ModLanguage.Chinese, "精魄蓄积"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of ~lg~Essence Charge~/~ grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration."},
                    {ModLanguage.Russian, @"Использование ~w~Заклинаний~/~ уменьшает степень эффекта на ~r~1~/~.##Повторное произнесение ~lg~Поглощения души~/~ увеличивает степень эффекта (вплоть до ~sy~IV~/~) и обновляет его длительность."},
                    {ModLanguage.Chinese, @"使用 ~w~咒法~/~ 会令层数减少 ~r~1~/~。##反复催动~lg~摄魄~/~会令效果叠加（最多~w~四~/~层），并重置效果的存续时间。"}
                 }
            ),
            new LocalizationModifier(
                id: "o_b_deathbless",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Death's Blessing"},
                    {ModLanguage.Russian, "Дар Смерти"},
                    {ModLanguage.Chinese, "死亡祝福"}
                },
                description: null
            ),
            new LocalizationModifier(
                id: "o_db_painful_curse",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Withering Curse"},
                    {ModLanguage.Russian, "Мучительное проклятие"},
                    {ModLanguage.Chinese, "枯萎诅咒"}
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
                    {ModLanguage.Chinese, "邪冕"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "WIP"},
                }
            ),
            new LocalizationWeaponText(
                id: "hexermantle",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Hexer Mantle"},
                    {ModLanguage.Chinese, "咒师斗篷"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "WIP"},
                }
            ),
            new LocalizationWeaponText(
                id: "Skull Morion Ring",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Skull Morion Ring"},
                    {ModLanguage.Chinese, "头骨烟晶戒"}
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
                    {ModLanguage.Chinese, "死灵术文献I"}
                },
                content: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @". . . I’ve done it. The rat came back to life, squirming its little body with all the energy of a healthy newborn around the dagger with which I pinned it to the table last night.#I had to redraw the sigil five times but finally, I have done the impossible. I was so close to hurling my grimoire into the fireplace.#I was ready to give up and travel to the Cathedral to throw myself on my knees and beg for forgiveness. But it worked. I have created life from death.##It didn’t live for long, and perhaps that is a mercy. It limped around the table when I removed the dagger, squealing with obvious pain and terror, unable to react to any of the stimuli I prepared.#Finally the sun rose, and in its light the thing curled up and went quiet. Obviously I have a long way to go. I can’t bring her back like this.##Morella, forgive me. I must continue my experiments. I won’t waste more time with rats and frogs. Perhaps their souls are too small or their bodies too weak to properly receive the energies which flow from my sigil and my incantations without being damaged.#Perhaps I merely require practice until I have perfected this ritual. But in either case, I don’t have time to play with these trivial creatures while my love decays in her tomb. I must have a human corpse.##Tonight, the graveyard will yield the subject of my next breakthrough. . ."},
                    {ModLanguage.Chinese, @". . . 我成功了。这只老鼠又活过来了，它的小身体像健康的新生儿一样，围着昨晚我把它钉在桌子上的匕首蠕动着。#我重新画了五次魔印，终于完成了这个不可能的任务。我差点就把我的魔法书扔进壁炉里了。#我准备放弃，去大教堂跪下来乞求宽恕。但我成功了。我从死亡中创造了生命##它没有活多久，也许这也是一种仁慈。当我拔出匕首时，它一瘸一拐地绕着桌子走，发出明显的痛苦和惊恐的尖叫，对我准备的任何刺激都无法做出反应。#最后，太阳升起来了，在阳光的照耀下，那东西蜷缩起来，安静了下来。显然，我还有很长的路要走。我不能就这样把她带回来。##莫瑞拉，原谅我。我必须继续我的实验。我不会再在老鼠和青蛙身上浪费时间了。也许它们的灵魂太渺小，或者它们的身体太虚弱，无法正确接收我的魔印和咒语中流出的能量而不受伤害。#也许我只是需要练习，直到我完善了这个仪式。但无论如何，当我的爱人在坟墓中腐烂时，我可没时间和这些微不足道的生物玩耍。我必须要一具人类的尸体。##今晚，墓地将成为我下一个突破的对象. . ."}
                },
                midText: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"\""The Forbidden Sigil: Unveiling magic through proper rituals.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Desecration~/~#~lg~Painful Curse~/~#~lg~Essence Charge~/~##Reading this book grants some ~y~Experience~/~."},
                    {ModLanguage.Russian, @"\""Запретный сигил: Раскрытие магии через подобающие ритуалы.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Осквернение~/~#~lg~Мучительное проклятие~/~#~lg~Поглощение души~/~##Прочтение этой книги приносит ~y~опыт~/~."},
                    {ModLanguage.Chinese, @"《禁忌之符：通过适当的仪式揭开魔法的神秘面纱》##~gr~允许你学习以下死灵术：~/~##~lg~亵渎~/~#~lg~枯萎诅咒~/~#~lg~摄魄~/~##阅读此书可获得一些~y~经验~/~。"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "More than half of this dusty journal is filled with meaningless expressions and references."},
                    {ModLanguage.Russian, "Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями."},
                    {ModLanguage.Chinese, "在这本尘封的日记中，一半以上的篇幅都是毫无意义的表述和引用。"}
                },
                type: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Written by Silas the priest"},
                    {ModLanguage.Russian, "Автор: Силас, священнослужитель"},
                    {ModLanguage.Chinese, "作者：牧师西拉"}
                }
            ),
            new LocalizationBook(
                id: "cgrimoir2",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Occult Treatise II"},
                    {ModLanguage.Russian, "Оккультный трактат II"},
                    {ModLanguage.Chinese, "死灵术文献II"}
                },
                content: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @". . . His subservience thrills and disgusts me. It is as though his personality decayed with his flesh. He at least remembers what his name was in life and can answer my questions when I speak slowly and loudly and avoid abstraction.## But he will say nothing of his own volition, do nothing except gnaw on things and smack his head against the wall. What a pitiful condition. But he lives again, despite the noose still tied around his neck. And he is intelligent enough to follow commands.##And he is strong, stronger than his putrefying muscles could possibly allow.## When I ordered him to guard me last night as I dug him up a brother, we were set upon by a territorial ghoul, angry that I was raiding its larder.# My new servant seized its arm, ripped it off and proceeded to beat the creature to death with it.#How can he be possessed of such power? My theory is that the energies with which I brought him back to life have not dissipated but suffuse his body still.# Perhaps this means that flesh is not even necessary for reanimation.## I will perform the ritual on a skeleton! . . ."},
                    {ModLanguage.Chinese, @". . . 他的顺从让我激动，也让我厌恶。就好像他的人格和肉体一起腐烂了。他至少还记得自己生前叫什么名字，当我慢慢地大声说话，避免抽象时，他还能回答我的问题。##但他什么也不会主动说，什么也不会做，只会咬东西和用头撞墙。真是可怜。但他又活过来了，尽管脖子上还套着绞索。他很聪明，能够听从命令。##他很强壮，比他腐烂的肌肉所能承受的还要强壮。##昨晚我命令他保护我，因为我给他挖出了一个兄弟，我们被一只领地食尸鬼袭击了，它很生气，因为我抢了它的食物。#我的新仆人抓住了它的胳膊，把它扯了下来，然后用胳膊把它打死了。#他怎么会拥有如此强大的力量？我的理论是，我让他起死回生的能量并没有消散，而是仍然充斥着他的身体。#也许这意味着肉体并不是复活的必要条件。##我将在一具骷髅上举行仪式！. . ."}
                },
                midText: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"\""Danger awaits as madness thrives through your mistakes.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Ritual of Resurrection~/~#~lg~Death's Blessing~/~#~y~Growing Madness~/~#~y~Absolute Darkness~/~##Reading this book grants some ~y~Experience~/~."},
                    {ModLanguage.Russian, @"\""Устланный пороком путь вспять уже не обернуть.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Ритуал воскрешения~/~#~lg~Дары Смерти~/~#~y~Расцветающее безумие~/~#~y~Абсолютная тьма~/~##Прочтение этой книги приносит ~y~опыт~/~."},
                    {ModLanguage.Chinese, @"《危险在等待，疯狂在你的错误中滋长》##~gr~允许你学习以下死灵术：~/~##~lg~低等起死还魂~/~#~lg~死亡祝福~/~#~y~癫狂盛放 ~/~#~y~黑暗降临~/~##阅读此书可获得一些~y~经验 ~/~。"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "More than half of this dusty journal is filled with meaningless expressions and references."},
                    {ModLanguage.Russian, "Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями."},
                    {ModLanguage.Chinese, "在这本尘封的日记中，一半以上的篇幅都是毫无意义的表述和引用。"}
                },
                type: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Written by Silas the priest"},
                    {ModLanguage.Russian, "Автор: Силас, священнослужитель"},
                    {ModLanguage.Chinese, "作者：牧师西拉"}
                }
            ),
            new LocalizationBook(
                id: "cgrimoir3",
                name: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Occult Treatise III"},
                    {ModLanguage.Russian, "Оккультный трактат III"},
                    {ModLanguage.Chinese, "死灵术文献III"}
                },
                content: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @". . . My creatures still terrify me but oh, the excitement is molten gold in my veins. The grimoire sings in my hands. My staff twists and churns under my fingers like a dying thing. The moon is a door and I am opening it, and what secrets whisper to me from the other side! Morella, if only you were here to see the fruit of my research!##Morella… I have scarcely had time to think of you these past few weeks. The work has taken on a life of its own, so to speak. I understand I can never bring you back the way you were. At first I grieved at the realisation, defeated. I missed your fair hair and your rosy cheeks and your sparkling eyes. I choked at the thought of returning you to life in the rotting shell of your former self, or untouchable and freezing cold like the wraiths which pour like tears up from the earth when I weep.##But the work continued and my insight grew and the whispers taught me that there is beauty in decay. Decay is life! The mould that grows on our bones is alive and it sings in the voice of the trees, the forest, the stars. All life sings in the voice of death. It is a blessing. I don’t remember the way your voice sounded. But I will give you a new voice. You will sing for me again and the worms will writhe in delight at your song.##And we will have a kingdom of our own, my love. I have made us a court. I have made us an army. They are so many now. At first I could only seize one at a time in my mind’s fist but I have learned to link their souls in a lattice which holds them all together. The lattice is a pattern, a rhythm. Our soldiers stumble from room to room of our palace with this rhythm guiding their steps, as they guard your tomb. It is a dance. It is the rhythm of your song. The lyrics were written in the caverns of our ancestors. They are written between the stars. The song. . ."},
                    {ModLanguage.Chinese, @". . . 我的生物仍然让我恐惧，但哦，我血管里的兴奋就像熔化的黄金。魔法书在我手中歌唱。我的法杖在我的指下扭曲翻滚，就像一个垂死之物。月亮是一扇门，而我正在打开它，有什么秘密从另一边向我低语！莫瑞拉，如果你能看到我的研究成果就好了！##莫瑞拉......过去几周，我几乎没有时间想你。可以说是工作占据了我的生活。我知道我永远无法让你回到从前。起初，我为自己的失败而悲伤。我想念你白皙的头发、红润的脸颊和闪亮的眼睛。我一想到要让你回到从前腐烂的躯壳里，或者像我哭泣时从地底涌出的泪水一样不可触碰、冰冷刺骨，就感到窒息。##但工作仍在继续，我的洞察力也在增长，耳语告诉我，腐烂也是一种美。腐朽就是生命！生长在我们骨头上的霉菌是有生命的，它用树木、森林和星星的声音歌唱。所有生命都在用死亡的声音歌唱。这是一种祝福。我不记得你的声音了。但我会给你新的声音。你将再次为我歌唱，虫子们将在你的歌声中欢快地蠕动。##我们将拥有自己的王国，亲爱的。我为我们构建了宫廷。我为我们打造了一支军队。他们现在人数众多。起初，我只能在脑海中一次抓住一个，但我已经学会了用晶格将它们的灵魂连接在一起。晶格是一种模式，一种节奏。我们的士兵在守卫你的陵墓时，就是在这种节奏的指引下，蹒跚地从宫殿的一个房间走到另一个房间。这是一种舞蹈。这是您歌曲的节奏。歌词写在我们祖先的洞穴里。歌词写在星星间。这首歌. . ."}
                },
                midText: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, @"\""A celestial choreography unfolds, as the hands intricately weave the fabric of ascension, bestowing upon us a true blessing.\""##~gr~Allows you to learn the following Occultism abilities:~/~##~lg~Death Touch~/~#~y~Grasp of Chaos~/~#~y~Soul Sacrifice~/~##Reading this book grants some ~y~Experience~/~."},
                    {ModLanguage.Russian, @"\""И когда планеты встанут в ряд - начнётся твой обряд, и тогда руки твои соткут ткань вознесения, даруя истинное благословение.\""##~gr~Открывает возможность изучить некоторые оккультные способности:~/~##~lg~Касание смерти~/~#~y~Пожинание хаоса~/~#~y~Жертвоприношение души~/~##Прочтение этой книги приносит ~y~опыт~/~."},
                    {ModLanguage.Chinese, @"《天体的舞曲徐徐展开，双手精心编织升天的织物，赐予我们真正的祝福》##~gr~允许你学习以下死灵术：~/~##~lg~死亡之触~/~#~y~混沌之握~/~#~y~灵魂献祭~/~##阅读此书可获得一些~y~经验~/~。"}
                },
                description: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "More than half of this dusty journal is filled with meaningless expressions and references."},
                    {ModLanguage.Russian, "Более половины этой пыльной книги наполнено бессмысленными выражениями и рассуждениями."},
                    {ModLanguage.Chinese, "在这本尘封的日记中，一半以上的篇幅都是毫无意义的表述和引用。"}
                },
                type: new Dictionary<ModLanguage, string> {
                    {ModLanguage.English, "Written by Silas the priest"},
                    {ModLanguage.Russian, "Автор: Силас, священнослужитель"},
                    {ModLanguage.Chinese, "作者：牧师西拉"}
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
                    {ModLanguage.Chinese, "死灵术"}
                },
                hover: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Challenge magical bounds and master the chaotic dance between life and death with the artistry of a true warlock.##~y~Main focus:~/~#~w~Support~/~, ~w~Minion Management~/~, ~w~Survivability~/~, ~w~Weakening Effects~/~"},
                    {ModLanguage.Russian, "Бросьте вызов магическим ограничениям и познайте энтропические тайны, лежащие за гранью жизни и смерти.##~y~Особенности:~/~#~w~Поддержка~/~, ~w~Призыв слуг~/~, ~w~Выживаемость~/~, ~w~Ослабление врагов~/~"},
                    {ModLanguage.Chinese, "挑战魔法极限，以真正术士的技艺掌握生死之间的混乱之舞。##~y~能力要义：~/~#~w~支援~/~、~w~仆从管理~/~、~w~生存能力~/~、~w~造成减益~/~"}
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
                    {ModLanguage.Chinese, "召唤精通"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Unbinding allies doesn't take a turn and replenishes ~bl~Energy~/~ equal to ~w~10%~/~ of your Magic Power.##Increases the ~w~level~/~ of summoning abilities by ~lg~1~/~."},
                    {ModLanguage.Chinese, @"解放友方亡灵不消耗回合，而且会恢复相当于你法力~w~10%~/~的~bl~精力~/~。##召唤能力~w~等级~/~提高~lg~1~/~。"}
                }
            ),
            new LocalizationSkill(
                id: "imortall",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Immortality"},
                    {ModLanguage.Russian, "Бессмертие"},
                    {ModLanguage.Chinese, "不朽"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Prevents dying from lethal hits as long as ~r~Max Health~/~ and ~lg~Morale~/~ are both higher than ~lg~50%~/~.##When ~r~Health~/~ drops below 2, replenishes ~lg~33%~/~ of ~r~Max Health~/~ and ~bl~Max Energy~/~, and applies:##~r~-10% Morale~/~#~r~+2% Fatigue~/~##Prevents ~r~death~/~ from starvation or dehydration."},
                    {ModLanguage.Chinese, @"只要~r~生命上限~/~和~lg~斗志~/~都高于~lg~50%~/~，就可以防止死于致命打击。##当~r~生命~/~降至2以下时，回复~r~生命值上限~/~和~bl~精力上限~/~的~lg~33%~/~，并：##~r~斗志-10%~/~#~r~疲劳+2%~/~##防止因饥饿或脱水而~r~死亡~/~。"}
                }
            ),
            new LocalizationSkill(
                id: "kingdead",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Archtheurgy"},
                    {ModLanguage.Russian, "Архитеургия"},
                    {ModLanguage.Chinese, "至高法咒"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Casting ~w~Spells~/~ deal ~ur~/*Unholy_Damage*/ Unholy Damage~/~ to all enemies within vision (based on ~lg~3.33%~/~ of ~w~Magic Power~/~).##~w~Raising the dead~/~, ~w~summoning wraiths~/~, ~w~Stealing Essence~/~ or ~w~receiving~/~ ~lg~\""Death's Blessing\""~/~ has ~lg~33%~/~ chance to activate ~lg~\""Ascension\""~/~ for ~w~6~/~ turns, granting:##~lg~+33%~/~ Unholy Resistance#~lg~+66%~/~ Miracle Potency#Converts ~ur~Unholy Damage~/~ into ~ly~Sacred Damage~/~."},
                    {ModLanguage.Chinese, @"施放~w~咒法~/~会对视野内所有敌人造成~ur~/*Unholy_Damage*/点邪术伤害~/~（基于~lg~3.33%~/~的~w~法力~/~）##~w~复活死者~/~、~w~召唤幽灵~/~、~w~摄魄~/~或~w~接受~/~~lg~“死亡的祝福”~/~有~lg~33%~/~的几率激活~lg~“扬升”~/~~w~6~/~回合，授予：##邪术抗性~lg~+33%~/~#奇观效果~lg~+66%~/~#将~ur~邪术伤害~/~转化为~ly~神圣伤害~/~。"}
                }
            ),
            new LocalizationSkill(
                id: "Lostsouls",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Triple Hand Reunion"},
                    {ModLanguage.Russian, "Великий ритуал воскрешения"},
                    {ModLanguage.Chinese, "三手重聚"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Reanimates up to ~w~3~/~ corpses within ~w~6~/~ tiles, restoring them to ~lg~33%~/~ of their ~r~Max Health~/~ and ~lg~33%~/~ ~bl~Max Energy~/~.##Summons a ~w~Wraith~/~ for each missing corpse within the area of effect. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Grants ~w~3-6~/~ turns of ~lg~\""Disorder\""~/~ for each instance of ~w~Summoning~/~. ~w~Wraiths~/~ ~r~die~/~ once ~lg~\""Disorder\""~/~ expires.##This spell cannot be cast while under the effects of ~r~\""Obsession\""~/~ or ~lg~\""Disorder\""~/~."},
                    {ModLanguage.Chinese, @"复活方圆~w~6~/~个方格内最多~w~3~/~具尸体，使其恢复到~r~生命上限~/~的~lg~33%~/~和~bl~精力上限~/~的~lg~33%~/~。##在效果区域内为每具复活的尸体召唤一个~w~幽灵~/~，~w~幽灵~/~的力量取决于~lg~“精魄蓄积”~/~叠加的层数。##每次~w~召唤~/~都会授予~w~3-6~/~回合的~lg~“紊乱”~/~。一旦~lg~“紊乱”~/~结束， ~w~幽灵~/~就会~r~死亡~/~。##在~r~“痴迷”~/~或~lg~“紊乱”~/~的影响下，无法施放此咒语。"}
                }
            ),
            new LocalizationSkill(
                id: "Death_Plague",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Essence Leech"},
                    {ModLanguage.Russian, "Поглощение души"},
                    {ModLanguage.Chinese, "摄魄"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Devours a targeted corpse or steals ~r~13%~/~ Max Health and ~bl~13%~/~ Max Energy from an Undead ally, transferring half of them to the caster.##Activates ~lg~\""Essence Charge\""~/~ for ~w~30~/~ turns:##~lg~+5%~/~ Weapon Damage#~lg~+10%~/~ Magic Power#~lg~-6%~/~ Abilities Energy Cost#~lg~+8~/~ Max Energy#~lg~+66%~/~ Fatigue Resistance (this effect decreases based on the stacks)##~w~III~/~ and ~w~IV~/~ stacks of the effect: slight chance of causing ~r~\""Obsession\""~/~.##Using ~w~Spells~/~ reduce the number of stacks by ~r~1~/~.##The repeated use of the spell grants an extra stack of the effect (up to ~w~IV~/~) and refreshes its duration."},
                    {ModLanguage.Chinese, @"吞噬目标尸体或从友方亡灵身上摄取生命上限~r~13%~/~的生命和精力上限~bl~13%~/~的精力，将其中一半转移给施法者。##激活~lg~“精魄蓄积”~/~~w~30~/~回合：##兵器伤害~lg~+5%~/~#法力~lg~+10%~/~#能力精力消耗~lg~-6%~/~#精力上限~lg~+8~/~#抗疲劳性~lg~+66%~/~（这个效果随着层数增加而降低）#第~w~三~/~和第~w~四~/~层的效果：有轻微几率导致~r~“痴迷”~/~。#使用~w~咒法~/~会导致叠加的层数减少~r~1~/~。##反复催动这道咒法会令效果叠加（最多~w~四~/~层），并重置效果的存续时间。"}
                }
            ),
            new LocalizationSkill(
                id: "nmadness",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Blooming Madness"},
                    {ModLanguage.Russian, "Расцветающее безумие"},
                    {ModLanguage.Chinese, "癫狂盛放"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Successfully raising the dead allows you to ~y~learn~/~ their ~w~active abilities~/~ (for as long as they are available via skill menu).##Increases ~y~Experience Gain~/~ of Undead kills by ~lg~100%~/~."},
                    {ModLanguage.Chinese, @"成功复活死者可以让你~y~学习~/~他们的~w~主动能力~/~（只要他们可以通过技能窗口获得）。##亡灵击杀所获经验增加~y~100%~/~。"}
                }
            ),
            new LocalizationSkill(
                id: "unholymind",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Presence of Darkness"},
                    {ModLanguage.Russian, "Жатва хаоса"},
                    {ModLanguage.Chinese, "黑暗降临"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Each turn, decreases max Unholy Resistance of Undeads and Proselytes by ~r~7%~/~ within ~w~7~/~ tiles, which persists for ~w~9~/~ turns.##This effect stacks up to ~w~9~/~ times.##If affecting by ~r~\""Obsession\""~/~, the effect triggers twice per turn."},
                    {ModLanguage.Chinese, @"每回合，在~w~7~/~个方格内，不死生灵和变节信徒的最大邪术抗性降低~r~7%~/~，持续~w~9~/~回合。##这种效果最多叠加~w~9~/~次。##如果受到~r~“痴迷”~/~的影响，此效果每回合都会触发两次。"}
                }
            ),
            new LocalizationSkill(
                id: "ndarkness",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Sealed Mind"},
                    {ModLanguage.Russian, "Абсолютная тьма"},
                    {ModLanguage.Chinese, "心灵封闭"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Halves sanity loss of ~w~Occultism~/~ abilities and partially decreases penalties of ~r~\""Obsession\""~/~.##Grants ~lg~33%~/~ Unholy Resistance."},
                    {ModLanguage.Chinese, @"减半释放~w~死灵术~/~导致的神智丧失，并部分减轻~r~“痴迷”~/~的惩罚。##给予~lg~33%~/~的邪术抗性。"}
                }
            ),
            new LocalizationSkill(
                id: "Pcurse",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Withering Curse"},
                    {ModLanguage.Russian, "Мучительное проклятие"},
                    {ModLanguage.Chinese, "枯萎诅咒"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Applies the target with ~r~\""Withering Curse\""~/~ for ~w~13~/~ turns:##~r~-9%~/~ Fortitude#~r~-9%~/~ Magic Resistance#~r~-7%~/~ Nature Resistance#~r~-6%~/~ Max Health#~r~+4%~/~ Damage Taken##Each turn worsens the Condition of a random body part by ~r~0.5%~/~ per each stack.##Hitting the target by ~lg~\""Desecration\""~/~ or the the repeated use of the spell against the same target applies an extra stack of the effect (up to ~w~III~/~)."},
                    {ModLanguage.Chinese, @"对目标施加~w~13~/~回合的~r~“枯萎诅咒”~/~：##坚忍~r~-9%~/~#魔法抗性~r~-9%~/~#自然抗性~r~-7%~/~#生命上限~r~-6%~/~#所受伤害~r~+4%~/~#每回合令目标任意身体部位的状态每层效果恶化~r~0.5%~/~。##通过~lg~“亵渎”~/~击中目标，或对同一目标重复使用该咒法，这个效果叠加一层（最多~w~三~/~层）"}
                }
            ),
            new LocalizationSkill(
                id: "Bw_Bless",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Death's Blessing"},
                    {ModLanguage.Russian, "Дары Смерти"},
                    {ModLanguage.Chinese, "死亡祝福"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Replenishes ~lg~/*H_P*/%~/~ Max Health to the target and improves the condition of bodyparts by ~lg~33%~/~ of the amount of health replenished.##This effect is ~lg~50%~/~ more effective on allied Undeads.##grants the target ~lg~\""Death's Blessing\""~/~ for ~w~13~/~ turns:##~lg~+9%~/~ Life Drain#~lg~+9%~/~ Energy Drain#~lg~+13%~/~ Damage Reflection."},
                    {ModLanguage.Chinese, @"为目标补充生命上限~lg~/*H_P*/%~/~的生命，并将其身体部位的状态改善~lg~33%~/~。##此效果对友方亡灵的效果提高~lg~50%~/~。##给予目标~w~13~/~回合的~lg~“死亡祝福”~/~：##生命吸取~lg~+9%~/~#精力吸取~lg~+9%~/~#反伤~lg~+13%~/~"}
                }
            ),
            new LocalizationSkill(
                id: "Bw_Bolt",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Desecration"},
                    {ModLanguage.Russian, "Осквернение"},
                    {ModLanguage.Chinese, "亵渎"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Shoots a bolt of dark energy, dealing ~ur~/*Unholy_Damage*/ Unholy Damage~/~ with ~w~/*Hit_Chance*/%~/~ Accuracy.##If the spell hits the target, burns its Energy for the amount of damage dealt and replenishes the same amount of Energy to the caster.##Grants ~ur~/*Unholy_Damage2*/ Unholy Damage~/~ for ~w~12~/~ turns.##This effect doesn't stack."},
                    {ModLanguage.Chinese, @"射出一束黑暗能量，造成~ur~/*Unholy_Damage*/点邪术伤害~/~，准度~w~/*Hit_Chance*/%~/~。##如果咒法命中目标，则令其损耗精力，施法者自身恢复精力，两者数值均与咒法所造成的伤害相等。##为武器攻击附加~ur~/*Unholy_Damage2*/点邪术伤害~/~，持续~w~12~/~回合。##此效果不会叠加。"}
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
                    {ModLanguage.Chinese, @"令一个目标尸体复活，令其恢复生命上限~lg~66%~/~的生命和精力上限~bl~66%~/~的精力，并将其护甲耐久变为~w~0%~/~。##提升~lg~士气~/~（最多~w~75%~/~）。#缓慢降低~lg~神智~/~，但不低于~r~60%~/~。##~r~“痴迷”~/~的风险：~ur~高~/~#召唤多个亡灵会立即导致~r~“痴迷”~/~。##~r~无法~/~召唤高于~w~/*LEVL*/~/~级的亡灵。##~r~妨碍~/~接受~ly~“祝福”~/~。##在~r~“痴迷”~/~的影响下，这个咒法不能施放。"}
                }
            ),
            new LocalizationSkill(
                id: "Bw_Touch",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Death Touch"},
                    {ModLanguage.Russian, "Касание смерти"},
                    {ModLanguage.Chinese, "死亡之触"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Deals ~ur~/*Unholy_Damage*/ Unholy Damage~/~ wtih ~lg~/*I_C*/%~/~ Immobilization Chance.##Replenishes Health to all allies within Vision for ~lg~66%~/~ of the damage dealt by the spell."},
                    {ModLanguage.Chinese, @"造成~ur~/*Unholy_Damage*/ 点邪术伤害~/~，限制移动几率为~lg~/*I_C*/%~/~。##令视野内所有友方立刻恢复生命，恢复的幅度等于本次咒法伤害数值的~lg~66%~/~。"}
                }
            ),
            new LocalizationSkill(
                id: "Wraith_Binding",
                name: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, "Wraith Summoning"},
                    {ModLanguage.Russian, "Призыв умертвия"},
                    {ModLanguage.Chinese, "招魂"}
                },
                description: new Dictionary<ModLanguage, string>{
                    {ModLanguage.English, @"Summons a ~w~Wraith~/~ on the targeted tile. The ~w~Wraith's~/~ power depends on the number of ~lg~\""Essence Charge\""~/~ stacks.##Using the ability removes ~lg~\""Essence Charge\""~/~.##If there was no weapon equipped: grants the skill ~lg~-50%~/~ Cooldown Duration and ~lg~Halves~/~ Miscast Chance.##Risk of ~r~\""Obsession\""~/~: ~r~Extremely High~/~#Summoning more than one Wraith instantly causes ~r~\""Obsession\""~/~.##~r~Can't~/~ summon Wraiths higher than level ~w~/*LEVL*/~/~.##This spell cannot be cast while under the effect of ~r~\""Obsession\""~/~."},
                    {ModLanguage.Chinese, @"在目标方格召唤一个~w~幽魂~/~。这个~w~幽魂~/~的战力取决于~lg~“精魄蓄积”~/~的层数。##运用这项能力会移除~lg~“精魄蓄积”~/~。##如果没有装备武器：该技能冷却时间~lg~-50%~/~，失误几率~lg~减半~/~。##~r~“痴迷”~/~的风险：~r~极高~/~#召唤超过一个幽魂会立即导致~r~“痴迷”~/~。##~r~无法~/~召唤高于~w~/*LEVL*/~/~级的幽魂。##此咒法在~r~“痴迷”~/~下无法施放。"}
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
        string sealofpower_zh = "#~ur~死灵咒法：~/~法力~lg~+15%~/~，兵器伤害~lg~+12.5%~/~（这一部分加成为邪术伤害），所受伤害~lg~-5%~/~，冷却时间~lg~-5%~/~";

        foreach(string item in input)
        {
            if (item.Contains("\";skill_name_end"))
            {
                string newItem = item;
                newItem = newItem.Insert(newItem.IndexOf(@"##Произнесение заклинаний ~lb~искусства магии"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##Casting ~lb~Magic Mastery"), sealofpower_en);
                newItem = newItem.Insert(newItem.IndexOf(@"##催动~lb~“驭法”"), sealofpower_zh);
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