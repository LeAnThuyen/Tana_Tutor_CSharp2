namespace TuTor_DeleGate
{
    public class DeleGateEvent
    {

        //bước 1 tạo 1 delegate
        delegate void UpateFullName(string name);
        //bước 2 tạo class đối tượng
        class Student
        {
            public event UpateFullName namChanged;
            private string name;
            public string Name
            {
                get => name;
                set
                {
                    name = value;
                    //kiểm tra name bị thay đổi
                    if (namChanged != null)
                    {
                        namChanged(name);
                    }
                }
            }


        }







    }
}
