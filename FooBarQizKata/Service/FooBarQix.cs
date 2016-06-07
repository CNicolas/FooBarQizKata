using FooBarQizKata.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQizKata
{
    public class FooBarQix
    {
        #region Constants
        private const string EMPTY_STRING = "";

        /// <summary>
        /// Translation Array
        /// </summary>
        private static readonly FooBarQixModel[] TRANSLATIONS = new FooBarQixModel[] { /*new LolModel(), */new FooModel(), new BarModel(), new QixModel() };
        #endregion

        #region Public Methods
        /// <summary>
        /// FooBarQix on github
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string Transforme(int n)
        {
            string res = EMPTY_STRING;

            res += Divide(n);
            res += Contains(n);

            if (res == EMPTY_STRING)
            {
                res += n;
            }

            return res;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Returns a string containing Foo, Bar or Qix if n can be divided by respectively 3, 5 or 7
        /// </summary>
        /// <param name="n">the number</param>
        /// <returns></returns>
        private static string Divide(int n)
        {
            string res = EMPTY_STRING;

            foreach (FooBarQixModel model in TRANSLATIONS)
            {
                if (n % model.Number == 0)
                {
                    res += model.Translation;
                }
            }

            return res;
        }

        /// <summary>
        /// Returns a string containing Foo, Bar or Qix if n respectively contains 3, 5 or 7
        /// </summary>
        /// <param name="n">the number</param>
        /// <returns></returns>
        private static string Contains(int n)
        {
            string res = EMPTY_STRING;
            string tmpString = n.ToString();

            foreach (char c in tmpString)
            {
                FooBarQixModel tmp = TRANSLATIONS.FirstOrDefault(model => model.Char == c);
                res += tmp != null ? tmp.Translation : EMPTY_STRING;
            }

            return res;
        }

        #endregion
    }
}
