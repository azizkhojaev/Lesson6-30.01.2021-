using System;

namespace Lesson6
{
    class Homework
    {
        public void Task1()
        {
            var ProductKeyPro = "Hello World";
            var ProductKeyExpert ="Hello Alif"; 

            Console.Write ("Plese enter your Product Key ");

            var ProductKey = Console.ReadLine(); 

            if (ProductKey==ProductKeyPro)
            {
                Console.WriteLine("Good! You can use ProVersion of our Program ");

                var ProVersion = new ProDocumentWorker();
                Console.WriteLine("What do you want to do with your documents " );
                Console.WriteLine("Open 1 " );
                Console.WriteLine("Edit 2 ");
                Console.WriteLine("Save 3 ");
                Console.Write("Your choice ");
                var x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                    ProVersion.OpenDocument();
                else if (x == 2)
                    ProVersion.EditDocument();
                else if (x == 3)
                    ProVersion.SaveDocument();
                else
                    Console.WriteLine("You have entered wrong information, Try again !");
            }
            else if (ProductKey==ProductKeyExpert)
            {
                Console.WriteLine("Great !!! You can use ExpertVersion of our Program ");

                var ExpertVersion = new ExpertDocumentWorker();

                Console.WriteLine("What do you want to do with your documents ");
                Console.WriteLine("Open 1 ");
                Console.WriteLine("Edit 2 ");
                Console.WriteLine("Save 3 ");
                Console.Write("Your choice ");
                var x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                    ExpertVersion.OpenDocument();
                else if (x == 2)
                    ExpertVersion.EditDocument();
                else if (x == 3)
                    ExpertVersion.SaveDocument();
                else
                    Console.WriteLine("You have entered wrong information, Try again !");
            }
            else
            {
                Console.WriteLine("You have Entered Wrong Key !");
                Console.WriteLine("But you can use our program partialy ");

                var SimpleVersion = new DocumentWorker();
                Console.WriteLine("What do you want to do with your documents ");
                Console.WriteLine("Open 1 ");
                Console.WriteLine("Edit 2 ");
                Console.WriteLine("Save 3 ");
                Console.Write("Your choice ");
                var x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                    SimpleVersion.OpenDocument();
                else if (x == 2)
                    SimpleVersion.EditDocument();
                else if (x == 3)
                    SimpleVersion.SaveDocument();
                else
                    Console.WriteLine("You have entered wrong information, Try again !");

            }
        }
        public void Task2()
        {
            Console.WriteLine("What do you want to do with your video");
            Console.WriteLine("Record       1");
            Console.WriteLine("Record Pause 2");
            Console.WriteLine("Record Stop  3");
            Console.WriteLine("Play Video   4");
            Console.WriteLine("Pause Video  5");
            Console.WriteLine("Stop Video   6");
            Console.Write("Your choice ");

            var x = Convert.ToInt32(Console.ReadLine());
            var Player = new Player();
            if (x == 1)
                Player.RecordStart();
            else if (x == 2)
                Player.RecordPause();
            else if (x == 3)
                Player.RecordStop();
            else if (x == 4)
                Player.Play();
            else if (x == 5)
                Player.Pause();
            else if (x == 6)
                Player.Stop(); 
            else
                Console.WriteLine("You entered wrog information Try again! ");


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var DZ = new Homework();
            DZ.Task2();
        }
    }
    
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт ");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про ");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про ");
        }
    }
    class ProDocumentWorker: DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecordable
    {
        void RecordStart();
        void RecordPause();
        void RecordStop(); 

    }
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Your video has started playing");
        }
        public void Pause()
        {
            Console.WriteLine("Your video has been pasused");
        }
        public void Stop()
        {
            Console.WriteLine("Your video has been stoped");
        }

        public void RecordPause()
        {
            Console.WriteLine("Recording Paused");
        }

        public void RecordStart()
        {
            Console.WriteLine("Recording Started");
        }

        public void RecordStop()
        {
            Console.WriteLine("Recording Stoped");
        }

    }
}
