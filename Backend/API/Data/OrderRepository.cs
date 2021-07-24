using API.ModelsDB;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace API.Data
{
    public class OrderRepository
    {
        DBContext context = new DBContext();
        
        private List<Agent> DoSomething()
        {
            return context.Agents.ToList();

        }
    }
}