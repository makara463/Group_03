namespace AGA_Project.Models
{
    public class UserRole
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RoleId { get; set; }
        = Guid.NewGuid().ToString();
            public string RoleName { get; set; } = Guid.NewGuid().ToString();
    }
}
