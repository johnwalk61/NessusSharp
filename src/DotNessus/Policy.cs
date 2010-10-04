using System;
using System.Collections.Generic;
namespace DotNessus
{
    /// <summary>
    /// A nessus policy
    /// </summary>
    public class Policy
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private Dictionary<string, string> parameters;

        public Dictionary<string, string> Parameters
        {
            get
            {
                return parameters;
            }
        }

        public Policy(string name) : this(0, name)
        {
        }

        public Policy(int id, string name)
        {
            Id = id;
            Name = name;
            parameters = new Dictionary<string, string>();

            parameters.Add("max_hosts", "80");
        }


        /// <summary>
        /// Adds smb credentials to the policy.
        /// </summary>
        /// <param name="username">
        /// A <see cref="System.String"/>
        /// </param>
        /// <param name="password">
        /// A <see cref="System.String"/>
        /// </param>
        public void AddSmbCredentials(string username, string password)
        {
            Parameters.Add("Login configurations[entry]:SMB account :", username);
            Parameters.Add("Login configurations[password]:SMB password :", password);
        }

        public void AddSshCredentials(string username, string password)
        {
            Parameters.Add("SSH settings[entry]:SSH user name :", username);
            Parameters.Add("SSH settings[password]:SSH password (unsafe!) :", password);
        }

    }
}
