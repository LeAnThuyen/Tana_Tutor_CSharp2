using System;

namespace Tana_Tutor_CSharp2
{
    public class Button
    {


        private string Label;

        public delegate void ClickHander(Button source, int x, int y);

        // Định nghĩa một sự kiện, nó chưa được gán giá trị.
        // Giá trị của nó được gán từ bên ngoài.
        public event ClickHander OnButtonClick;

        public Button(string label)
        {
            this.Label = label;
        }

        // Mô phỏng Button này bị nhấn (Click).
        // Xác định vị trí x, y mà người dùng nhấn vào.
        public void Clicked()
        {
            Random random = new Random();

            // Một số ngẫu nhiên từ 1 -> 100
            int x = random.Next(1, 100);

            // Một số ngẫu nhiên từ 1 -> 20
            int y = random.Next(1, 20);


            if (OnButtonClick != null)
            {
                // Gọi xử lý sự kiện.
                OnButtonClick(this, x, y);
            }

        }

    }
}
