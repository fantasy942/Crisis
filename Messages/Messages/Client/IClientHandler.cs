namespace Crisis.Messages.Client
{
    public interface IClientHandler
    {
        void HandleAuth(AuthMessage msg);
        void HandleRegister(RegisterMessage msg);
        void HandleSpeech(SpeechMessage msg);
        void HandleReady(ReadyMessage msg);
        void HandleRoom(RoomTravelMessage msg);
        void HandleArea(AreaTravelMessage msg);
    }
}
