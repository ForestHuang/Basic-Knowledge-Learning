using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Text;

namespace SURE.Common
{
    /// <summary>
    /// 汉字转全拼(首字母、全拼)
    /// </summary>
    public class ChineseHelper
    {
        /// <summary>
        /// 根据汉字转换成全拼
        /// </summary>
        /// <param name="chineseCharacters">入参汉字</param>
        /// <param name="isLower">是否小写,默认大写</param>
        /// <returns>string</returns>
        public static string ConvertToAllSpelling(string chineseCharacters, bool isLower = false)
        {
            try
            {
                if (chineseCharacters.Length != 0)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < chineseCharacters.Length; i++)
                    {
                        var chr = chineseCharacters[i];
                        stringBuilder.Append(GetSpell(chr));
                    }

                    if (isLower)
                        return stringBuilder.ToString().ToLower();
                    else
                        return stringBuilder.ToString().ToUpper();
                }
            }
            catch (Exception ex)
            {
                return $"errorMessage: {ex.Message}";
            }

            return string.Empty;
        }

        /// <summary>
        /// 汉字转首字母
        /// </summary>
        /// <param name="chineseCharacters">入参汉字</param>
        /// <param name="isLower">是否小写,默认大写</param>
        /// <returns>string</returns>
        public static string GetFirstSpell(string chineseCharacters, bool isLower = false)
        {
            try
            {
                if (chineseCharacters.Length != 0)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < chineseCharacters.Length; i++)
                    {
                        var chineses = chineseCharacters[i];
                        stringBuilder.Append(GetSpell(chineses)[0]);
                    }
                    if (isLower)
                        return stringBuilder.ToString().ToLower();
                    else
                        return stringBuilder.ToString().ToUpper();
                }
            }
            catch (Exception ex)
            {
                return $"errorMessage: {ex.Message}";
            }
            return string.Empty;
        }

        #region private

        /// <summary>
        /// 单个字母转换成全拼
        /// </summary>
        /// <param name="chineseCharacters">单个字</param>
        /// <returns>string</returns>
        private static string GetSpell(char chineseCharacters)
        {
            var resultPinyins = NPinyin.Pinyin.GetPinyin(chineseCharacters);
            bool isChineses = ChineseChar.IsValidChar(resultPinyins[0]);
            if (isChineses)
            {
                ChineseChar chineseChar = new ChineseChar(resultPinyins[0]);
                foreach (string value in chineseChar.Pinyins)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        return value.Remove(value.Length - 1, 1);
                    }
                }
            }
            return resultPinyins;
        }

        #endregion

    }
}
