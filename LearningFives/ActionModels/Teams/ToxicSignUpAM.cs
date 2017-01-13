namespace ActionModels.Teams
{
    public class ToxicSignUpAM
    {
        public int ToxicLevel { get; set; }
        public bool HadLowPriorityPunish { get; set; }
        public bool HadChatRestrictions { get; set; }
        public bool HadRankedRestrictions { get; set; }
        public bool HadTemporaryBan { get; set; }
        public bool HadPermanentBan { get; set; }
    }
}