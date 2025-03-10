namespace EfCorePractise
{
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeacherGroup> TeacherGroups { get; set; } = new List<TeacherGroup>();
    }
}
