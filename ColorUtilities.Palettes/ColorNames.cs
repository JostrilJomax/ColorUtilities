using System;

namespace ColorUtilities {

public static class ColorNamesExtensions {

    public static Hex  ToHex(this ColorName colorName)  => ColorConverter.ToHex(colorName.ToRgb());
    public static Cmyk ToCmyk(this ColorName colorName) => ColorConverter.ToCmyk(colorName.ToRgb());
    public static Hsv  ToHsv(this ColorName colorName)  => ColorConverter.ToHsv(colorName.ToRgb());
    public static Hsl  ToHsl(this ColorName colorName)  => ColorConverter.ToHsl(colorName.ToRgb());
    public static CieXyz  ToXyz(this ColorName colorName)  => ColorConverter.ToCieXyz(colorName.ToRgb());
    public static Yiq  ToYiq(this ColorName colorName)  => ColorConverter.ToYiq(colorName.ToRgb());
    public static Yuv  ToYuv(this ColorName colorName)  => ColorConverter.ToYuv(colorName.ToRgb());

    public static Rgb ToRgb(this ColorName colorName)
    {
        switch (colorName) {
            case ColorName.AbsoluteZero:                        return new Rgb(0, 28, 73);
            case ColorName.AcidGreen:                           return new Rgb(69, 75, 10);
            case ColorName.Aero:                                return new Rgb(49, 73, 91);
            case ColorName.AeroBlue:                            return new Rgb(75, 91, 84);
            case ColorName.AfricanViolet:                       return new Rgb(70, 52, 75);
            case ColorName.AirSuperiorityBlue:                  return new Rgb(45, 63, 76);
            case ColorName.Alabaster:                           return new Rgb(93, 92, 88);
            case ColorName.AliceBlue:                           return new Rgb(94, 97, 100);
            case ColorName.AlloyOrange:                         return new Rgb(77, 38, 6);
            case ColorName.Almond:                              return new Rgb(94, 87, 80);
            case ColorName.Amaranth:                            return new Rgb(90, 17, 31);
            case ColorName.AmaranthPink:                        return new Rgb(95, 61, 73);
            case ColorName.AmaranthPurple:                      return new Rgb(67, 15, 31);
            case ColorName.AmaranthRed:                         return new Rgb(83, 13, 18);
            case ColorName.Amazon:                              return new Rgb(23, 48, 34);
            case ColorName.Amber:                               return new Rgb(100, 75, 0);
            case ColorName.Amethyst:                            return new Rgb(60, 40, 80);
            case ColorName.AndroidGreen:                        return new Rgb(24, 86, 53);
            case ColorName.AntiqueBrass:                        return new Rgb(80, 58, 46);
            case ColorName.AntiqueBronze:                       return new Rgb(40, 36, 12);
            case ColorName.AntiqueFuchsia:                      return new Rgb(57, 36, 51);
            case ColorName.AntiqueRuby:                         return new Rgb(52, 11, 18);
            case ColorName.AntiqueWhite:                        return new Rgb(98, 92, 84);
            case ColorName.AoEnglish:                           return new Rgb(0, 50, 0);
            case ColorName.AppleGreen:                          return new Rgb(55, 71, 0);
            case ColorName.Apricot:                             return new Rgb(98, 81, 69);
            case ColorName.Aqua:                                return new Rgb(0, 100, 100);
            case ColorName.Aquamarine:                          return new Rgb(50, 100, 83);
            case ColorName.ArcticLime:                          return new Rgb(82, 100, 8);
            case ColorName.ArmyGreen:                           return new Rgb(29, 33, 13);
            case ColorName.Artichoke:                           return new Rgb(56, 59, 47);
            case ColorName.ArylideYellow:                       return new Rgb(91, 84, 42);
            case ColorName.AshGray:                             return new Rgb(70, 75, 71);
            case ColorName.Asparagus:                           return new Rgb(53, 66, 42);
            case ColorName.AtomicTangerine:                     return new Rgb(100, 60, 40);
            case ColorName.Auburn:                              return new Rgb(65, 16, 16);
            case ColorName.Aureolin:                            return new Rgb(99, 93, 0);
            case ColorName.Avocado:                             return new Rgb(34, 51, 1);
            case ColorName.Azure:                               return new Rgb(0, 50, 100);
            case ColorName.BabyBlue:                            return new Rgb(54, 81, 94);
            case ColorName.BabyBlueEyes:                        return new Rgb(63, 79, 95);
            case ColorName.BabyPink:                            return new Rgb(96, 76, 76);
            case ColorName.BabyPowder:                          return new Rgb(100, 100, 98);
            case ColorName.BakerMillerPink:                     return new Rgb(255, 145, 175);
            case ColorName.BananaMania:                         return new Rgb(98, 91, 71);
            case ColorName.BarbiePink:                          return new Rgb(85, 9, 52);
            case ColorName.BarnRed:                             return new Rgb(49, 4, 1);
            case ColorName.BattleshipGrey:                      return new Rgb(52, 52, 51);
            case ColorName.BeauBlue:                            return new Rgb(74, 83, 90);
            case ColorName.Beaver:                              return new Rgb(62, 51, 44);
            case ColorName.Beige:                               return new Rgb(96, 96, 86);
            case ColorName.Bisque:                              return new Rgb(100, 89, 77);
            case ColorName.Bistre:                              return new Rgb(24, 17, 12);
            case ColorName.BistreBrown:                         return new Rgb(59, 44, 9);
            case ColorName.BitterLemon:                         return new Rgb(79, 88, 5);
            case ColorName.BitterLime:                          return new Rgb(75, 100, 0);
            case ColorName.Bittersweet:                         return new Rgb(100, 44, 37);
            case ColorName.BittersweetShimmer:                  return new Rgb(75, 31, 32);
            case ColorName.Black:                               return new Rgb(0, 0, 0);
            case ColorName.BlackBean:                           return new Rgb(24, 5, 1);
            case ColorName.BlackChocolate:                      return new Rgb(11, 9, 7);
            case ColorName.BlackCoffee:                         return new Rgb(23, 18, 18);
            case ColorName.BlackCoral:                          return new Rgb(33, 38, 44);
            case ColorName.BlackOlive:                          return new Rgb(23, 24, 21);
            case ColorName.BlackShadows:                        return new Rgb(75, 69, 70);
            case ColorName.BlanchedAlmond:                      return new Rgb(100, 92, 80);
            case ColorName.BlastOffBronze:                      return new Rgb(65, 44, 39);
            case ColorName.BleuDeFrance:                        return new Rgb(19, 55, 91);
            case ColorName.BlizzardBlue:                        return new Rgb(67, 90, 93);
            case ColorName.Blond:                               return new Rgb(98, 94, 75);
            case ColorName.BloodRed:                            return new Rgb(40, 0, 0);
            case ColorName.Blue:                                return new Rgb(0, 0, 100);
            case ColorName.BlueCrayola:                         return new Rgb(12, 46, 100);
            case ColorName.BlueMunsell:                         return new Rgb(0, 58, 69);
            case ColorName.BlueNCS:                             return new Rgb(0, 53, 74);
            case ColorName.BluePigment:                         return new Rgb(20, 20, 60);
            case ColorName.BlueRYB:                             return new Rgb(1, 28, 100);
            case ColorName.BlueBell:                            return new Rgb(64, 64, 82);
            case ColorName.BlueGray:                            return new Rgb(40, 60, 80);
            case ColorName.BlueGreen:                           return new Rgb(5, 60, 73);
            case ColorName.BlueGreenColorWheel:                 return new Rgb(2, 31, 25);
            case ColorName.BlueJeans:                           return new Rgb(36, 68, 93);
            case ColorName.BlueSapphire:                        return new Rgb(7, 38, 50);
            case ColorName.BlueViolet:                          return new Rgb(54, 17, 89);
            case ColorName.BlueVioletCrayola:                   return new Rgb(45, 40, 74);
            case ColorName.BlueVioletColorWheel:                return new Rgb(30, 10, 50);
            case ColorName.BlueYonder:                          return new Rgb(31, 45, 65);
            case ColorName.Bluetiful:                           return new Rgb(24, 41, 91);
            case ColorName.Blush:                               return new Rgb(87, 36, 51);
            case ColorName.Bole:                                return new Rgb(47, 27, 23);
            case ColorName.Bone:                                return new Rgb(89, 85, 79);
            case ColorName.BottleGreen:                         return new Rgb(0, 42, 31);
            case ColorName.Brandy:                              return new Rgb(53, 25, 25);
            case ColorName.BrickRed:                            return new Rgb(80, 25, 33);
            case ColorName.BrightGreen:                         return new Rgb(40, 100, 0);
            case ColorName.BrightLilac:                         return new Rgb(85, 57, 94);
            case ColorName.BrightMaroon:                        return new Rgb(76, 13, 28);
            case ColorName.BrightNavyBlue:                      return new Rgb(10, 45, 82);
            case ColorName.BrightYellowCrayola:                 return new Rgb(100, 67, 11);
            case ColorName.BrilliantRose:                       return new Rgb(100, 33, 64);
            case ColorName.BrinkPink:                           return new Rgb(98, 38, 50);
            case ColorName.BritishRacingGreen:                  return new Rgb(0, 26, 15);
            case ColorName.Bronze:                              return new Rgb(80, 50, 20);
            case ColorName.Brown:                               return new Rgb(53, 33, 4);
            case ColorName.BrownSugar:                          return new Rgb(69, 43, 30);
            case ColorName.BrunswickGreen:                      return new Rgb(11, 30, 24);
            case ColorName.BudGreen:                            return new Rgb(48, 71, 38);
            case ColorName.Buff:                                return new Rgb(100, 78, 50);
            case ColorName.Burgundy:                            return new Rgb(50, 0, 13);
            case ColorName.Burlywood:                           return new Rgb(87, 72, 53);
            case ColorName.BurnishedBrown:                      return new Rgb(63, 48, 45);
            case ColorName.BurntOrange:                         return new Rgb(80, 33, 0);
            case ColorName.BurntSienna:                         return new Rgb(91, 45, 32);
            case ColorName.BurntUmber:                          return new Rgb(54, 20, 14);
            case ColorName.Byzantine:                           return new Rgb(74, 20, 64);
            case ColorName.Byzantium:                           return new Rgb(44, 16, 39);
            case ColorName.Cadet:                               return new Rgb(33, 41, 45);
            case ColorName.CadetBlue:                           return new Rgb(37, 62, 63);
            case ColorName.CadetBlueCrayola:                    return new Rgb(66, 70, 76);
            case ColorName.CadetGrey:                           return new Rgb(57, 64, 69);
            case ColorName.CadmiumGreen:                        return new Rgb(0, 42, 24);
            case ColorName.CadmiumOrange:                       return new Rgb(93, 53, 18);
            case ColorName.CadmiumRed:                          return new Rgb(89, 0, 13);
            case ColorName.CadmiumYellow:                       return new Rgb(100, 96, 0);
            case ColorName.CafeAuLait:                          return new Rgb(65, 48, 36);
            case ColorName.CafeNoir:                            return new Rgb(29, 21, 13);
            case ColorName.CambridgeBlue:                       return new Rgb(64, 76, 68);
            case ColorName.Camel:                               return new Rgb(76, 60, 42);
            case ColorName.CameoPink:                           return new Rgb(94, 73, 80);
            case ColorName.Canary:                              return new Rgb(100, 100, 60);
            case ColorName.CanaryYellow:                        return new Rgb(100, 94, 0);
            case ColorName.CandyAppleRed:                       return new Rgb(100, 3, 0);
            case ColorName.CandyPink:                           return new Rgb(89, 44, 48);
            case ColorName.Capri:                               return new Rgb(0, 75, 100);
            case ColorName.CaputMortuum:                        return new Rgb(35, 15, 13);
            case ColorName.Cardinal:                            return new Rgb(77, 12, 23);
            case ColorName.CaribbeanGreen:                      return new Rgb(0, 80, 60);
            case ColorName.Carmine:                             return new Rgb(59, 0, 9);
            case ColorName.CarnationPink:                       return new Rgb(100, 65, 79);
            case ColorName.Carnelian:                           return new Rgb(70, 11, 11);
            case ColorName.CarolinaBlue:                        return new Rgb(34, 63, 83);
            case ColorName.CarrotOrange:                        return new Rgb(93, 57, 13);
            case ColorName.CastletonGreen:                      return new Rgb(0, 34, 25);
            case ColorName.Catawba:                             return new Rgb(44, 21, 26);
            case ColorName.CedarChest:                          return new Rgb(79, 35, 29);
            case ColorName.Celadon:                             return new Rgb(67, 88, 69);
            case ColorName.CeladonBlue:                         return new Rgb(0, 48, 65);
            case ColorName.CeladonGreen:                        return new Rgb(18, 52, 49);
            case ColorName.Celeste:                             return new Rgb(70, 100, 100);
            case ColorName.CelticBlue:                          return new Rgb(14, 42, 81);
            case ColorName.Cerise:                              return new Rgb(87, 19, 39);
            case ColorName.Cerulean:                            return new Rgb(0, 48, 65);
            case ColorName.CeruleanBlue:                        return new Rgb(16, 32, 75);
            case ColorName.CeruleanFrost:                       return new Rgb(43, 61, 76);
            case ColorName.CeruleanCrayola:                     return new Rgb(11, 67, 84);
            case ColorName.CGBlue:                              return new Rgb(0, 48, 65);
            case ColorName.CGRed:                               return new Rgb(88, 24, 19);
            case ColorName.Champagne:                           return new Rgb(97, 91, 81);
            case ColorName.ChampagnePink:                       return new Rgb(95, 87, 81);
            case ColorName.Charcoal:                            return new Rgb(21, 27, 31);
            case ColorName.CharlestonGreen:                     return new Rgb(14, 17, 17);
            case ColorName.CharmPink:                           return new Rgb(90, 56, 67);
            case ColorName.ChartreuseTraditional:               return new Rgb(87, 100, 0);
            case ColorName.ChartreuseWeb:                       return new Rgb(50, 100, 0);
            case ColorName.CherryBlossomPink:                   return new Rgb(100, 72, 77);
            case ColorName.Chestnut:                            return new Rgb(58, 27, 21);
            case ColorName.ChiliRed:                            return new Rgb(89, 24, 16);
            case ColorName.ChinaPink:                           return new Rgb(87, 44, 63);
            case ColorName.ChinaRose:                           return new Rgb(66, 32, 43);
            case ColorName.ChineseRed:                          return new Rgb(67, 22, 12);
            case ColorName.ChineseViolet:                       return new Rgb(52, 38, 53);
            case ColorName.ChineseYellow:                       return new Rgb(100, 70, 0);
            case ColorName.ChocolateTraditional:                return new Rgb(48, 25, 0);
            case ColorName.ChocolateWeb:                        return new Rgb(82, 41, 12);
            case ColorName.ChocolateCosmos:                     return new Rgb(35, 7, 10);
            case ColorName.ChromeYellow:                        return new Rgb(100, 65, 0);
            case ColorName.Cinereous:                           return new Rgb(60, 51, 48);
            case ColorName.Cinnabar:                            return new Rgb(89, 26, 20);
            case ColorName.CinnamonSatin:                       return new Rgb(80, 38, 49);
            case ColorName.Citrine:                             return new Rgb(89, 82, 4);
            case ColorName.Citron:                              return new Rgb(62, 66, 12);
            case ColorName.Claret:                              return new Rgb(50, 9, 20);
            case ColorName.CobaltBlue:                          return new Rgb(0, 28, 67);
            case ColorName.CocoaBrown:                          return new Rgb(82, 41, 12);
            case ColorName.Coffee:                              return new Rgb(44, 31, 22);
            case ColorName.ColumbiaBlue:                        return new Rgb(73, 85, 92);
            case ColorName.CongoPink:                           return new Rgb(97, 51, 47);
            case ColorName.CoolGrey:                            return new Rgb(55, 57, 67);
            case ColorName.Copper:                              return new Rgb(72, 45, 20);
            case ColorName.CopperCrayola:                       return new Rgb(85, 54, 40);
            case ColorName.CopperPenny:                         return new Rgb(68, 44, 41);
            case ColorName.CopperRed:                           return new Rgb(80, 43, 32);
            case ColorName.CopperRose:                          return new Rgb(60, 40, 40);
            case ColorName.Coquelicot:                          return new Rgb(100, 22, 0);
            case ColorName.Coral:                               return new Rgb(100, 50, 31);
            case ColorName.CoralPink:                           return new Rgb(97, 51, 47);
            case ColorName.Cordovan:                            return new Rgb(54, 25, 27);
            case ColorName.Corn:                                return new Rgb(98, 93, 36);
            case ColorName.CornellRed:                          return new Rgb(70, 11, 11);
            case ColorName.CornflowerBlue:                      return new Rgb(39, 58, 93);
            case ColorName.Cornsilk:                            return new Rgb(100, 97, 86);
            case ColorName.CosmicCobalt:                        return new Rgb(18, 18, 53);
            case ColorName.CosmicLatte:                         return new Rgb(100, 97, 91);
            case ColorName.CoyoteBrown:                         return new Rgb(51, 38, 24);
            case ColorName.CottonCandy:                         return new Rgb(100, 74, 85);
            case ColorName.Cream:                               return new Rgb(100, 99, 82);
            case ColorName.Crimson:                             return new Rgb(86, 8, 24);
            case ColorName.CrimsonUA:                           return new Rgb(62, 11, 20);
            case ColorName.Crystal:                             return new Rgb(65, 85, 87);
            case ColorName.Cultured:                            return new Rgb(96, 96, 96);
            case ColorName.Cyan:                                return new Rgb(0, 100, 100);
            case ColorName.CyanProcess:                         return new Rgb(0, 72, 92);
            case ColorName.CyberGrape:                          return new Rgb(35, 26, 49);
            case ColorName.CyberYellow:                         return new Rgb(100, 83, 0);
            case ColorName.Cyclamen:                            return new Rgb(96, 44, 63);
            case ColorName.DarkBlueGray:                        return new Rgb(40, 40, 60);
            case ColorName.DarkBrown:                           return new Rgb(40, 26, 13);
            case ColorName.DarkByzantium:                       return new Rgb(36, 22, 33);
            case ColorName.DarkCornflowerBlue:                  return new Rgb(15, 26, 55);
            case ColorName.DarkCyan:                            return new Rgb(0, 55, 55);
            case ColorName.DarkElectricBlue:                    return new Rgb(33, 41, 47);
            case ColorName.DarkGoldenrod:                       return new Rgb(72, 53, 4);
            case ColorName.DarkGreen:                           return new Rgb(0, 20, 13);
            case ColorName.DarkJungleGreen:                     return new Rgb(10, 14, 13);
            case ColorName.DarkKhaki:                           return new Rgb(74, 72, 42);
            case ColorName.DarkLava:                            return new Rgb(28, 24, 20);
            case ColorName.DarkLiver:                           return new Rgb(33, 29, 31);
            case ColorName.DarkLiverHorses:                     return new Rgb(33, 24, 22);
            case ColorName.DarkMagenta:                         return new Rgb(55, 0, 55);
            case ColorName.DarkMossGreen:                       return new Rgb(29, 36, 14);
            case ColorName.DarkOliveGreen:                      return new Rgb(33, 42, 18);
            case ColorName.DarkOrange:                          return new Rgb(100, 55, 0);
            case ColorName.DarkOrchid:                          return new Rgb(60, 20, 80);
            case ColorName.DarkPastelGreen:                     return new Rgb(1, 75, 24);
            case ColorName.DarkPurple:                          return new Rgb(19, 10, 20);
            case ColorName.DarkRed:                             return new Rgb(55, 0, 0);
            case ColorName.DarkSalmon:                          return new Rgb(91, 59, 48);
            case ColorName.DarkSeaGreen:                        return new Rgb(56, 74, 56);
            case ColorName.DarkSienna:                          return new Rgb(24, 8, 8);
            case ColorName.DarkSkyBlue:                         return new Rgb(55, 75, 84);
            case ColorName.DarkSlateBlue:                       return new Rgb(28, 24, 55);
            case ColorName.DarkSlateGray:                       return new Rgb(18, 31, 31);
            case ColorName.DarkSpringGreen:                     return new Rgb(9, 45, 27);
            case ColorName.DarkTurquoise:                       return new Rgb(0, 81, 82);
            case ColorName.DarkViolet:                          return new Rgb(58, 0, 83);
            case ColorName.DartmouthGreen:                      return new Rgb(0, 44, 24);
            case ColorName.DeepCerise:                          return new Rgb(85, 20, 53);
            case ColorName.DeepChampagne:                       return new Rgb(98, 84, 65);
            case ColorName.DeepChestnut:                        return new Rgb(73, 31, 28);
            case ColorName.DeepJungleGreen:                     return new Rgb(0, 29, 29);
            case ColorName.DeepPink:                            return new Rgb(100, 8, 58);
            case ColorName.DeepSaffron:                         return new Rgb(100, 60, 20);
            case ColorName.DeepSkyBlue:                         return new Rgb(0, 75, 100);
            case ColorName.DeepSpaceSparkle:                    return new Rgb(29, 39, 42);
            case ColorName.DeepTaupe:                           return new Rgb(49, 37, 38);
            case ColorName.Denim:                               return new Rgb(8, 38, 74);
            case ColorName.DenimBlue:                           return new Rgb(13, 26, 71);
            case ColorName.Desert:                              return new Rgb(76, 60, 42);
            case ColorName.DesertSand:                          return new Rgb(93, 79, 69);
            case ColorName.DimGray:                             return new Rgb(41, 41, 41);
            case ColorName.DodgerBlue:                          return new Rgb(12, 56, 100);
            case ColorName.DogwoodRose:                         return new Rgb(84, 9, 41);
            case ColorName.Drab:                                return new Rgb(59, 44, 9);
            case ColorName.DukeBlue:                            return new Rgb(0, 0, 61);
            case ColorName.DutchWhite:                          return new Rgb(94, 87, 73);
            case ColorName.EarthYellow:                         return new Rgb(88, 66, 37);
            case ColorName.Ebony:                               return new Rgb(33, 36, 31);
            case ColorName.Ecru:                                return new Rgb(76, 70, 50);
            case ColorName.EerieBlack:                          return new Rgb(11, 11, 11);
            case ColorName.Eggplant:                            return new Rgb(38, 25, 32);
            case ColorName.Eggshell:                            return new Rgb(94, 92, 84);
            case ColorName.EgyptianBlue:                        return new Rgb(6, 20, 65);
            case ColorName.Eigengrau:                           return new Rgb(9, 9, 11);
            case ColorName.ElectricBlue:                        return new Rgb(49, 98, 100);
            case ColorName.ElectricGreen:                       return new Rgb(0, 100, 0);
            case ColorName.ElectricIndigo:                      return new Rgb(44, 0, 100);
            case ColorName.ElectricLime:                        return new Rgb(80, 100, 0);
            case ColorName.ElectricPurple:                      return new Rgb(75, 0, 100);
            case ColorName.ElectricViolet:                      return new Rgb(56, 0, 100);
            case ColorName.Emerald:                             return new Rgb(31, 78, 47);
            case ColorName.Eminence:                            return new Rgb(42, 19, 51);
            case ColorName.EnglishGreen:                        return new Rgb(11, 30, 24);
            case ColorName.EnglishLavender:                     return new Rgb(71, 51, 58);
            case ColorName.EnglishRed:                          return new Rgb(67, 29, 32);
            case ColorName.EnglishVermillion:                   return new Rgb(80, 28, 29);
            case ColorName.EnglishViolet:                       return new Rgb(34, 24, 36);
            case ColorName.Erin:                                return new Rgb(0, 100, 25);
            case ColorName.EtonBlue:                            return new Rgb(59, 78, 64);
            case ColorName.Fallow:                              return new Rgb(76, 60, 42);
            case ColorName.FaluRed:                             return new Rgb(50, 9, 9);
            case ColorName.Fandango:                            return new Rgb(71, 20, 54);
            case ColorName.FandangoPink:                        return new Rgb(87, 32, 52);
            case ColorName.FashionFuchsia:                      return new Rgb(96, 0, 63);
            case ColorName.Fawn:                                return new Rgb(90, 67, 44);
            case ColorName.Feldgrau:                            return new Rgb(30, 36, 33);
            case ColorName.FernGreen:                           return new Rgb(31, 47, 26);
            case ColorName.FieldDrab:                           return new Rgb(42, 33, 12);
            case ColorName.FieryRose:                           return new Rgb(100, 33, 44);
            case ColorName.Firebrick:                           return new Rgb(70, 13, 13);
            case ColorName.FireEngineRed:                       return new Rgb(81, 13, 16);
            case ColorName.FireOpal:                            return new Rgb(91, 36, 29);
            case ColorName.Flame:                               return new Rgb(89, 35, 13);
            case ColorName.Flax:                                return new Rgb(93, 86, 51);
            case ColorName.Flirt:                               return new Rgb(64, 0, 43);
            case ColorName.FloralWhite:                         return new Rgb(100, 98, 94);
            case ColorName.FluorescentBlue:                     return new Rgb(8, 96, 93);
            case ColorName.ForestGreenCrayola:                  return new Rgb(37, 65, 47);
            case ColorName.ForestGreenTraditional:              return new Rgb(0, 27, 13);
            case ColorName.ForestGreenWeb:                      return new Rgb(13, 55, 13);
            case ColorName.FrenchBeige:                         return new Rgb(65, 48, 36);
            case ColorName.FrenchBistre:                        return new Rgb(52, 43, 30);
            case ColorName.FrenchBlue:                          return new Rgb(0, 45, 73);
            case ColorName.FrenchFuchsia:                       return new Rgb(99, 25, 57);
            case ColorName.FrenchLilac:                         return new Rgb(53, 38, 56);
            case ColorName.FrenchLime:                          return new Rgb(62, 99, 22);
            case ColorName.FrenchMauve:                         return new Rgb(83, 45, 83);
            case ColorName.FrenchPink:                          return new Rgb(99, 42, 62);
            case ColorName.FrenchRaspberry:                     return new Rgb(78, 17, 28);
            case ColorName.FrenchRose:                          return new Rgb(96, 29, 54);
            case ColorName.FrenchSkyBlue:                       return new Rgb(47, 71, 100);
            case ColorName.FrenchViolet:                        return new Rgb(53, 2, 81);
            case ColorName.Frostbite:                           return new Rgb(91, 21, 65);
            case ColorName.Fuchsia:                             return new Rgb(100, 0, 100);
            case ColorName.FuchsiaCrayola:                      return new Rgb(76, 33, 76);
            case ColorName.FuchsiaPurple:                       return new Rgb(80, 22, 48);
            case ColorName.FuchsiaRose:                         return new Rgb(78, 26, 46);
            case ColorName.Fulvous:                             return new Rgb(89, 52, 0);
            case ColorName.FuzzyWuzzy:                          return new Rgb(53, 26, 12);
            case ColorName.Gainsboro:                           return new Rgb(86, 86, 86);
            case ColorName.Gamboge:                             return new Rgb(89, 61, 6);
            case ColorName.GenericViridian:                     return new Rgb(0, 50, 40);
            case ColorName.GhostWhite:                          return new Rgb(97, 97, 100);
            case ColorName.Glaucous:                            return new Rgb(38, 51, 71);
            case ColorName.GlossyGrape:                         return new Rgb(67, 57, 70);
            case ColorName.GOGreen:                             return new Rgb(0, 67, 40);
            case ColorName.Gold:                                return new Rgb(65, 49, 0);
            case ColorName.GoldMetallic:                        return new Rgb(83, 69, 22);
            case ColorName.GoldWebGolden:                       return new Rgb(100, 84, 0);
            case ColorName.GoldCrayola:                         return new Rgb(90, 75, 54);
            case ColorName.GoldFusion:                          return new Rgb(52, 46, 31);
            case ColorName.GoldenBrown:                         return new Rgb(60, 40, 8);
            case ColorName.GoldenPoppy:                         return new Rgb(99, 76, 0);
            case ColorName.GoldenYellow:                        return new Rgb(100, 87, 0);
            case ColorName.Goldenrod:                           return new Rgb(85, 65, 13);
            case ColorName.GraniteGray:                         return new Rgb(40, 40, 40);
            case ColorName.GrannySmithApple:                    return new Rgb(66, 89, 63);
            case ColorName.GrayWeb:                             return new Rgb(50, 50, 50);
            case ColorName.Green:                               return new Rgb(0, 100, 0);
            case ColorName.GreenCrayola:                        return new Rgb(11, 67, 47);
            case ColorName.GreenWeb:                            return new Rgb(0, 50, 0);
            case ColorName.GreenMunsell:                        return new Rgb(0, 66, 47);
            case ColorName.GreenPigment:                        return new Rgb(0, 65, 31);
            case ColorName.GreenBlue:                           return new Rgb(7, 39, 71);
            case ColorName.GreenBlueCrayola:                    return new Rgb(16, 53, 78);
            case ColorName.GreenCyan:                           return new Rgb(0, 60, 40);
            case ColorName.GreenLizard:                         return new Rgb(65, 96, 20);
            case ColorName.GreenSheen:                          return new Rgb(43, 68, 63);
            case ColorName.GreenYellow:                         return new Rgb(68, 100, 18);
            case ColorName.GreenYellowCrayola:                  return new Rgb(94, 91, 57);
            case ColorName.Grullo:                              return new Rgb(66, 60, 53);
            case ColorName.Gunmetal:                            return new Rgb(16, 20, 22);
            case ColorName.HanBlue:                             return new Rgb(27, 42, 81);
            case ColorName.HanPurple:                           return new Rgb(32, 9, 98);
            case ColorName.HansaYellow:                         return new Rgb(91, 84, 42);
            case ColorName.Harlequin:                           return new Rgb(25, 100, 0);
            case ColorName.HarvestGold:                         return new Rgb(85, 57, 0);
            case ColorName.HeatWave:                            return new Rgb(100, 48, 0);
            case ColorName.Heliotrope:                          return new Rgb(87, 45, 100);
            case ColorName.HeliotropeGray:                      return new Rgb(67, 60, 66);
            case ColorName.HollywoodCerise:                     return new Rgb(96, 0, 63);
            case ColorName.Honeydew:                            return new Rgb(94, 100, 94);
            case ColorName.HonoluluBlue:                        return new Rgb(0, 43, 69);
            case ColorName.HotMagenta:                          return new Rgb(100, 11, 81);
            case ColorName.HotPink:                             return new Rgb(100, 41, 71);
            case ColorName.HunterGreen:                         return new Rgb(21, 37, 23);
            case ColorName.Iceberg:                             return new Rgb(44, 65, 82);
            case ColorName.Icterine:                            return new Rgb(99, 97, 37);
            case ColorName.IlluminatingEmerald:                 return new Rgb(19, 57, 47);
            case ColorName.ImperialRed:                         return new Rgb(93, 16, 22);
            case ColorName.Inchworm:                            return new Rgb(70, 93, 36);
            case ColorName.Independence:                        return new Rgb(30, 32, 43);
            case ColorName.IndiaGreen:                          return new Rgb(7, 53, 3);
            case ColorName.IndianRed:                           return new Rgb(80, 36, 36);
            case ColorName.IndianYellow:                        return new Rgb(89, 66, 34);
            case ColorName.Indigo:                              return new Rgb(29, 0, 51);
            case ColorName.IndigoDye:                           return new Rgb(0, 25, 42);
            case ColorName.InternationalKleinBlue:              return new Rgb(7, 4, 56);
            case ColorName.InternationalOrangeAerospace:        return new Rgb(100, 31, 0);
            case ColorName.InternationalOrangeEngineering:      return new Rgb(73, 9, 5);
            case ColorName.InternationalOrangeGoldenGateBridge: return new Rgb(75, 21, 17);
            case ColorName.Iris:                                return new Rgb(35, 31, 81);
            case ColorName.Irresistible:                        return new Rgb(70, 27, 42);
            case ColorName.Isabelline:                          return new Rgb(96, 94, 93);
            case ColorName.ItalianSkyBlue:                      return new Rgb(70, 100, 100);
            case ColorName.Ivory:                               return new Rgb(100, 100, 94);
            case ColorName.Jade:                                return new Rgb(0, 66, 42);
            case ColorName.JapaneseCarmine:                     return new Rgb(62, 16, 20);
            case ColorName.JapaneseViolet:                      return new Rgb(36, 20, 34);
            case ColorName.Jasmine:                             return new Rgb(97, 87, 49);
            case ColorName.JazzberryJam:                        return new Rgb(65, 4, 37);
            case ColorName.Jet:                                 return new Rgb(20, 20, 20);
            case ColorName.Jonquil:                             return new Rgb(96, 79, 9);
            case ColorName.JuneBud:                             return new Rgb(74, 85, 34);
            case ColorName.JungleGreen:                         return new Rgb(16, 67, 53);
            case ColorName.KellyGreen:                          return new Rgb(30, 73, 9);
            case ColorName.Keppel:                              return new Rgb(23, 69, 62);
            case ColorName.KeyLime:                             return new Rgb(91, 96, 55);
            case ColorName.KhakiWeb:                            return new Rgb(76, 69, 57);
            case ColorName.Kobe:                                return new Rgb(53, 18, 9);
            case ColorName.Kobi:                                return new Rgb(91, 62, 77);
            case ColorName.Kobicha:                             return new Rgb(42, 27, 14);
            case ColorName.KombuGreen:                          return new Rgb(21, 26, 19);
            case ColorName.KSUPurple:                           return new Rgb(31, 15, 51);
            case ColorName.LanguidLavender:                     return new Rgb(84, 79, 87);
            case ColorName.LapisLazuli:                         return new Rgb(15, 38, 61);
            case ColorName.LaserLemon:                          return new Rgb(100, 100, 40);
            case ColorName.LaurelGreen:                         return new Rgb(66, 73, 62);
            case ColorName.Lava:                                return new Rgb(81, 6, 13);
            case ColorName.LavenderFloral:                      return new Rgb(71, 49, 86);
            case ColorName.LavenderWeb:                         return new Rgb(90, 90, 98);
            case ColorName.LavenderBlue:                        return new Rgb(80, 80, 100);
            case ColorName.LavenderBlush:                       return new Rgb(100, 94, 96);
            case ColorName.LavenderGray:                        return new Rgb(77, 76, 82);
            case ColorName.LawnGreen:                           return new Rgb(49, 99, 0);
            case ColorName.Lemon:                               return new Rgb(100, 97, 0);
            case ColorName.LemonChiffon:                        return new Rgb(100, 98, 80);
            case ColorName.LemonCurry:                          return new Rgb(80, 63, 11);
            case ColorName.LemonGlacier:                        return new Rgb(99, 100, 0);
            case ColorName.LemonMeringue:                       return new Rgb(96, 92, 75);
            case ColorName.LemonYellow:                         return new Rgb(100, 96, 31);
            case ColorName.LemonYellowCrayola:                  return new Rgb(100, 100, 62);
            case ColorName.Liberty:                             return new Rgb(33, 35, 65);
            case ColorName.LightBlue:                           return new Rgb(68, 85, 90);
            case ColorName.LightCoral:                          return new Rgb(94, 50, 50);
            case ColorName.LightCornflowerBlue:                 return new Rgb(58, 80, 92);
            case ColorName.LightCyan:                           return new Rgb(88, 100, 100);
            case ColorName.LightFrenchBeige:                    return new Rgb(78, 68, 50);
            case ColorName.LightGoldenrodYellow:                return new Rgb(98, 98, 82);
            case ColorName.LightGray:                           return new Rgb(83, 83, 83);
            case ColorName.LightGreen:                          return new Rgb(56, 93, 56);
            case ColorName.LightOrange:                         return new Rgb(100, 85, 69);
            case ColorName.LightPeriwinkle:                     return new Rgb(77, 80, 88);
            case ColorName.LightPink:                           return new Rgb(100, 71, 76);
            case ColorName.LightSalmon:                         return new Rgb(100, 63, 48);
            case ColorName.LightSeaGreen:                       return new Rgb(13, 70, 67);
            case ColorName.LightSkyBlue:                        return new Rgb(53, 81, 98);
            case ColorName.LightSlateGray:                      return new Rgb(47, 53, 60);
            case ColorName.LightSteelBlue:                      return new Rgb(69, 77, 87);
            case ColorName.LightYellow:                         return new Rgb(100, 100, 88);
            case ColorName.Lilac:                               return new Rgb(78, 64, 78);
            case ColorName.LilacLuster:                         return new Rgb(68, 60, 67);
            case ColorName.LimeColorWheel:                      return new Rgb(75, 100, 0);
            case ColorName.LimeGreen:                           return new Rgb(20, 80, 20);
            case ColorName.LincolnGreen:                        return new Rgb(10, 35, 2);
            case ColorName.Linen:                               return new Rgb(98, 94, 90);
            case ColorName.Lion:                                return new Rgb(76, 60, 42);
            case ColorName.LiseranPurple:                       return new Rgb(87, 44, 63);
            case ColorName.LittleBoyBlue:                       return new Rgb(42, 63, 86);
            case ColorName.Liver:                               return new Rgb(40, 30, 28);
            case ColorName.LiverDogs:                           return new Rgb(72, 43, 16);
            case ColorName.LiverOrgan:                          return new Rgb(42, 18, 12);
            case ColorName.LiverChestnut:                       return new Rgb(60, 45, 34);
            case ColorName.Livid:                               return new Rgb(40, 60, 80);
            case ColorName.MacaroniAndCheese:                   return new Rgb(100, 74, 53);
            case ColorName.MadderLake:                          return new Rgb(80, 20, 21);
            case ColorName.Magenta:                             return new Rgb(100, 0, 100);
            case ColorName.MagentaCrayola:                      return new Rgb(96, 33, 65);
            case ColorName.MagentaDye:                          return new Rgb(79, 12, 48);
            case ColorName.MagentaProcess:                      return new Rgb(100, 0, 56);
            case ColorName.MagentaHaze:                         return new Rgb(62, 27, 46);
            case ColorName.MagicMint:                           return new Rgb(67, 94, 82);
            case ColorName.Magnolia:                            return new Rgb(95, 91, 84);
            case ColorName.Mahogany:                            return new Rgb(75, 25, 0);
            case ColorName.Maize:                               return new Rgb(98, 93, 36);
            case ColorName.MaizeCrayola:                        return new Rgb(95, 78, 29);
            case ColorName.MajorelleBlue:                       return new Rgb(38, 31, 86);
            case ColorName.Malachite:                           return new Rgb(4, 85, 32);
            case ColorName.Manatee:                             return new Rgb(59, 60, 67);
            case ColorName.Mandarin:                            return new Rgb(95, 48, 28);
            case ColorName.Mango:                               return new Rgb(99, 75, 1);
            case ColorName.MangoTango:                          return new Rgb(100, 51, 26);
            case ColorName.Mantis:                              return new Rgb(45, 76, 40);
            case ColorName.MardiGras:                           return new Rgb(53, 0, 52);
            case ColorName.Marigold:                            return new Rgb(92, 64, 13);
            case ColorName.MaroonCrayola:                       return new Rgb(76, 13, 28);
            case ColorName.MaroonWeb:                           return new Rgb(50, 0, 0);
            case ColorName.Mauve:                               return new Rgb(88, 69, 100);
            case ColorName.MauveTaupe:                          return new Rgb(57, 37, 43);
            case ColorName.Mauvelous:                           return new Rgb(94, 60, 67);
            case ColorName.MaximumBlue:                         return new Rgb(28, 67, 80);
            case ColorName.MaximumBlueGreen:                    return new Rgb(19, 75, 75);
            case ColorName.MaximumBluePurple:                   return new Rgb(67, 67, 90);
            case ColorName.MaximumGreen:                        return new Rgb(37, 55, 19);
            case ColorName.MaximumGreenYellow:                  return new Rgb(85, 90, 31);
            case ColorName.MaximumPurple:                       return new Rgb(45, 20, 50);
            case ColorName.MaximumRed:                          return new Rgb(85, 13, 13);
            case ColorName.MaximumRedPurple:                    return new Rgb(65, 23, 47);
            case ColorName.MaximumYellow:                       return new Rgb(98, 98, 22);
            case ColorName.MaximumYellowRed:                    return new Rgb(95, 73, 29);
            case ColorName.MayGreen:                            return new Rgb(30, 57, 25);
            case ColorName.MayaBlue:                            return new Rgb(45, 76, 98);
            case ColorName.MediumAquamarine:                    return new Rgb(40, 87, 67);
            case ColorName.MediumBlue:                          return new Rgb(0, 0, 80);
            case ColorName.MediumCandyAppleRed:                 return new Rgb(89, 2, 17);
            case ColorName.MediumCarmine:                       return new Rgb(69, 25, 21);
            case ColorName.MediumChampagne:                     return new Rgb(95, 90, 67);
            case ColorName.MediumOrchid:                        return new Rgb(73, 33, 83);
            case ColorName.MediumPurple:                        return new Rgb(58, 44, 86);
            case ColorName.MediumSeaGreen:                      return new Rgb(24, 70, 44);
            case ColorName.MediumSlateBlue:                     return new Rgb(48, 41, 93);
            case ColorName.MediumSpringGreen:                   return new Rgb(0, 98, 60);
            case ColorName.MediumTurquoise:                     return new Rgb(28, 82, 80);
            case ColorName.MediumVioletRed:                     return new Rgb(78, 8, 52);
            case ColorName.MellowApricot:                       return new Rgb(97, 72, 47);
            case ColorName.MellowYellow:                        return new Rgb(97, 87, 49);
            case ColorName.Melon:                               return new Rgb(100, 73, 68);
            case ColorName.MetallicGold:                        return new Rgb(83, 69, 22);
            case ColorName.MetallicSeaweed:                     return new Rgb(4, 49, 55);
            case ColorName.MetallicSunburst:                    return new Rgb(61, 49, 22);
            case ColorName.MexicanPink:                         return new Rgb(89, 0, 49);
            case ColorName.MiddleBlue:                          return new Rgb(49, 83, 90);
            case ColorName.MiddleBlueGreen:                     return new Rgb(55, 85, 80);
            case ColorName.MiddleBluePurple:                    return new Rgb(55, 45, 75);
            case ColorName.MiddleGrey:                          return new Rgb(55, 53, 50);
            case ColorName.MiddleGreen:                         return new Rgb(30, 55, 34);
            case ColorName.MiddleGreenYellow:                   return new Rgb(67, 75, 38);
            case ColorName.MiddlePurple:                        return new Rgb(85, 51, 71);
            case ColorName.MiddleRed:                           return new Rgb(90, 56, 45);
            case ColorName.MiddleRedPurple:                     return new Rgb(65, 33, 33);
            case ColorName.MiddleYellow:                        return new Rgb(100, 92, 0);
            case ColorName.MiddleYellowRed:                     return new Rgb(93, 69, 46);
            case ColorName.Midnight:                            return new Rgb(44, 15, 44);
            case ColorName.MidnightBlue:                        return new Rgb(10, 10, 44);
            case ColorName.MidnightGreenEagleGreen:             return new Rgb(0, 29, 33);
            case ColorName.MikadoYellow:                        return new Rgb(100, 77, 5);
            case ColorName.MimiPink:                            return new Rgb(100, 85, 91);
            case ColorName.Mindaro:                             return new Rgb(89, 98, 53);
            case ColorName.Ming:                                return new Rgb(21, 45, 49);
            case ColorName.MinionYellow:                        return new Rgb(96, 86, 31);
            case ColorName.Mint:                                return new Rgb(24, 71, 54);
            case ColorName.MintCream:                           return new Rgb(96, 100, 98);
            case ColorName.MintGreen:                           return new Rgb(60, 100, 60);
            case ColorName.MistyMoss:                           return new Rgb(73, 71, 47);
            case ColorName.MistyRose:                           return new Rgb(100, 89, 88);
            case ColorName.ModeBeige:                           return new Rgb(59, 44, 9);
            case ColorName.MorningBlue:                         return new Rgb(55, 64, 60);
            case ColorName.MossGreen:                           return new Rgb(54, 60, 36);
            case ColorName.MountainMeadow:                      return new Rgb(19, 73, 56);
            case ColorName.MountbattenPink:                     return new Rgb(60, 48, 55);
            case ColorName.MSUGreen:                            return new Rgb(9, 27, 23);
            case ColorName.Mulberry:                            return new Rgb(77, 29, 55);
            case ColorName.MulberryCrayola:                     return new Rgb(78, 31, 61);
            case ColorName.Mustard:                             return new Rgb(100, 86, 35);
            case ColorName.MyrtleGreen:                         return new Rgb(19, 47, 45);
            case ColorName.Mystic:                              return new Rgb(84, 32, 51);
            case ColorName.MysticMaroon:                        return new Rgb(68, 26, 47);
            case ColorName.NadeshikoPink:                       return new Rgb(96, 68, 78);
            case ColorName.NaplesYellow:                        return new Rgb(98, 85, 37);
            case ColorName.NavajoWhite:                         return new Rgb(100, 87, 68);
            case ColorName.NavyBlue:                            return new Rgb(0, 0, 50);
            case ColorName.NavyBlueCrayola:                     return new Rgb(10, 45, 82);
            case ColorName.NeonBlue:                            return new Rgb(27, 40, 100);
            case ColorName.NeonCarrot:                          return new Rgb(100, 64, 26);
            case ColorName.NeonGreen:                           return new Rgb(22, 100, 8);
            case ColorName.NeonFuchsia:                         return new Rgb(100, 25, 39);
            case ColorName.NewYorkPink:                         return new Rgb(84, 51, 50);
            case ColorName.Nickel:                              return new Rgb(45, 45, 45);
            case ColorName.NonPhotoBlue:                        return new Rgb(64, 87, 93);
            case ColorName.Nyanza:                              return new Rgb(91, 100, 86);
            case ColorName.OceanBlue:                           return new Rgb(31, 26, 71);
            case ColorName.OceanGreen:                          return new Rgb(28, 75, 57);
            case ColorName.Ochre:                               return new Rgb(80, 47, 13);
            case ColorName.OldBurgundy:                         return new Rgb(26, 19, 18);
            case ColorName.OldGold:                             return new Rgb(81, 71, 23);
            case ColorName.OldLace:                             return new Rgb(99, 96, 90);
            case ColorName.OldLavender:                         return new Rgb(47, 41, 47);
            case ColorName.OldMauve:                            return new Rgb(40, 19, 28);
            case ColorName.OldRose:                             return new Rgb(75, 50, 51);
            case ColorName.OldSilver:                           return new Rgb(52, 52, 51);
            case ColorName.Olive:                               return new Rgb(50, 50, 0);
            case ColorName.OliveGreen:                          return new Rgb(71, 70, 36);
            case ColorName.Olivine:                             return new Rgb(60, 73, 45);
            case ColorName.Onyx:                                return new Rgb(21, 22, 22);
            case ColorName.Opal:                                return new Rgb(66, 76, 74);
            case ColorName.OperaMauve:                          return new Rgb(72, 52, 65);
            case ColorName.Orange:                              return new Rgb(100, 50, 0);
            case ColorName.OrangeCrayola:                       return new Rgb(100, 46, 22);
            case ColorName.OrangeWeb:                           return new Rgb(100, 65, 0);
            case ColorName.OrangePeel:                          return new Rgb(100, 62, 0);
            case ColorName.OrangeRed:                           return new Rgb(100, 41, 12);
            case ColorName.OrangeRedCrayola:                    return new Rgb(100, 33, 29);
            case ColorName.OrangeSoda:                          return new Rgb(98, 36, 24);
            case ColorName.OrangeYellow:                        return new Rgb(96, 74, 12);
            case ColorName.OrangeYellowCrayola:                 return new Rgb(97, 84, 41);
            case ColorName.Orchid:                              return new Rgb(85, 44, 84);
            case ColorName.OrchidPink:                          return new Rgb(95, 74, 80);
            case ColorName.OrchidCrayola:                       return new Rgb(89, 61, 82);
            case ColorName.OuterSpaceCrayola:                   return new Rgb(18, 22, 23);
            case ColorName.OutrageousOrange:                    return new Rgb(100, 43, 29);
            case ColorName.Oxblood:                             return new Rgb(29, 0, 0);
            case ColorName.OxfordBlue:                          return new Rgb(0, 13, 28);
            case ColorName.OUCrimsonRed:                        return new Rgb(52, 9, 9);
            case ColorName.PacificBlue:                         return new Rgb(11, 66, 79);
            case ColorName.PakistanGreen:                       return new Rgb(0, 40, 0);
            case ColorName.PalatinatePurple:                    return new Rgb(41, 16, 38);
            case ColorName.PaleAqua:                            return new Rgb(74, 83, 90);
            case ColorName.PaleCerulean:                        return new Rgb(61, 77, 89);
            case ColorName.PaleDogwood:                         return new Rgb(93, 48, 61);
            case ColorName.PalePink:                            return new Rgb(98, 85, 87);
            case ColorName.PaleSilver:                          return new Rgb(79, 75, 73);
            case ColorName.PaleSpringBud:                       return new Rgb(93, 92, 74);
            case ColorName.PansyPurple:                         return new Rgb(47, 9, 29);
            case ColorName.PaoloVeroneseGreen:                  return new Rgb(0, 61, 49);
            case ColorName.PapayaWhip:                          return new Rgb(100, 94, 84);
            case ColorName.ParadisePink:                        return new Rgb(90, 24, 38);
            case ColorName.Parchment:                           return new Rgb(95, 91, 82);
            case ColorName.ParisGreen:                          return new Rgb(31, 78, 47);
            case ColorName.PastelPink:                          return new Rgb(87, 65, 64);
            case ColorName.Patriarch:                           return new Rgb(50, 0, 50);
            case ColorName.Peach:                               return new Rgb(100, 90, 71);
            case ColorName.PeachCrayola:                        return new Rgb(100, 80, 64);
            case ColorName.PeachPuff:                           return new Rgb(100, 85, 73);
            case ColorName.Pear:                                return new Rgb(82, 89, 19);
            case ColorName.PearlyPurple:                        return new Rgb(72, 41, 64);
            case ColorName.Periwinkle:                          return new Rgb(80, 80, 100);
            case ColorName.PeriwinkleCrayola:                   return new Rgb(76, 80, 90);
            case ColorName.PermanentGeraniumLake:               return new Rgb(88, 17, 17);
            case ColorName.PersianBlue:                         return new Rgb(11, 22, 73);
            case ColorName.PersianGreen:                        return new Rgb(0, 65, 58);
            case ColorName.PersianIndigo:                       return new Rgb(20, 7, 48);
            case ColorName.PersianOrange:                       return new Rgb(85, 56, 35);
            case ColorName.PersianPink:                         return new Rgb(97, 50, 75);
            case ColorName.PersianPlum:                         return new Rgb(44, 11, 11);
            case ColorName.PersianRed:                          return new Rgb(80, 20, 20);
            case ColorName.PersianRose:                         return new Rgb(100, 16, 64);
            case ColorName.Persimmon:                           return new Rgb(93, 35, 0);
            case ColorName.PewterBlue:                          return new Rgb(55, 66, 72);
            case ColorName.Phlox:                               return new Rgb(87, 0, 100);
            case ColorName.PhthaloBlue:                         return new Rgb(0, 6, 54);
            case ColorName.PhthaloGreen:                        return new Rgb(7, 21, 14);
            case ColorName.PicoteeBlue:                         return new Rgb(18, 15, 53);
            case ColorName.PictorialCarmine:                    return new Rgb(76, 4, 31);
            case ColorName.PiggyPink:                           return new Rgb(99, 87, 90);
            case ColorName.PineGreen:                           return new Rgb(0, 47, 44);
            case ColorName.PineTree:                            return new Rgb(16, 18, 14);
            case ColorName.Pink:                                return new Rgb(100, 75, 80);
            case ColorName.PinkFlamingo:                        return new Rgb(99, 45, 99);
            case ColorName.PinkLace:                            return new Rgb(100, 87, 96);
            case ColorName.PinkLavender:                        return new Rgb(85, 70, 82);
            case ColorName.PinkSherbet:                         return new Rgb(97, 56, 65);
            case ColorName.Pistachio:                           return new Rgb(58, 77, 45);
            case ColorName.Platinum:                            return new Rgb(90, 89, 89);
            case ColorName.Plum:                                return new Rgb(56, 27, 52);
            case ColorName.PlumWeb:                             return new Rgb(87, 63, 87);
            case ColorName.PlumpPurple:                         return new Rgb(35, 27, 70);
            case ColorName.PolishedPine:                        return new Rgb(36, 64, 58);
            case ColorName.PompAndPower:                        return new Rgb(53, 38, 56);
            case ColorName.Popstar:                             return new Rgb(75, 31, 38);
            case ColorName.PortlandOrange:                      return new Rgb(100, 35, 21);
            case ColorName.PowderBlue:                          return new Rgb(69, 88, 90);
            case ColorName.PrincetonOrange:                     return new Rgb(96, 50, 15);
            case ColorName.ProcessYellow:                       return new Rgb(100, 94, 0);
            case ColorName.Prune:                               return new Rgb(44, 11, 11);
            case ColorName.PrussianBlue:                        return new Rgb(0, 19, 33);
            case ColorName.PsychedelicPurple:                   return new Rgb(87, 0, 100);
            case ColorName.Puce:                                return new Rgb(80, 53, 60);
            case ColorName.Pumpkin:                             return new Rgb(100, 46, 9);
            case ColorName.Purple:                              return new Rgb(38, 0, 50);
            case ColorName.PurpleWeb:                           return new Rgb(50, 0, 50);
            case ColorName.PurpleMunsell:                       return new Rgb(62, 0, 77);
            case ColorName.PurpleMountainMajesty:               return new Rgb(59, 47, 71);
            case ColorName.PurpleNavy:                          return new Rgb(31, 32, 50);
            case ColorName.PurplePizzazz:                       return new Rgb(100, 31, 85);
            case ColorName.PurplePlum:                          return new Rgb(61, 32, 71);
            case ColorName.Purpureus:                           return new Rgb(60, 31, 68);
            case ColorName.QueenBlue:                           return new Rgb(26, 42, 58);
            case ColorName.QueenPink:                           return new Rgb(91, 80, 84);
            case ColorName.QuickSilver:                         return new Rgb(65, 65, 65);
            case ColorName.QuinacridoneMagenta:                 return new Rgb(56, 23, 35);
            case ColorName.RadicalRed:                          return new Rgb(100, 21, 37);
            case ColorName.RaisinBlack:                         return new Rgb(14, 13, 14);
            case ColorName.Rajah:                               return new Rgb(98, 67, 38);
            case ColorName.Raspberry:                           return new Rgb(89, 4, 36);
            case ColorName.RaspberryGlace:                      return new Rgb(57, 37, 43);
            case ColorName.RaspberryRose:                       return new Rgb(70, 27, 42);
            case ColorName.RawSienna:                           return new Rgb(84, 54, 35);
            case ColorName.RawUmber:                            return new Rgb(51, 40, 27);
            case ColorName.RazzleDazzleRose:                    return new Rgb(100, 20, 80);
            case ColorName.Razzmatazz:                          return new Rgb(89, 15, 42);
            case ColorName.RazzmicBerry:                        return new Rgb(55, 31, 52);
            case ColorName.RebeccaPurple:                       return new Rgb(40, 20, 60);
            case ColorName.Red:                                 return new Rgb(100, 0, 0);
            case ColorName.RedCrayola:                          return new Rgb(93, 13, 30);
            case ColorName.RedMunsell:                          return new Rgb(95, 0, 24);
            case ColorName.RedPigment:                          return new Rgb(93, 11, 14);
            case ColorName.RedOrange:                           return new Rgb(100, 33, 29);
            case ColorName.RedOrangeCrayola:                    return new Rgb(100, 41, 12);
            case ColorName.RedOrangeColorWheel:                 return new Rgb(100, 27, 0);
            case ColorName.RedPurple:                           return new Rgb(89, 0, 47);
            case ColorName.RedSalsa:                            return new Rgb(99, 23, 29);
            case ColorName.RedViolet:                           return new Rgb(78, 8, 52);
            case ColorName.RedVioletCrayola:                    return new Rgb(75, 27, 56);
            case ColorName.RedVioletColorWheel:                 return new Rgb(57, 17, 24);
            case ColorName.Redwood:                             return new Rgb(64, 35, 32);
            case ColorName.ResolutionBlue:                      return new Rgb(0, 14, 53);
            case ColorName.Rhythm:                              return new Rgb(47, 46, 59);
            case ColorName.RichBlack:                           return new Rgb(0, 25, 25);
            case ColorName.RifleGreen:                          return new Rgb(27, 30, 22);
            case ColorName.RobinEggBlue:                        return new Rgb(0, 80, 80);
            case ColorName.RocketMetallic:                      return new Rgb(54, 50, 50);
            case ColorName.RojoSpanishRed:                      return new Rgb(66, 7, 0);
            case ColorName.RomanSilver:                         return new Rgb(51, 54, 59);
            case ColorName.Rose:                                return new Rgb(100, 0, 50);
            case ColorName.RoseBonbon:                          return new Rgb(98, 26, 62);
            case ColorName.RoseDust:                            return new Rgb(62, 37, 44);
            case ColorName.RoseEbony:                           return new Rgb(40, 28, 27);
            case ColorName.RoseMadder:                          return new Rgb(89, 15, 21);
            case ColorName.RosePink:                            return new Rgb(100, 40, 80);
            case ColorName.RosePompadour:                       return new Rgb(93, 48, 61);
            case ColorName.RoseQuartz:                          return new Rgb(67, 60, 66);
            case ColorName.RoseRed:                             return new Rgb(76, 12, 34);
            case ColorName.RoseTaupe:                           return new Rgb(56, 36, 36);
            case ColorName.RoseVale:                            return new Rgb(67, 31, 32);
            case ColorName.Rosewood:                            return new Rgb(40, 0, 4);
            case ColorName.RossoCorsa:                          return new Rgb(83, 0, 0);
            case ColorName.RosyBrown:                           return new Rgb(74, 56, 56);
            case ColorName.RoyalBlueDark:                       return new Rgb(0, 14, 40);
            case ColorName.RoyalBlueLight:                      return new Rgb(25, 41, 88);
            case ColorName.RoyalPurple:                         return new Rgb(47, 32, 66);
            case ColorName.RoyalYellow:                         return new Rgb(98, 85, 37);
            case ColorName.Ruber:                               return new Rgb(81, 27, 46);
            case ColorName.RubineRed:                           return new Rgb(82, 0, 34);
            case ColorName.Ruby:                                return new Rgb(88, 7, 37);
            case ColorName.RubyRed:                             return new Rgb(61, 7, 12);
            case ColorName.Rufous:                              return new Rgb(66, 11, 3);
            case ColorName.Russet:                              return new Rgb(50, 27, 11);
            case ColorName.RussianGreen:                        return new Rgb(40, 57, 40);
            case ColorName.RussianViolet:                       return new Rgb(20, 9, 30);
            case ColorName.Rust:                                return new Rgb(72, 25, 5);
            case ColorName.RustyRed:                            return new Rgb(85, 17, 26);
            case ColorName.SacramentoStateGreen:                return new Rgb(2, 22, 15);
            case ColorName.SaddleBrown:                         return new Rgb(55, 27, 7);
            case ColorName.SafetyOrange:                        return new Rgb(100, 47, 0);
            case ColorName.SafetyOrangeBlazeOrange:             return new Rgb(100, 40, 0);
            case ColorName.SafetyYellow:                        return new Rgb(93, 82, 1);
            case ColorName.Saffron:                             return new Rgb(96, 77, 19);
            case ColorName.Sage:                                return new Rgb(74, 72, 54);
            case ColorName.Salmon:                              return new Rgb(98, 50, 45);
            case ColorName.SalmonPink:                          return new Rgb(100, 57, 64);
            case ColorName.Sand:                                return new Rgb(76, 70, 50);
            case ColorName.SandDune:                            return new Rgb(59, 44, 9);
            case ColorName.SandyBrown:                          return new Rgb(96, 64, 38);
            case ColorName.SapGreen:                            return new Rgb(31, 49, 16);
            case ColorName.Sapphire:                            return new Rgb(6, 32, 73);
            case ColorName.SapphireBlue:                        return new Rgb(0, 40, 65);
            case ColorName.SapphireCrayola:                     return new Rgb(18, 36, 63);
            case ColorName.SatinSheenGold:                      return new Rgb(80, 63, 21);
            case ColorName.Scarlet:                             return new Rgb(100, 14, 0);
            case ColorName.SchaussPink:                         return new Rgb(100, 57, 69);
            case ColorName.SchoolBusYellow:                     return new Rgb(100, 85, 0);
            case ColorName.SeaGreen:                            return new Rgb(18, 55, 34);
            case ColorName.SeaGreenCrayola:                     return new Rgb(0, 100, 80);
            case ColorName.SealBrown:                           return new Rgb(20, 8, 8);
            case ColorName.Seashell:                            return new Rgb(100, 96, 93);
            case ColorName.SelectiveYellow:                     return new Rgb(100, 73, 0);
            case ColorName.Sepia:                               return new Rgb(44, 26, 8);
            case ColorName.Shadow:                              return new Rgb(54, 47, 36);
            case ColorName.ShadowBlue:                          return new Rgb(47, 55, 65);
            case ColorName.ShamrockGreen:                       return new Rgb(0, 62, 38);
            case ColorName.SheenGreen:                          return new Rgb(56, 83, 0);
            case ColorName.ShimmeringBlush:                     return new Rgb(85, 53, 58);
            case ColorName.ShinyShamrock:                       return new Rgb(37, 65, 47);
            case ColorName.ShockingPink:                        return new Rgb(99, 6, 75);
            case ColorName.ShockingPinkCrayola:                 return new Rgb(100, 44, 100);
            case ColorName.Sienna:                              return new Rgb(53, 18, 9);
            case ColorName.Silver:                              return new Rgb(75, 75, 75);
            case ColorName.SilverCrayola:                       return new Rgb(79, 75, 73);
            case ColorName.SilverMetallic:                      return new Rgb(67, 66, 68);
            case ColorName.SilverChalice:                       return new Rgb(67, 67, 67);
            case ColorName.SilverPink:                          return new Rgb(77, 68, 68);
            case ColorName.SilverSand:                          return new Rgb(75, 76, 76);
            case ColorName.Sinopia:                             return new Rgb(80, 25, 4);
            case ColorName.SizzlingRed:                         return new Rgb(100, 22, 33);
            case ColorName.SizzlingSunrise:                     return new Rgb(100, 86, 0);
            case ColorName.Skobeloff:                           return new Rgb(0, 45, 45);
            case ColorName.SkyBlue:                             return new Rgb(53, 81, 92);
            case ColorName.SkyBlueCrayola:                      return new Rgb(46, 84, 92);
            case ColorName.SkyMagenta:                          return new Rgb(81, 44, 69);
            case ColorName.SlateBlue:                           return new Rgb(42, 35, 80);
            case ColorName.SlateGray:                           return new Rgb(44, 50, 56);
            case ColorName.SlimyGreen:                          return new Rgb(16, 59, 9);
            case ColorName.Smitten:                             return new Rgb(78, 25, 53);
            case ColorName.SmokyBlack:                          return new Rgb(6, 5, 3);
            case ColorName.Snow:                                return new Rgb(100, 98, 98);
            case ColorName.SolidPink:                           return new Rgb(54, 22, 26);
            case ColorName.SonicSilver:                         return new Rgb(46, 46, 46);
            case ColorName.SpaceCadet:                          return new Rgb(11, 16, 32);
            case ColorName.SpanishBistre:                       return new Rgb(50, 46, 20);
            case ColorName.SpanishBlue:                         return new Rgb(0, 44, 72);
            case ColorName.SpanishCarmine:                      return new Rgb(82, 0, 28);
            case ColorName.SpanishGray:                         return new Rgb(60, 60, 60);
            case ColorName.SpanishGreen:                        return new Rgb(0, 57, 31);
            case ColorName.SpanishOrange:                       return new Rgb(91, 38, 0);
            case ColorName.SpanishPink:                         return new Rgb(97, 75, 75);
            case ColorName.SpanishRed:                          return new Rgb(90, 0, 15);
            case ColorName.SpanishSkyBlue:                      return new Rgb(0, 100, 100);
            case ColorName.SpanishViolet:                       return new Rgb(30, 16, 51);
            case ColorName.SpanishViridian:                     return new Rgb(0, 50, 36);
            case ColorName.SpringBud:                           return new Rgb(65, 99, 0);
            case ColorName.SpringFrost:                         return new Rgb(53, 100, 16);
            case ColorName.SpringGreen:                         return new Rgb(0, 100, 50);
            case ColorName.SpringGreenCrayola:                  return new Rgb(93, 92, 74);
            case ColorName.StarCommandBlue:                     return new Rgb(0, 48, 72);
            case ColorName.SteelBlue:                           return new Rgb(27, 51, 71);
            case ColorName.SteelPink:                           return new Rgb(80, 20, 80);
            case ColorName.SteelTeal:                           return new Rgb(37, 54, 55);
            case ColorName.StilDeGrainYellow:                   return new Rgb(98, 85, 37);
            case ColorName.Straw:                               return new Rgb(89, 85, 44);
            case ColorName.Strawberry:                          return new Rgb(98, 31, 33);
            case ColorName.StrawberryBlonde:                    return new Rgb(100, 58, 38);
            case ColorName.SugarPlum:                           return new Rgb(57, 31, 46);
            case ColorName.Sunglow:                             return new Rgb(100, 80, 20);
            case ColorName.Sunray:                              return new Rgb(89, 67, 34);
            case ColorName.Sunset:                              return new Rgb(98, 84, 65);
            case ColorName.SuperPink:                           return new Rgb(81, 42, 66);
            case ColorName.SweetBrown:                          return new Rgb(66, 22, 19);
            case ColorName.SyracuseOrange:                      return new Rgb(83, 27, 0);
            case ColorName.Tan:                                 return new Rgb(82, 71, 55);
            case ColorName.TanCrayola:                          return new Rgb(85, 60, 42);
            case ColorName.Tangerine:                           return new Rgb(95, 52, 0);
            case ColorName.TangoPink:                           return new Rgb(89, 44, 48);
            case ColorName.TartOrange:                          return new Rgb(98, 30, 27);
            case ColorName.Taupe:                               return new Rgb(28, 24, 20);
            case ColorName.TaupeGray:                           return new Rgb(55, 52, 54);
            case ColorName.TeaGreen:                            return new Rgb(82, 94, 75);
            case ColorName.TeaRose:                             return new Rgb(97, 51, 47);
            case ColorName.Teal:                                return new Rgb(0, 50, 50);
            case ColorName.TealBlue:                            return new Rgb(21, 46, 53);
            case ColorName.Telemagenta:                         return new Rgb(81, 20, 46);
            case ColorName.Tenné:                               return new Rgb(80, 34, 0);
            case ColorName.TerraCotta:                          return new Rgb(89, 45, 36);
            case ColorName.Thistle:                             return new Rgb(85, 75, 85);
            case ColorName.ThulianPink:                         return new Rgb(87, 44, 63);
            case ColorName.TickleMePink:                        return new Rgb(99, 54, 67);
            case ColorName.TiffanyBlue:                         return new Rgb(4, 73, 71);
            case ColorName.Timberwolf:                          return new Rgb(86, 84, 82);
            case ColorName.TitaniumYellow:                      return new Rgb(93, 90, 0);
            case ColorName.Tomato:                              return new Rgb(100, 39, 28);
            case ColorName.TropicalRainforest:                  return new Rgb(0, 46, 37);
            case ColorName.TrueBlue:                            return new Rgb(0, 45, 81);
            case ColorName.TrypanBlue:                          return new Rgb(11, 2, 70);
            case ColorName.TuftsBlue:                           return new Rgb(24, 56, 87);
            case ColorName.Tumbleweed:                          return new Rgb(87, 67, 53);
            case ColorName.Turquoise:                           return new Rgb(25, 88, 82);
            case ColorName.TurquoiseBlue:                       return new Rgb(0, 100, 94);
            case ColorName.TurquoiseGreen:                      return new Rgb(63, 84, 71);
            case ColorName.TurtleGreen:                         return new Rgb(54, 60, 36);
            case ColorName.Tuscan:                              return new Rgb(98, 84, 65);
            case ColorName.TuscanBrown:                         return new Rgb(44, 31, 22);
            case ColorName.TuscanRed:                           return new Rgb(49, 28, 28);
            case ColorName.TuscanTan:                           return new Rgb(65, 48, 36);
            case ColorName.Tuscany:                             return new Rgb(75, 60, 60);
            case ColorName.TwilightLavender:                    return new Rgb(54, 29, 42);
            case ColorName.TyrianPurple:                        return new Rgb(40, 1, 24);
            case ColorName.UABlue:                              return new Rgb(0, 20, 67);
            case ColorName.UARed:                               return new Rgb(85, 0, 30);
            case ColorName.Ultramarine:                         return new Rgb(7, 4, 56);
            case ColorName.UltramarineBlue:                     return new Rgb(25, 40, 96);
            case ColorName.UltraPink:                           return new Rgb(100, 44, 100);
            case ColorName.UltraRed:                            return new Rgb(99, 42, 52);
            case ColorName.Umber:                               return new Rgb(39, 32, 28);
            case ColorName.UnbleachedSilk:                      return new Rgb(100, 87, 79);
            case ColorName.UnitedNationsBlue:                   return new Rgb(36, 57, 90);
            case ColorName.UniversityOfPennsylvaniaRed:         return new Rgb(65, 0, 13);
            case ColorName.UnmellowYellow:                      return new Rgb(100, 100, 40);
            case ColorName.UPForestGreen:                       return new Rgb(0, 27, 13);
            case ColorName.UPMaroon:                            return new Rgb(48, 7, 7);
            case ColorName.UpsdellRed:                          return new Rgb(68, 13, 16);
            case ColorName.UranianBlue:                         return new Rgb(69, 86, 96);
            case ColorName.USAFABlue:                           return new Rgb(0, 31, 60);
            case ColorName.VanDykeBrown:                        return new Rgb(40, 26, 16);
            case ColorName.Vanilla:                             return new Rgb(95, 90, 67);
            case ColorName.VanillaIce:                          return new Rgb(95, 56, 66);
            case ColorName.VegasGold:                           return new Rgb(77, 70, 35);
            case ColorName.VenetianRed:                         return new Rgb(78, 3, 8);
            case ColorName.Verdigris:                           return new Rgb(26, 70, 68);
            case ColorName.Vermilion:                           return new Rgb(89, 26, 20);
            case ColorName.Veronica:                            return new Rgb(63, 13, 94);
            case ColorName.Violet:                              return new Rgb(56, 0, 100);
            case ColorName.VioletColorWheel:                    return new Rgb(50, 0, 100);
            case ColorName.VioletCrayola:                       return new Rgb(59, 24, 50);
            case ColorName.VioletWeb:                           return new Rgb(93, 51, 93);
            case ColorName.VioletBlue:                          return new Rgb(20, 29, 70);
            case ColorName.VioletBlueCrayola:                   return new Rgb(46, 43, 78);
            case ColorName.VioletRed:                           return new Rgb(97, 33, 58);
            case ColorName.Viridian:                            return new Rgb(25, 51, 43);
            case ColorName.ViridianGreen:                       return new Rgb(0, 59, 60);
            case ColorName.VividBurgundy:                       return new Rgb(62, 11, 21);
            case ColorName.VividSkyBlue:                        return new Rgb(0, 80, 100);
            case ColorName.VividTangerine:                      return new Rgb(100, 63, 54);
            case ColorName.VividViolet:                         return new Rgb(62, 0, 100);
            case ColorName.Volt:                                return new Rgb(80, 100, 0);
            case ColorName.WarmBlack:                           return new Rgb(0, 26, 26);
            case ColorName.Wheat:                               return new Rgb(96, 87, 70);
            case ColorName.White:                               return new Rgb(100, 100, 100);
            case ColorName.WildBlueYonder:                      return new Rgb(64, 68, 82);
            case ColorName.WildOrchid:                          return new Rgb(83, 44, 64);
            case ColorName.WildStrawberry:                      return new Rgb(100, 26, 64);
            case ColorName.WildWatermelon:                      return new Rgb(99, 42, 52);
            case ColorName.WindsorTan:                          return new Rgb(65, 33, 1);
            case ColorName.Wine:                                return new Rgb(45, 18, 22);
            case ColorName.WineDregs:                           return new Rgb(40, 19, 28);
            case ColorName.WinterSky:                           return new Rgb(100, 0, 49);
            case ColorName.WintergreenDream:                    return new Rgb(34, 53, 49);
            case ColorName.Wisteria:                            return new Rgb(79, 63, 86);
            case ColorName.WoodBrown:                           return new Rgb(76, 60, 42);
            case ColorName.Xanadu:                              return new Rgb(45, 53, 47);
            case ColorName.Xanthic:                             return new Rgb(93, 93, 4);
            case ColorName.Xanthous:                            return new Rgb(95, 71, 18);
            case ColorName.YaleBlue:                            return new Rgb(0, 21, 42);
            case ColorName.Yellow:                              return new Rgb(100, 100, 0);
            case ColorName.YellowCrayola:                       return new Rgb(99, 91, 51);
            case ColorName.YellowMunsell:                       return new Rgb(94, 80, 0);
            case ColorName.YellowProcess:                       return new Rgb(100, 94, 0);
            case ColorName.YellowGreen:                         return new Rgb(60, 80, 20);
            case ColorName.YellowGreenCrayola:                  return new Rgb(77, 89, 52);
            case ColorName.YellowGreenColorWheel:               return new Rgb(19, 70, 10);
            case ColorName.YellowOrange:                        return new Rgb(100, 68, 26);
            case ColorName.YellowOrangeColorWheel:              return new Rgb(100, 58, 2);
            case ColorName.YellowSunshine:                      return new Rgb(100, 97, 0);
            case ColorName.YInMnBlue:                           return new Rgb(18, 31, 56);
            case ColorName.Zaffre:                              return new Rgb(0, 8, 66);
            case ColorName.Zomp:                                return new Rgb(22, 65, 56);
            default:                                            throw new Exception("Incorrect color name");
        }
    }

}

public enum ColorName {

