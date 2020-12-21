using System;
using System.Collections.Generic;
using BlockChain.Core.interfaces;

namespace BlockChain.Core
{
    public class Chain
    {
        private static Chain _chain;

        private Dictionary<Type, List<IBlock>> _blocks = new Dictionary<Type, List<IBlock>>();
        
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

        public void Attach(IBlock block)
        {
            if (_blocks.ContainsKey(typeof(IBlock)))
            {
                _blocks[block.GetType()].Add(block);
            }
            else
            {
                _blocks[block.GetType()] = new List<IBlock>()
                {
                    block
                };
            }
        }
    }
}