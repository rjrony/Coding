using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class Models
    {
        [Serializable]
        public class Payment123GMORequest
        {
            public string gmo_agent_code { get; set; }
            public string gmo_mobile_number { get; set; }
            public string gmo_email_address { get; set; }
            public string gmo_message { get; set; }
            public string gmo_payer_name { get; set; }
            public bool gmo_chkslip { get; set; }


            //support for now
            public string bank_code { set { this.gmo_agent_code = value; } }
            ////public string channel_code { get; set; }
            public string bank_mobile_number { set { gmo_mobile_number = value; } }
            public string bank_email_address { set { gmo_email_address = value; } }
            public string bank_message { set { gmo_message = value; } }
            public string bank_payer_name { set { gmo_payer_name = value; } }

            //public string bank_code { get; set; }
            //public string channel_code { get; set; }
            //public string bank_mobile_number { get; set; }
            //public string bank_email_address { get; set; }
            //public string bank_message { get; set; }
            //public string bank_payer_name { get; set; }

        }
    }
}
