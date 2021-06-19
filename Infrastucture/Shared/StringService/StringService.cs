using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ThirdPartyServices.StringService
{
    public class StringService : IStringService
    {
        public string RemoveSigns(string str)
        {
            str = str.ToLower();
            Regex[] listRe = {
                new Regex("[à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ]"),
                new Regex("[è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|]"),
                new Regex("[ì|í|ị|ỉ|ĩ]"),
                new Regex("[ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ]"),
                new Regex("[ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ]"),
                new Regex("[ỳ|ý|ỵ|ỷ|ỹ]"),
                new Regex("[đ]"),
            };
            string[] map = { "a", "e", "i", "o", "u", "y", "d", };
            for (int i = 0; i < listRe.Length; i++)
                str = listRe[i].Replace(str, map[i]);
            return str;
        }
    }
}
