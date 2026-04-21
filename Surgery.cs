public class Surgery : Department
{
    public Surgery() : base() { }
    public Surgery(int departmentId) : base(departmentId) { }
    public Surgery(int departmentId, string name) : base(departmentId, name) { }
    public Surgery(int departmentId, string name, int bedCount) : base(departmentId, name, bedCount) { }
}