    AbsoluteZero,
    AcidGreen,
    Aero,
    AeroBlue,
    AfricanViolet,
    AirSuperiorityBlue,
    Alabaster,
    AliceBlue,
    AlloyOrange,
    Almond,
    Amaranth,
    AmaranthPink,
    AmaranthPurple,
    AmaranthRed,
    Amazon,
    Amber,
    Amethyst,
    AndroidGreen,
    AntiqueBrass,
    AntiqueBronze,
    AntiqueFuchsia,
    AntiqueRuby,
    AntiqueWhite,
    AoEnglish,
    AppleGreen,
    Apricot,
    Aqua,
    Aquamarine,
    ArcticLime,
    ArmyGreen,
    Artichoke,
    ArylideYellow,
    AshGray,
    Asparagus,
    AtomicTangerine,
    Auburn,
    Aureolin,
    Avocado,
    Azure,
    BabyBlue,
    BabyBlueEyes,
    BabyPink,
    BabyPowder,
    BakerMillerPink,
    BananaMania,
    BarbiePink,
    BarnRed,
    BattleshipGrey,
    BeauBlue,
    Beaver,
    Beige,
    Bisque,
    Bistre,
    BistreBrown,
    BitterLemon,
    BitterLime,
    Bittersweet,
    BittersweetShimmer,
    Black,
    BlackBean,
    BlackChocolate,
    BlackCoffee,
    BlackCoral,
    BlackOlive,
    BlackShadows,
    BlanchedAlmond,
    BlastOffBronze,
    BleuDeFrance,
    BlizzardBlue,
    Blond,
    BloodRed,
    Blue,
    BlueCrayola,
    BlueMunsell,
    BlueNCS,
    BluePigment,
    BlueRYB,
    BlueBell,
    BlueGray,
    BlueGreen,
    BlueGreenColorWheel,
    BlueJeans,
    BlueSapphire,
    BlueViolet,
    BlueVioletCrayola,
    BlueVioletColorWheel,
    BlueYonder,
    Bluetiful,
    Blush,
    Bole,
    Bone,
    BottleGreen,
    Brandy,
    BrickRed,
    BrightGreen,
    BrightLilac,
    BrightMaroon,
    BrightNavyBlue,
    BrightYellowCrayola,
    BrilliantRose,
    BrinkPink,
    BritishRacingGreen,
    Bronze,
    Brown,
    BrownSugar,
    BrunswickGreen,
    BudGreen,
    Buff,
    Burgundy,
    Burlywood,
    BurnishedBrown,
    BurntOrange,
    BurntSienna,
    BurntUmber,
    Byzantine,
    Byzantium,
    Cadet,
    CadetBlue,
    CadetBlueCrayola,
    CadetGrey,
    CadmiumGreen,
    CadmiumOrange,
    CadmiumRed,
    CadmiumYellow,
    CafeAuLait,
    CafeNoir,
    CambridgeBlue,
    Camel,
    CameoPink,
    Canary,
    CanaryYellow,
    CandyAppleRed,
    CandyPink,
    Capri,
    CaputMortuum,
    Cardinal,
    CaribbeanGreen,
    Carmine,
    CarnationPink,
    Carnelian,
    CarolinaBlue,
    CarrotOrange,
    CastletonGreen,
    Catawba,
    CedarChest,
    Celadon,
    CeladonBlue,
    CeladonGreen,
    Celeste,
    CelticBlue,
    Cerise,
    Cerulean,
    CeruleanBlue,
    CeruleanFrost,
    CeruleanCrayola,
    CGBlue,
    CGRed,
    Champagne,
    ChampagnePink,
    Charcoal,
    CharlestonGreen,
    CharmPink,
    ChartreuseTraditional,
    ChartreuseWeb,
    CherryBlossomPink,
    Chestnut,
    ChiliRed,
    ChinaPink,
    ChinaRose,
    ChineseRed,
    ChineseViolet,
    ChineseYellow,
    ChocolateTraditional,
    ChocolateWeb,
    ChocolateCosmos,
    ChromeYellow,
    Cinereous,
    Cinnabar,
    CinnamonSatin,
    Citrine,
    Citron,
    Claret,
    CobaltBlue,
    CocoaBrown,
    Coffee,
    ColumbiaBlue,
    CongoPink,
    CoolGrey,
    Copper,
    CopperCrayola,
    CopperPenny,
    CopperRed,
    CopperRose,
    Coquelicot,
    Coral,
    CoralPink,
    Cordovan,
    Corn,
    CornellRed,
    CornflowerBlue,
    Cornsilk,
    CosmicCobalt,
    CosmicLatte,
    CoyoteBrown,
    CottonCandy,
    Cream,
    Crimson,
    CrimsonUA,
    Crystal,
    Cultured,
    Cyan,
    CyanProcess,
    CyberGrape,
    CyberYellow,
    Cyclamen,
    DarkBlueGray,
    DarkBrown,
    DarkByzantium,
    DarkCornflowerBlue,
    DarkCyan,
    DarkElectricBlue,
    DarkGoldenrod,
    DarkGreen,
    DarkJungleGreen,
    DarkKhaki,
    DarkLava,
    DarkLiver,
    DarkLiverHorses,
    DarkMagenta,
    DarkMossGreen,
    DarkOliveGreen,
    DarkOrange,
    DarkOrchid,
    DarkPastelGreen,
    DarkPurple,
    DarkRed,
    DarkSalmon,
    DarkSeaGreen,
    DarkSienna,
    DarkSkyBlue,
    DarkSlateBlue,
    DarkSlateGray,
    DarkSpringGreen,
    DarkTurquoise,
    DarkViolet,
    DartmouthGreen,
    DeepCerise,
    DeepChampagne,
    DeepChestnut,
    DeepJungleGreen,
    DeepPink,
    DeepSaffron,
    DeepSkyBlue,
    DeepSpaceSparkle,
    DeepTaupe,
    Denim,
    DenimBlue,
    Desert,
    DesertSand,
    DimGray,
    DodgerBlue,
    DogwoodRose,
    Drab,
    DukeBlue,
    DutchWhite,
    EarthYellow,
    Ebony,
    Ecru,
    EerieBlack,
    Eggplant,
    Eggshell,
    EgyptianBlue,
    Eigengrau,
    ElectricBlue,
    ElectricGreen,
    ElectricIndigo,
    ElectricLime,
    ElectricPurple,
    ElectricViolet,
    Emerald,
    Eminence,
    EnglishGreen,
    EnglishLavender,
    EnglishRed,
    EnglishVermillion,
    EnglishViolet,
    Erin,
    EtonBlue,
    Fallow,
    FaluRed,
    Fandango,
    FandangoPink,
    FashionFuchsia,
    Fawn,
    Feldgrau,
    FernGreen,
    FieldDrab,
    FieryRose,
    Firebrick,
    FireEngineRed,
    FireOpal,
    Flame,
    Flax,
    Flirt,
    FloralWhite,
    FluorescentBlue,
    ForestGreenCrayola,
    ForestGreenTraditional,
    ForestGreenWeb,
    FrenchBeige,
    FrenchBistre,
    FrenchBlue,
    FrenchFuchsia,
    FrenchLilac,
    FrenchLime,
    FrenchMauve,
    FrenchPink,
    FrenchRaspberry,
    FrenchRose,
    FrenchSkyBlue,
    FrenchViolet,
    Frostbite,
    Fuchsia,
    FuchsiaCrayola,
    FuchsiaPurple,
    FuchsiaRose,
    Fulvous,
    FuzzyWuzzy,
    Gainsboro,
    Gamboge,
    GenericViridian,
    GhostWhite,
    Glaucous,
    GlossyGrape,
    GOGreen,
    Gold,
    GoldMetallic,
    GoldWebGolden,
    GoldCrayola,
    GoldFusion,
    GoldenBrown,
    GoldenPoppy,
    GoldenYellow,
    Goldenrod,
    GraniteGray,
    GrannySmithApple,
    GrayWeb,
    Green,
    GreenCrayola,
    GreenWeb,
    GreenMunsell,
    GreenPigment,
    GreenBlue,
    GreenBlueCrayola,
    GreenCyan,
    GreenLizard,
    GreenSheen,
    GreenYellow,
    GreenYellowCrayola,
    Grullo,
    Gunmetal,
    HanBlue,
    HanPurple,
    HansaYellow,
    Harlequin,
    HarvestGold,
    HeatWave,
    Heliotrope,
    HeliotropeGray,
    HollywoodCerise,
    Honeydew,
    HonoluluBlue,
    HotMagenta,
    HotPink,
    HunterGreen,
    Iceberg,
    Icterine,
    IlluminatingEmerald,
    ImperialRed,
    Inchworm,
    Independence,
    IndiaGreen,
    IndianRed,
    IndianYellow,
    Indigo,
    IndigoDye,
    InternationalKleinBlue,
    InternationalOrangeAerospace,
    InternationalOrangeEngineering,
    InternationalOrangeGoldenGateBridge,
    Iris,
    Irresistible,
    Isabelline,
    ItalianSkyBlue,
    Ivory,
    Jade,
    JapaneseCarmine,
    JapaneseViolet,
    Jasmine,
    JazzberryJam,
    Jet,
    Jonquil,
    JuneBud,
    JungleGreen,
    KellyGreen,
    Keppel,
    KeyLime,
    KhakiWeb,
    Kobe,
    Kobi,
    Kobicha,
    KombuGreen,
    KSUPurple,
    LanguidLavender,
    LapisLazuli,
    LaserLemon,
    LaurelGreen,
    Lava,
    LavenderFloral,
    LavenderWeb,
    LavenderBlue,
    LavenderBlush,
    LavenderGray,
    LawnGreen,
    Lemon,
    LemonChiffon,
    LemonCurry,
    LemonGlacier,
    LemonMeringue,
    LemonYellow,
    LemonYellowCrayola,
    Liberty,
    LightBlue,
    LightCoral,
    LightCornflowerBlue,
    LightCyan,
    LightFrenchBeige,
    LightGoldenrodYellow,
    LightGray,
    LightGreen,
    LightOrange,
    LightPeriwinkle,
    LightPink,
    LightSalmon,
    LightSeaGreen,
    LightSkyBlue,
    LightSlateGray,
    LightSteelBlue,
    LightYellow,
    Lilac,
    LilacLuster,
    LimeColorWheel,
    LimeGreen,
    LincolnGreen,
    Linen,
    Lion,
    LiseranPurple,
    LittleBoyBlue,
    Liver,
    LiverDogs,
    LiverOrgan,
    LiverChestnut,
    Livid,
    MacaroniAndCheese,
    MadderLake,
    Magenta,
    MagentaCrayola,
    MagentaDye,
    MagentaProcess,
    MagentaHaze,
    MagicMint,
    Magnolia,
    Mahogany,
    Maize,
    MaizeCrayola,
    MajorelleBlue,
    Malachite,
    Manatee,
    Mandarin,
    Mango,
    MangoTango,
    Mantis,
    MardiGras,
    Marigold,
    MaroonCrayola,
    MaroonWeb,
    Mauve,
    MauveTaupe,
    Mauvelous,
    MaximumBlue,
    MaximumBlueGreen,
    MaximumBluePurple,
    MaximumGreen,
    MaximumGreenYellow,
    MaximumPurple,
    MaximumRed,
    MaximumRedPurple,
    MaximumYellow,
    MaximumYellowRed,
    MayGreen,
    MayaBlue,
    MediumAquamarine,
    MediumBlue,
    MediumCandyAppleRed,
    MediumCarmine,
    MediumChampagne,
    MediumOrchid,
    MediumPurple,
    MediumSeaGreen,
    MediumSlateBlue,
    MediumSpringGreen,
    MediumTurquoise,
    MediumVioletRed,
    MellowApricot,
    MellowYellow,
    Melon,
    MetallicGold,
    MetallicSeaweed,
    MetallicSunburst,
    MexicanPink,
    MiddleBlue,
    MiddleBlueGreen,
    MiddleBluePurple,
    MiddleGrey,
    MiddleGreen,
    MiddleGreenYellow,
    MiddlePurple,
    MiddleRed,
    MiddleRedPurple,
    MiddleYellow,
    MiddleYellowRed,
    Midnight,
    MidnightBlue,
    MidnightGreenEagleGreen,
    MikadoYellow,
    MimiPink,
    Mindaro,
    Ming,
    MinionYellow,
    Mint,
    MintCream,
    MintGreen,
    MistyMoss,
    MistyRose,
    ModeBeige,
    MorningBlue,
    MossGreen,
    MountainMeadow,
    MountbattenPink,
    MSUGreen,
    Mulberry,
    MulberryCrayola,
    Mustard,
    MyrtleGreen,
    Mystic,
    MysticMaroon,
    NadeshikoPink,
    NaplesYellow,
    NavajoWhite,
    NavyBlue,
    NavyBlueCrayola,
    NeonBlue,
    NeonCarrot,
    NeonGreen,
    NeonFuchsia,
    NewYorkPink,
    Nickel,
    NonPhotoBlue,
    Nyanza,
    OceanBlue,
    OceanGreen,
    Ochre,
    OldBurgundy,
    OldGold,
    OldLace,
    OldLavender,
    OldMauve,
    OldRose,
    OldSilver,
    Olive,
    OliveGreen,
    Olivine,
    Onyx,
    Opal,
    OperaMauve,
    Orange,
    OrangeCrayola,
    OrangeWeb,
    OrangePeel,
    OrangeRed,
    OrangeRedCrayola,
    OrangeSoda,
    OrangeYellow,
    OrangeYellowCrayola,
    Orchid,
    OrchidPink,
    OrchidCrayola,
    OuterSpaceCrayola,
    OutrageousOrange,
    Oxblood,
    OxfordBlue,
    OUCrimsonRed,
    PacificBlue,
    PakistanGreen,
    PalatinatePurple,
    PaleAqua,
    PaleCerulean,
    PaleDogwood,
    PalePink,
    PaleSilver,
    PaleSpringBud,
    PansyPurple,
    PaoloVeroneseGreen,
    PapayaWhip,
    ParadisePink,
    Parchment,
    ParisGreen,
    PastelPink,
    Patriarch,
    Peach,
    PeachCrayola,
    PeachPuff,
    Pear,
    PearlyPurple,
    Periwinkle,
    PeriwinkleCrayola,
    PermanentGeraniumLake,
    PersianBlue,
    PersianGreen,
    PersianIndigo,
    PersianOrange,
    PersianPink,
    PersianPlum,
    PersianRed,
    PersianRose,
    Persimmon,
    PewterBlue,
    Phlox,
    PhthaloBlue,
    PhthaloGreen,
    PicoteeBlue,
    PictorialCarmine,
    PiggyPink,
    PineGreen,
    PineTree,
    Pink,
    PinkFlamingo,
    PinkLace,
    PinkLavender,
    PinkSherbet,
    Pistachio,
    Platinum,
    Plum,
    PlumWeb,
    PlumpPurple,
    PolishedPine,
    PompAndPower,
    Popstar,
    PortlandOrange,
    PowderBlue,
    PrincetonOrange,
    ProcessYellow,
    Prune,
    PrussianBlue,
    PsychedelicPurple,
    Puce,
    Pumpkin,
    Purple,
    PurpleWeb,
    PurpleMunsell,
    PurpleMountainMajesty,
    PurpleNavy,
    PurplePizzazz,
    PurplePlum,
    Purpureus,
    QueenBlue,
    QueenPink,
    QuickSilver,
    QuinacridoneMagenta,
    RadicalRed,
    RaisinBlack,
    Rajah,
    Raspberry,
    RaspberryGlace,
    RaspberryRose,
    RawSienna,
    RawUmber,
    RazzleDazzleRose,
    Razzmatazz,
    RazzmicBerry,
    RebeccaPurple,
    Red,
    RedCrayola,
    RedMunsell,
    RedPigment,
    RedOrange,
    RedOrangeCrayola,
    RedOrangeColorWheel,
    RedPurple,
    RedSalsa,
    RedViolet,
    RedVioletCrayola,
    RedVioletColorWheel,
    Redwood,
    ResolutionBlue,
    Rhythm,
    RichBlack,
    RifleGreen,
    RobinEggBlue,
    RocketMetallic,
    RojoSpanishRed,
    RomanSilver,
    Rose,
    RoseBonbon,
    RoseDust,
    RoseEbony,
    RoseMadder,
    RosePink,
    RosePompadour,
    RoseQuartz,
    RoseRed,
    RoseTaupe,
    RoseVale,
    Rosewood,
    RossoCorsa,
    RosyBrown,
    RoyalBlueDark,
    RoyalBlueLight,
    RoyalPurple,
    RoyalYellow,
    Ruber,
    RubineRed,
    Ruby,
    RubyRed,
    Rufous,
    Russet,
    RussianGreen,
    RussianViolet,
    Rust,
    RustyRed,
    SacramentoStateGreen,
    SaddleBrown,
    SafetyOrange,
    SafetyOrangeBlazeOrange,
    SafetyYellow,
    Saffron,
    Sage,
    Salmon,
    SalmonPink,
    Sand,
    SandDune,
    SandyBrown,
    SapGreen,
    Sapphire,
    SapphireBlue,
    SapphireCrayola,
    SatinSheenGold,
    Scarlet,
    SchaussPink,
    SchoolBusYellow,
    SeaGreen,
    SeaGreenCrayola,
    SealBrown,
    Seashell,
    SelectiveYellow,
    Sepia,
    Shadow,
    ShadowBlue,
    ShamrockGreen,
    SheenGreen,
    ShimmeringBlush,
    ShinyShamrock,
    ShockingPink,
    ShockingPinkCrayola,
    Sienna,
    Silver,
    SilverCrayola,
    SilverMetallic,
    SilverChalice,
    SilverPink,
    SilverSand,
    Sinopia,
    SizzlingRed,
    SizzlingSunrise,
    Skobeloff,
    SkyBlue,
    SkyBlueCrayola,
    SkyMagenta,
    SlateBlue,
    SlateGray,
    SlimyGreen,
    Smitten,
    SmokyBlack,
    Snow,
    SolidPink,
    SonicSilver,
    SpaceCadet,
    SpanishBistre,
    SpanishBlue,
    SpanishCarmine,
    SpanishGray,
    SpanishGreen,
    SpanishOrange,
    SpanishPink,
    SpanishRed,
    SpanishSkyBlue,
    SpanishViolet,
    SpanishViridian,
    SpringBud,
    SpringFrost,
    SpringGreen,
    SpringGreenCrayola,
    StarCommandBlue,
    SteelBlue,
    SteelPink,
    SteelTeal,
    StilDeGrainYellow,
    Straw,
    Strawberry,
    StrawberryBlonde,
    SugarPlum,
    Sunglow,
    Sunray,
    Sunset,
    SuperPink,
    SweetBrown,
    SyracuseOrange,
    Tan,
    TanCrayola,
    Tangerine,
    TangoPink,
    TartOrange,
    Taupe,
    TaupeGray,
    TeaGreen,
    TeaRose,
    Teal,
    TealBlue,
    Telemagenta,
    Tenné,
    TerraCotta,
    Thistle,
    ThulianPink,
    TickleMePink,
    TiffanyBlue,
    Timberwolf,
    TitaniumYellow,
    Tomato,
    TropicalRainforest,
    TrueBlue,
    TrypanBlue,
    TuftsBlue,
    Tumbleweed,
    Turquoise,
    TurquoiseBlue,
    TurquoiseGreen,
    TurtleGreen,
    Tuscan,
    TuscanBrown,
    TuscanRed,
    TuscanTan,
    Tuscany,
    TwilightLavender,
    TyrianPurple,
    UABlue,
    UARed,
    Ultramarine,
    UltramarineBlue,
    UltraPink,
    UltraRed,
    Umber,
    UnbleachedSilk,
    UnitedNationsBlue,
    UniversityOfPennsylvaniaRed,
    UnmellowYellow,
    UPForestGreen,
    UPMaroon,
    UpsdellRed,
    UranianBlue,
    USAFABlue,
    VanDykeBrown,
    Vanilla,
    VanillaIce,
    VegasGold,
    VenetianRed,
    Verdigris,
    Vermilion,
    Veronica,
    Violet,
    VioletColorWheel,
    VioletCrayola,
    VioletWeb,
    VioletBlue,
    VioletBlueCrayola,
    VioletRed,
    Viridian,
    ViridianGreen,
    VividBurgundy,
    VividSkyBlue,
    VividTangerine,
    VividViolet,
    Volt,
    WarmBlack,
    Wheat,
    White,
    WildBlueYonder,
    WildOrchid,
    WildStrawberry,
    WildWatermelon,
    WindsorTan,
    Wine,
    WineDregs,
    WinterSky,
    WintergreenDream,
    Wisteria,
    WoodBrown,
    Xanadu,
    Xanthic,
    Xanthous,
    YaleBlue,
    Yellow,
    YellowCrayola,
    YellowMunsell,
    YellowProcess,
    YellowGreen,
    YellowGreenCrayola,
    YellowGreenColorWheel,
    YellowOrange,
    YellowOrangeColorWheel,
    YellowSunshine,
    YInMnBlue,
    Zaffre,
    Zomp,

}
}
