namespace RedisSubscriber.Modelos.MensagemMds
{
    public class ReceberMd
    {
        public ReceberMd(string canal) => this.Canal = canal;

        public string Canal { get; private set; }
    }
}
