namespace Crisis.Messages.Server
{
    public interface IServerHandler
    {
        void HandleAuthConfirm(AuthConfirmMessage msg);
        void HandleAuthDeny(AuthDenyMessage msg);
        void HandleGMChanged(GMChangedMessage msg);
        void HandleHear(HearMessage msg);
        void HandleRegisterResponse(RegisterResponeMessage msg);
        void HandleTimeTurn(TimeTurnMessage msg);
        void HandleCharacter(CharacterMessage msg);
        void HandleRoom(RoomMessage msg);
        void HandleReadiness(ReadinessMessage msg);
    }
}
