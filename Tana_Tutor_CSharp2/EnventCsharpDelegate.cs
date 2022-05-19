using System;

namespace Tana_Tutor_CSharp2
{
    public class EnventCsharpDelegate
    {
        public Button openButton;
        public Button saveButton;
        private string fileName;


        public EnventCsharpDelegate()
        {
            // Thêm 1 Button vào giao diện.
            this.openButton = new Button("Open File");

            // Thêm 1 Button vào giao diện.
            this.saveButton = new Button("Save File");


            this.openButton.OnButtonClick += this.OpenButtonClicked;


            this.saveButton.OnButtonClick += this.SaveButtonClicked;
        }

        public void OpenButtonClicked(Button source, int x, int y)
        {
            // Mô phỏng mở ra một cửa sổ để chọn File để mở.
            Console.WriteLine("Open Dialog to Select a file");
            // 
            this.fileName = "File" + x + "_" + y + ".txt";
            Console.WriteLine("Openning file: " + this.fileName);
        }

        public void SaveButtonClicked(Button source, int x, int y)
        {
            if (this.fileName == null)
            {
                Console.WriteLine("No file to save!");
                return;
            }
            // Save File
            Console.WriteLine("Saved file: " + this.fileName);
        }

    }
}
