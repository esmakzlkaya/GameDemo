using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IGameService
    {
        void Add(Games games);
        void Delete(Games games);
    }
}
