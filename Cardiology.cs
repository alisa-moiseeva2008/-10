public class Cardiology : Department
{
    public Cardiology() : base() { }
    public Cardiology(int departmentId) : base(departmentId) { }
    public Cardiology(int departmentId, string name) : base(departmentId, name) { }
    public Cardiology(int departmentId, string name, int bedCount) : base(departmentId, name, bedCount) { }
}
