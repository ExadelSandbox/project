namespace ExaLearn.Dal.Entities
{
    public class Assessment
    {
        public int Id { get; set; }

        public int Grammar { get; set; }

        public int Audition { get; set; }

        public int? Essay { get; set; }

        public int? Speaking { get; set; }

        public int? General { get; set; }
    }
}
