namespace InsuranceCRM.Models
{
    public class Policy
    {
        public Policy()
        {

        }

        public Policy(int policyNumber, string insurerName, string insurerDOB, string insurerPhone, string policyType, string policyExpiryDate, int premiumAmount, string policyDocumentLink)
        {
            PolicyNumber = policyNumber;
            InsurerName = insurerName;
            InsurerDOB = insurerDOB;
            InsurerPhone = insurerPhone;
            PolicyType = policyType;
            PolicyExpiryDate = policyExpiryDate;
            PremiumAmount = premiumAmount;
            PolicyDocumentLink = policyDocumentLink;
        }

        public int PolicyNumber { get; set; }
        public string InsurerName { get; set; }
        public string InsurerDOB { get; set; }
        public string InsurerPhone { get; set; }
        public string PolicyType { get; set; }
        public string PolicyExpiryDate { get; set; }
        public int PremiumAmount { get; set; }
        public string PolicyDocumentLink { get; set; }
    }
}