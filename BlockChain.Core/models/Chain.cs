using System.Collections.Generic;
using BlockChain.Core.interfaces;

namespace BlockChain.Core
{
    public class Chain
    {
        private static Chain _chain;

        private List<IBlock> _blocks;
        
        public static Chain Instance
        {
            get
            {
                if (_chain == null)
                {
                    _chain = new Chain();
                }

                return _chain;
            }
        }

        public void Attach(Block block)
        {
            
        }
    }
}