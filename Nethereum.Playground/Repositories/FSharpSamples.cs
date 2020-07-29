using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nethereum.Playground.Repositories
{
    public class FSharpSamples
    {
        public static List<CodeSample> GetSamples()
        {
            var samples = new List<CodeSample>
            {
                new CodeSample()
                {
                    Name = "Chain information: Query Ether account balance using Infura",
                    Id = "3001",
                },
                new CodeSample()
                {
                    Name = "Chain information: Get Block number, Block, Transaction and Receipt using Infura",
                    Id = "3002"
                },
                new CodeSample()
                {
                    Name = "Ether: Unit conversion between Ether and Wei",
                    Id = "3014"
                },
                new CodeSample()
                {
                    Name = "Ether: Transfer Ether to an account",
                    Id = "3003"
                },
            };

            foreach (var sample in samples)
            {
                sample.Language = CodeLanguage.FSharp;
            }

            return samples;
        }
    }
}
