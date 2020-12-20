using System;
using BlockChain.Core;
using BlockChain.CoreTest.Models;
using Moq;
using NUnit.Framework;

namespace BlockChain.CoreTest
{
    [TestFixture]
    public class Chain
    {
        [Test]
        public void TestTypeSepration()
        {
            var chain = new Mock<BlockChain.Core.Chain>();
            
            chain.Setup(x => x.Attach(new TestBlock()));
            chain.Setup(x => x.Attach(new Block()));
        }
    }
}