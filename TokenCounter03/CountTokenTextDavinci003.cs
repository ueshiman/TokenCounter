using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DeepDev;

namespace TokenCounter03
{
    public class CountTokenTextDavinci003
    {
        private ITokenizer _tokenizer;

        public CountTokenTextDavinci003()
        {
            GetKTokenCount("text-davinci-003").Wait();
        }

        private async Task GetKTokenCount(string modelName)
        {
            _tokenizer = await TokenizerBuilder.CreateByModelNameAsync(modelName);
        }

        public int CountToken(string text)
        {
            return _tokenizer.Encode(text).Count();
        }
    }
}
