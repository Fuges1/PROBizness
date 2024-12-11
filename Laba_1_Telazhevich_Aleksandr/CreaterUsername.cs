using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using UnidecodeSharpFork;
using System.IO;
using MySqlX.XDevAPI.Common;
using Mysqlx.Session;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading;


namespace PROBizness
{
    internal class CreaterUsername
    {

        public string name1, surname1;
        public string Username;
        public static class Converter
        {
            
            private static readonly Dictionary<char, string> ConvertedLetters = new Dictionary<char, string>
    {
        {'а', "a"},
        {'б', "b"},
        {'в', "v"},
        {'г', "g"},
        {'д', "d"},
        {'е', "e"},
        {'ё', "yo"},
        {'ж', "zh"},
        {'з', "z"},
        {'и', "i"},
        {'й', "j"},
        {'к', "k"},
        {'л', "l"},
        {'м', "m"},
        {'н', "n"},
        {'о', "o"},
        {'п', "p"},
        {'р', "r"},
        {'с', "s"},
        {'т', "t"},
        {'у', "u"},
        {'ф', "f"},
        {'х', "h"},
        {'ц', "c"},
        {'ч', "ch"},
        {'ш', "sh"},
        {'щ', "sch"},
        {'ъ', "j"},
        {'ы', "i"},
        {'ь', "j"},
        {'э', "e"},
        {'ю', "yu"},
        {'я', "ya"},
        {'А', "A"},
        {'Б', "B"},
        {'В', "V"},
        {'Г', "G"},
        {'Д', "D"},
        {'Е', "E"},
        {'Ё', "Yo"},
        {'Ж', "Zh"},
        {'З', "Z"},
        {'И', "I"},
        {'Й', "J"},
        {'К', "K"},
        {'Л', "L"},
        {'М', "M"},
        {'Н', "N"},
        {'О', "O"},
        {'П', "P"},
        {'Р', "R"},
        {'С', "S"},
        {'Т', "T"},
        {'У', "U"},
        {'Ф', "F"},
        {'Х', "H"},
        {'Ц', "C"},
        {'Ч', "Ch"},
        {'Ш', "Sh"},
        {'Щ', "Sch"},
        {'Ъ', "J"},
        {'Ы', "I"},
        {'Ь', "J"},
        {'Э', "E"},
        {'Ю', "Yu"},
        {'Я', "Ya"}
    };
           
            public static bool CheckIfRussian(string source)
            {

                    return Regex.IsMatch(source, @"^[а-яА-Я]+$");
            }
            
            public static string ConvertToLatin(string source)
            {
               
                var result = new StringBuilder();
                
                    foreach (var item in source)
                    {
                        bool sim = CheckIfRussian(Convert.ToString(item));
                        if (sim)
                        {
                                result.Append(ConvertedLetters[item]);
                        }
                        else
                        {
                        
                        result.Append(item);
                        
                        }

                    }
               
                return result.ToString();


            }

            
        }
        public void CreaterUser()
        {

            RegisterForm regform = new RegisterForm();
            string username, name, surname;
            name = name1;
            surname = surname1;
            int Randchislo = 2147483647;
            var rand = new Random();
            int Chislo = Convert.ToInt32(rand.Next(Randchislo));
            username = (Converter.ConvertToLatin(name) + "_" + Converter.ConvertToLatin(surname) + Chislo);

            Username = username;


        }
       
    }
}
