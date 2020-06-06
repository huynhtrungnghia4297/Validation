using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Validation.Models
{
    public class Demo
    {
        public async Task<string> Test01Async()
        {
            await Task.Delay(3000);
            return "Nhat Nghe";

        }
        public async Task<int> Test02Async()
        {
            await Task.Delay(5000);
            return new Random().Next(10000);
        }
        public async Task Test03Async()
        {
            await Task.Delay(2000);
        }
    }
}
