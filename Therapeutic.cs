public class Therapeutic : Department
{
    public Therapeutic() : base() { }
    public Therapeutic(int departmentId) : base(departmentId) { }
    public Therapeutic(int departmentId, string name) : base(departmentId, name) { }
    public Therapeutic(int departmentId, string name, int bedCount) : base(departmentId, name, bedCount) { }
}
