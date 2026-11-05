using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public abstract class BakeryRuleService
    {
        protected AppSettings Settings
        {
            get
            {
                if (DataStore.Settings != null)
                {
                    return DataStore.Settings;
                }

                return new AppSettings();
            }
        }

        public abstract string RuleCode { get; }

        public abstract string DescribeRule();
    }
}
