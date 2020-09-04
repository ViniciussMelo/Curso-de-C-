using System;

namespace Workout01.Entities
{
    class User
    {
        public string Username { get; set; }

        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
            {
                return false;
            }
            User other = obj as User;
            return Username.Equals(other.Username);
        }
    }
}
