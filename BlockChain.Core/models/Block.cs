using BlockChain.Core.interfaces;

namespace BlockChain.Core
{
    public class Block : IBlock
    {
        public string Hash { get; set; }

        public Block()
        {
            Connect();
        }

        protected void Connect()
        {
            Chain.Instance.Attach(this);
        }
    }
}