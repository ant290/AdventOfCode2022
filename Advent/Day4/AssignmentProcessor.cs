namespace Day4
{
    internal class AssignmentProcessor
    {
        public List<AssignmentPair> AssignmentPairs { get; set; }

        public AssignmentProcessor(IEnumerable<string> data)
        {
            AssignmentPairs = new List<AssignmentPair>();
            foreach (string s in data)
            {
                AssignmentPairs.Add(new AssignmentPair(s));    
            }
        }

        public int CountContainedAssignments()
        {
            var res = 0;
            foreach (AssignmentPair assignmentPair in AssignmentPairs)
            {
                if(assignmentPair.HasFullAssignmentOverlap()) res++;
            }

            return res;
        }

        public int CountPartiallyContainedAssignments()
        {
            var res = 0;
            foreach (AssignmentPair assignmentPair in AssignmentPairs)
            {
                if (assignmentPair.HasAnyOverlap()) res++;
            }

            return res;
        }
    }
}
