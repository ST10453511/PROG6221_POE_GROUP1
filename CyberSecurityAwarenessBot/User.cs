using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwarenessBot
{
    // Class to represent a user profile
    internal class User
    {
            public string Name { get; set; }
            public Dictionary<string, string> Memory = new Dictionary<string, string>();

    }
}