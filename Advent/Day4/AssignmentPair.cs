namespace Day4
{
    internal class AssignmentPair
    {
        public List<Assignment> Assignments { get; set; }

        public AssignmentPair(string data)
        {
            Assignments = new List<Assignment>();
            var parts = data.Split(',');
            foreach (var part in parts)
            {
                var spaces = part.Split('-');
                if (spaces.Length == 2)
                {
                    Assignments.Add(new Assignment
                    {
                        Start = int.Parse(spaces[0]),
                        End = int.Parse(spaces[1])
                    });
                }
            }
        }

        public bool HasFullAssignmentOverlap()
        {
            if (Assignments.Count == 2)
            {
                if (IsFullyContained(Assignments[0], Assignments[1]) || IsFullyContained(Assignments[1], Assignments[0])) return true;
            }
            return false;
        }

        private bool IsFullyContained(Assignment first, Assignment second)
        {
            if (first.Start >= second.Start && first.Start <= second.End)
            {
                return first.End >= second.Start && first.End <= second.End ? true : false;
            }
            return false;
        }

        public bool HasAnyOverlap()
        {
            if (Assignments.Count == 2)
            {
                if (IsPartiallyContained(Assignments[0], Assignments[1]) || IsPartiallyContained(Assignments[1], Assignments[0])) return true;
            }
            return false;
        }

        private bool IsPartiallyContained(Assignment first, Assignment second)
        {
            if (first.Start >= second.Start && first.Start <= second.End) return true;
            if (first.End >= second.Start && first.End <= second.End) return true;
            return false;
        }
    }

    internal class Assignment
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}
