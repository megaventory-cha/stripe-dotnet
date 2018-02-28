using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRedirect : StripeEntity
    {
        /// <summary>
        /// The failure reason for the redirect. Either user_abort (the customer aborted or dropped out of the redirect flow), declined (the authentication failed or the transaction was declined), or processing_error (the redirect failed due to a technical error). Present only if the redirect status is failed.
        /// </summary>
        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// The URL you provide to redirect the customer to after they authenticated their payment.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The status of the redirect, either not_required, pending, succeeded or failed.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The URL provided to you to redirect a customer to as part of a redirect authentication flow.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
