using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedirectPaymentForm.Models
{
    public class PaymentModel
    {
        public String vads_action_mode { get; set; }
        public String vads_amount { get; set; }
        public String vads_ctx_mode { get; set; }
        public String vads_currency { get; set; }
        public String vads_page_action { get; set; }
        public String vads_payment_config { get; set; }
        public String vads_site_id { get; set; }
        public String vads_trans_date { get; set; }
        public String vads_trans_id { get; set; }
        public String vads_version { get; set; }
        public String signature { get; set; }
        public String KEY { get; set; }

    }
}
