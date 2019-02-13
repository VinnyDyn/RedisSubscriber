using RedisSubscriber.Modelos.MensagemMds;

namespace RedisSubscriber.Interfaces.Aplicacao
{
    public interface IMensagemApp
    {
        string Receber(ReceberMd comando);
    }
}
