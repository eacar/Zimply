using UiPath.Plugin.Enums;

namespace UiPath.Plugin.TransactionItems
{
    public class TransactionItem
    {
        #region Properties
        
        public string OrganizationNumber { get; set; }
        public StatusType CurrentStatusType { get; set; }

        #endregion
    }
}