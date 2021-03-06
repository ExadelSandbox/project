using Shared.Enums;

namespace ExaLearn.Bl.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string RoleName { get; set; }

        public string Email { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public bool IsActive { get; set; }

        public LevelType? LevelType { get; set; }
    }
}
