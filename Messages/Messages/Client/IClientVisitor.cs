namespace Crisis.Messages.Client
{
    public interface IClientVisitor
    {
        void VisitAuth(AuthMessage msg);
        void VisitRegister(RegisterMessage msg);
        void VisitSpeech(SpeechMessage msg);
    }
}
