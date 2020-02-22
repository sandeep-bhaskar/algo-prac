using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IExecutor
    {
        public void Execute();
    }

    public interface IPracticeExecutor : IExecutor
    {
    }
}
