
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Models
{
    public interface INewsRepository
    {
        List<News> GetNews();
    }
}
