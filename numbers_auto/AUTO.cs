using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_auto
{
    public static class AUTO
    {
        public static bool IsTryeNomberAuto(string auto)
        {
            // РУССКИЕ БУКВЫ
            string chars = "А Б В Г Д Е Ж З И К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ"; ;
            // РЕГИОНЫ
            string numsregions =
              "01 02 102 702 03 04 05 06 07 08 09 10 11 12 13 113 14 15 16 116 716 17 18 " +
              "19 21 121 22 122 23 93 123 193 24 84 88 124 25 125 26 126 27 127 28 " +
              "29 30 31 32 33 34 134 35 36 136 37 38 85 138 39 91 40 41 82 42 142 43 44 45 46 47 " +
              "147 48 49 50 90 150 190 750 51 52 152 53 54 154 55 56 57 58 59 81 159 60 61 161 761 62 63 163 763 64 164 65 66 " +
              "96 196 67 68 69 169 70 71 72 73 173 74 174 75 " +
              "80 76 77 97 99 177 199 197 777 " +
              "79 78 98 178 198 79 82 83 86 186 87 89 92 94 20 95";

            string n = "0 1 2 3 4 5 6 7 8 9";
            bool flag = false;
            while (true)
            {


                if (auto.Length == 9 || auto.Length == 8)
                {
                    // ПРОВЕРКА НА ПЕРВУЮ БУКВУ
                    if (chars.Contains(auto[0]))
                    {
                        // ПРОВЕРКА НА ТРИ ПЕРВЫХ ЦИФР
                        string numb = auto.Substring(1, 4);// МЕТОД ВЫРЕЗКИ ИЗ СТРОКИ ПОДСТРОКИ
                        for (var i = 0; i <= numb.Length; i++)
                        {
                            if (n.Contains(numb[i]))
                            {
                                flag = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // ПРОВЕРКА ДВЕ БУКВЫ
                        if (flag)
                        {
                            numb = auto.Substring(4, 2);
                            for (var i = 0; i <= numb.Length - 1; i++)
                            {
                                if (chars.Contains(numb[i]))
                                {
                                    flag = true;
                                }
                                else
                                {
                                    flag = false;
                                    break;
                                }
                            }
                        }
                        if (flag)
                        {
                            // ПРОВЕРКА НА РЕГИОН
                            numb = auto.Substring(6);
                            if (numsregions.Contains(numb))
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                            }

                        }
                    }

                }
                if (flag)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
    }
}

