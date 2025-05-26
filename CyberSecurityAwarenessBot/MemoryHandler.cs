using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSecurityAwarenessBot;

namespace CyberSecurityAwarenessBot
{
    // Class to handle memory operations for the user profile 
    internal class MemoryHandler
    {
        private readonly User user;

        public MemoryHandler(User user)
        {
            this.user = user;
        }

        public void Remember(string key, string value)
        {
            user.Memory[key] = value;
        }

        public string Recall(string key)
        {
            return user.Memory.ContainsKey(key) ? user.Memory[key] : null;
        }
    }
}