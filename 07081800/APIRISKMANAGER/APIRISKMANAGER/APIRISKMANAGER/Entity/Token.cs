using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIRISKMANAGER.Entity
{
    public class Token
    {
        public string Access_token { set; get; }
        public string Token_type { set; get; }
        public int Expires_in { set; get; }

        public Token()
        {


        }
        public Token(string access_token, string token_type, int expires_in)
        {
            this.Access_token = access_token;
            this.Token_type = token_type;
            this.Expires_in = expires_in;
        }
    }
}
