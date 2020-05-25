namespace Crisis.Messages.Server
{
    public interface IServerVisitor
    {
        void VisitAuthConfirm(AuthConfirmMessage msg);
        void VisitAuthDeny(AuthDenyMessage msg);
        void VisitGMChanged(GMChangedMessage msg);
        void VisitHear(HearMessage msg);
        void VisitRegisterResponse(RegisterResponeMessage msg);
        void VisitTimeTurn(TimeTurnMessage msg);
        void VisitCharacter(CharacterMessage msg);
        void VisitRoom(RoomMessage msg);
    }
}
