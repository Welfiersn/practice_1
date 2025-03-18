using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class FileManager
    {
        private static List<FileDescription> files = new List<FileDescription>();

        private FileManager() { }

        public static void ShowInterface()
        {
            // Установка размера консоли
            Console.SetWindowSize(80, 25);

            FillList();

            DrawTopMenu();
            DrawInterface();
            DrawBottomMenu();

            ShowLeftTable();
            ShowRightTable();
            Console.ReadLine();
        }

        private static void FillList()
        {
            files.Add(new FileDescription("ajacdo", 1283880, new DateTime(2005, 09, 02, 14, 48, 52)));
            files.Add(new FileDescription("Budget_2023.xls", 2097152, new DateTime(2022, 12, 15, 9, 30, 0)));
            files.Add(new FileDescription("MarketingPlan.doc", 5242880, new DateTime(2023, 1, 5, 14, 20, 47)));
            files.Add(new FileDescription("CustomerList.csv", 1310720, new DateTime(2022, 11, 22, 17, 15, 22)));
            files.Add(new FileDescription("ProductPhotos.zip", 12582912, new DateTime(2023, 2, 8, 11, 42, 59)));
            files.Add(new FileDescription("InventoryReport.pdf", 3932160, new DateTime(2023, 3, 1, 8, 27, 14)));
            files.Add(new FileDescription("ITTickets.txt", 786432, new DateTime(2022, 10, 19, 16, 3, 41)));
            files.Add(new FileDescription("SalesData.xls", 4456448, new DateTime(2023, 4, 12, 15, 36, 28)));
            files.Add(new FileDescription("ContractTemplate.doc", 2097152, new DateTime(2022, 9, 30, 13, 48, 52)));
            files.Add(new FileDescription("FinancialStatements.pdf", 7340032, new DateTime(2023, 5, 6, 10, 59, 3)));
            files.Add(new FileDescription("DailyOrders.csv", 1048576, new DateTime(2022, 12, 3, 18, 21, 35)));
            files.Add(new FileDescription("EmployeeRecords.xls", 6291456, new DateTime(2023, 6, 18, 14, 12, 9)));
            files.Add(new FileDescription("ProjectTimeline.ppt", 4194304, new DateTime(2022, 8, 25, 11, 5, 47)));
            files.Add(new FileDescription("TravelExpenses.xls", 3670016, new DateTime(2023, 7, 2, 9, 49, 16)));
            files.Add(new FileDescription("DesignProposal.doc", 5505024, new DateTime(2022, 5, 14, 16, 27, 23)));
            files.Add(new FileDescription("ITSystemLog.txt", 1245184, new DateTime(2023, 8, 11, 13, 54, 39)));
            files.Add(new FileDescription("CostAnalysis.xls", 2883584, new DateTime(2022, 6, 28, 11, 41, 2)));
            files.Add(new FileDescription("SupportTickets.csv", 1572864, new DateTime(2023, 9, 23, 15, 18, 47)));
            files.Add(new FileDescription("CompanyPolicies.pdf", 4423680, new DateTime(2022, 4, 9, 8, 34, 56)));
            files.Add(new FileDescription("ProductionSchedule.xls", 3342336, new DateTime(2023, 10, 7, 12, 29, 1)));
            files.Add(new FileDescription("InventoryList.csv", 1835008, new DateTime(2023, 11, 15, 10, 43, 32)));
            files.Add(new FileDescription("StrategicPlan.ppt", 6029312, new DateTime(2022, 2, 28, 14, 24, 45)));
            files.Add(new FileDescription("AccountingJournal.xls", 4587520, new DateTime(2023, 12, 3, 16, 50, 11)));
            files.Add(new FileDescription("MarketResearch.pdf", 5177600, new DateTime(2022, 1, 17, 9, 11, 28)));
            files.Add(new FileDescription("CustomerFeedback.txt", 1048576, new DateTime(2023, 11, 27, 14, 7, 34)));
            files.Add(new FileDescription("SoftwareUpdates.zip", 10240000, new DateTime(2022, 3, 8, 12, 39, 42)));
            files.Add(new FileDescription("SalesReport.xls", 3145728, new DateTime(2023, 9, 19, 11, 23, 56)));
            files.Add(new FileDescription("RFPResponse.doc", 4849664, new DateTime(2022, 10, 4, 15, 42, 18)));
            files.Add(new FileDescription("SupplierContracts.pdf", 6225664, new DateTime(2023, 8, 14, 13, 28, 7)));
            files.Add(new FileDescription("HRDocuments.xls", 2457600, new DateTime(2022, 11, 30, 9, 59, 23)));
            files.Add(new FileDescription("ProjectBudget.xls", 4063232, new DateTime(2023, 7, 25, 16, 12, 41)));
            files.Add(new FileDescription("DesignDocs.zip", 10485760, new DateTime(2022, 5, 19, 11, 58, 30)));
            files.Add(new FileDescription("Manual.pdf", 3670016, new DateTime(2023, 6, 2, 14, 4, 52)));
            files.Add(new FileDescription("EmployeeTraining.doc", 2621440, new DateTime(2022, 8, 11, 10, 17, 9)));
            files.Add(new FileDescription("FinancialForecasts.xls", 4915200, new DateTime(2023, 4, 28, 13, 36, 15)));
            files.Add(new FileDescription("SupportGuide.txt", 1179648, new DateTime(2022, 9, 16, 15, 22, 41)));
            files.Add(new FileDescription("CompanyPresentation.ppt", 6710784, new DateTime(2023, 3, 21, 11, 9, 17)));
            files.Add(new FileDescription("CustomerOrders.csv", 2097152, new DateTime(2022, 6, 7, 14, 35, 28)));
            files.Add(new FileDescription("InventoryAudit.xls", 3440128, new DateTime(2023, 10, 22, 9, 47, 3)));
            files.Add(new FileDescription("ITIncidentReport.doc", 2621440, new DateTime(2022, 12, 1, 16, 19, 52)));
            files.Add(new FileDescription("EmployeeTraining.doc", 2621440, new DateTime(2022, 8, 11, 10, 17, 9)));
            files.Add(new FileDescription("FinancialForecasts.xls", 4915200, new DateTime(2023, 4, 28, 13, 36, 15)));
            files.Add(new FileDescription("SupportGuide.txt", 1179648, new DateTime(2022, 9, 16, 15, 22, 41)));
            files.Add(new FileDescription("CompanyPresentation.ppt", 6710784, new DateTime(2023, 3, 21, 11, 9, 17)));
            files.Add(new FileDescription("CustomerOrders.csv", 2097152, new DateTime(2022, 6, 7, 14, 35, 28)));
            files.Add(new FileDescription("InventoryAudit.xls", 3440128, new DateTime(2023, 10, 22, 9, 47, 3)));
            files.Add(new FileDescription("ITIncidentReport.doc", 2621440, new DateTime(2022, 12, 1, 16, 19, 52)));
            files.Add(new FileDescription("QualityReport.pdf", 2457600, new DateTime(2023, 1, 30, 11, 45, 0)));
            files.Add(new FileDescription("HR_Handbook.doc", 3145728, new DateTime(2022, 6, 15, 14, 32, 0)));
            files.Add(new FileDescription("SalesLeads.xlsx", 1572864, new DateTime(2023, 8, 3, 9, 18, 0)));
            files.Add(new FileDescription("SupplierEvaluation.txt", 1048576, new DateTime(2022, 11, 20, 16, 27, 0)));
            files.Add(new FileDescription("HRTraining.doc", 2097152, new DateTime(2023, 4, 17, 13, 41, 0)));
            files.Add(new FileDescription("FinancialAudit.pdf", 4194304, new DateTime(2022, 9, 8, 15, 55, 0)));
            files.Add(new FileDescription("CustomerFeedback.xlsx", 1835008, new DateTime(2023, 7, 12, 10, 22, 0)));
        }

        private static void ShowLeftTable()
        {
            // Заголовок столбца
            Console.SetCursorPosition(1, 2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("C: "); // "↓"
            Console.Write(" Имя");
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(5 + 13 * i, 2);   
                Console.Write("Имя");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            // Первая строка данных
            Console.SetCursorPosition(1, 3);
            Console.Write("..");

            int sizeToIterate = files.Count;

            if (sizeToIterate > 50)
            {
                // Отображение только тех файлов, которые помещаются в окно
                files.Sort((x, y) => x.getName.Length.CompareTo(y.getName.Length));
                sizeToIterate = 50;
            }

            for (int i = 1; i <= sizeToIterate; i++)
            {

                // Позиция по столбцу 
                int columnIndex = 1 + (i / 17) * 13;

                // Позиция по строке
                int row = (i + 3) - 17 * (i / 17);

                Console.SetCursorPosition(columnIndex, row);


                // Вывод имени файла
                string[] fileName_Ext = files[i - 1].getName.Split(".");
                string fileName = fileName_Ext[0];
                string extension = fileName_Ext.Length > 1 ? fileName_Ext[1] : "";

                if (fileName.Length > 8)
                {
                    Console.Write(fileName[..7]);
                    Console.Write("~");
                    Console.Write(extension.Length > 0 ? " " + extension[..3] : " ..");
                }
                else
                {
                    Console.Write(fileName);
                    Console.SetCursorPosition(columnIndex + 9, row);
                    Console.Write(fileName_Ext.Length == 1 ? ".." : extension.Length > 0 ? extension[..3] : "..");
                }

            }

        }
        private static void ShowRightTable()
        {
            // Заголовки столбцов
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.SetCursorPosition(41, 2);
            Console.Write("C: "); // "↓"
            Console.Write(" Имя");
            Console.SetCursorPosition(56, 2);
            Console.Write("Размер");
            Console.SetCursorPosition(66, 2);
            Console.Write("Дата");
            Console.SetCursorPosition(73, 2);
            Console.Write("Время");

            // Первая строка данных

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(41, 3);
            Console.Write("..          │>Каталог<│29.09.24│ 11:55");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Сортировка по имени
            files.Sort();

            int sizeToIterate = files.Count;

            if (sizeToIterate > 16) sizeToIterate = 16;


            for (int i = 0; i < sizeToIterate; i++)
            {
                // Позиция строки
                int row = 4 + i;

                // Имя файла
                Console.SetCursorPosition(41, row);
                string[] fileName_Ext = files[i].getName.Split(".");
                string filePart = fileName_Ext[0];
                string extensionPart = fileName_Ext.Length > 1 ? fileName_Ext[1] : "";

                if (filePart.Length > 8)
                {
                    Console.Write(filePart[..7]);
                    Console.Write("~");
                    Console.Write(extensionPart.Length > 0 ? " " + extensionPart[..3] : " ..");
                }
                else
                {
                    Console.Write(filePart);
                    Console.SetCursorPosition(50, row);
                    Console.Write(extensionPart.Length > 0 ? extensionPart[..3] : "..");
                }


                /** Вывод Размера **/
                Console.SetCursorPosition(63 - (files[i].getSize.ToString().Length), 4 + i);
                Console.Write(files[i].getSize);

                /** Вывод Даты **/
                Console.SetCursorPosition(64, 4 + i);
                Console.Write(files[i].getChangedTime.ToString("MM.dd.yy"));

                /** Вывод Времени **/
                Console.SetCursorPosition(74, 4 + i);
                Console.Write(files[i].getChangedTime.ToString("hh:mm"));
            }
        }
        private static void DrawTopMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(new string(' ', 4));

            Console.SetCursorPosition(4, 0);
            Console.Write("Л");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");
            Console.Write(new string(' ', 4));

            Console.SetCursorPosition(13, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ф");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");
            Console.Write(new string(' ', 3));

            Console.SetCursorPosition(20, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Д");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");
            Console.Write(new string(' ', 5));

            Console.SetCursorPosition(29, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("К");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");
            Console.Write(new string(' ', 4));

            Console.SetCursorPosition(40, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("П");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая");
            Console.Write(new string(' ', 29));

            Console.SetCursorPosition(75, 0);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString(" h mm"));


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 1);
            Console.Write("\u2554");
            WriteDoubleHorizontalLine(12);

            Console.Write("\u2564");
            WriteDoubleHorizontalLine(2);

            Console.Write(" C:\\NC ");

            WriteDoubleHorizontalLine(3);

            Console.Write("\u2564");
            WriteDoubleHorizontalLine(12);

            Console.Write("\u2557");
            Console.Write("\u2554");
            WriteDoubleHorizontalLine(12);

            Console.Write("\u2564");
            WriteDoubleHorizontalLine(2);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(" C:\\NC ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("\u2564");
            WriteDoubleHorizontalLine(8);

            Console.Write("\u2564");
            WriteDoubleHorizontalLine(6);

            Console.WriteLine("\u2557");
        }

        private static void DrawInterface()
        {

            Console.SetCursorPosition(0, 2);
            for (int i = 2; i < 20; i++)
            {
                Console.Write("\u2551"); // ║
                Console.SetCursorPosition(13, i);
                Console.Write("\u2502"); // │
                Console.SetCursorPosition(26, i);
                Console.Write("\u2502");
                Console.SetCursorPosition(39, i);
                Console.Write("\u2551");
                Console.Write("\u2551");
                Console.SetCursorPosition(53, i);
                Console.Write("\u2502");
                Console.SetCursorPosition(63, i);
                Console.Write("\u2502");
                Console.SetCursorPosition(72, i);
                Console.Write("\u2502");
                Console.SetCursorPosition(79, i);
                Console.WriteLine("\u2551");

            }

        }

        private static void DrawBottomMenu()
        {
            Console.Write("\u255F");
            WriteHorizontalLine(12);
            Console.Write("\u2534");
            WriteHorizontalLine(12);

            Console.Write("\u2534");
            WriteHorizontalLine(12);

            Console.Write("\u2562");
            Console.Write("\u255F");
            WriteHorizontalLine(12);

            Console.Write("\u2534");
            WriteHorizontalLine(9);


            Console.Write("\u2534");
            WriteHorizontalLine(8);

            Console.Write("\u2534");
            WriteHorizontalLine(6);

            Console.WriteLine("\u2562");
            Console.Write("\u2551");
            Console.SetCursorPosition(39, 21);
            Console.Write("\u2551");
            Console.Write("\u2551");
            Console.SetCursorPosition(79, 21);
            Console.WriteLine("\u2551");
            Console.Write("\u255A");
            WriteDoubleHorizontalLine(38);

            Console.Write("\u255D");
            Console.Write("\u255A");
            WriteDoubleHorizontalLine(38);
            Console.WriteLine("\u255D");

            /** **/
            // Text
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(1, 21);
            Console.Write("..            >Каталог< 29.09.24 11:55");
            Console.SetCursorPosition(41, 21);
            Console.Write("..            >Каталог< 29.09.24 11:55");

            // Menu items
            DrawMenu();
        }

        private static void WriteHorizontalLine(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("\u2500");
            }
        }
        private static void WriteDoubleHorizontalLine(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("\u2550");
            }
        }

        private static void DrawMenu()
        {
            Console.SetCursorPosition(0, 23);  // Добавленная строка
            Console.ResetColor();
            Console.WriteLine("C:\\NC>");

            DrawMenuItem(1, "Помощь", 24);
            DrawMenuItem(2, "Вызов ", 24);
            DrawMenuItem(3, "Чтение", 24);
            DrawMenuItem(4, "Правка", 24);
            DrawMenuItem(5, "Копия ", 24);
            DrawMenuItem(6, "НовИмя", 24);
            DrawMenuItem(7, "НовКат", 24);
            DrawMenuItem(8, "Удал-е", 24);
            DrawMenuItem(9, "Меню  ", 24);
            DrawMenuItem(10, "Выход ", 24);
        }
        // Прорисовка кнопок в нижнем меню
        private static void DrawMenuItem(int number, string text, int row)
        {
            Console.SetCursorPosition(number * 8 - 8, row); // Исправленная позиция
            Console.Write(number);

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(text);
            Console.ResetColor();
        }
        
        private class FileDescription : IComparable<FileDescription>
        {
            private string name;
            private long size;
            private DateTime changedTime;

            public FileDescription(string name, long size, DateTime changedTime)
            {
                this.name = name;
                this.size = size;
                this.changedTime = changedTime;
            }

            public int CompareTo(FileDescription other) => this.name.CompareTo(other.name);

            public string getName => name;
            public long getSize => size;
            public DateTime getChangedTime => changedTime;
        }

    }
}