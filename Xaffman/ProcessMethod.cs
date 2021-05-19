using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaffman
{
    public class ProcessMethod
    {
        private Form1 form;
        private bitOperation bitOperation;  //Операции с битами
        private List<ModelCode> modelCodes; //Модель "символ = код"
        private string filename;            //Путь к файлу
        private string h;                   //Название, закодированного файла/Декодированного файла
        private List<Node> tables;          //Таблица частот
        public long start_size, end_size;   //Размер файла до/после

        public ProcessMethod(Form1 form)
        {
            this.form = form;
            bitOperation = new bitOperation();
            modelCodes = new List<ModelCode>();
            filename = h = "";
            start_size = end_size = 0;
            tables = new List<Node>();
        }

        /* Получение имени файла */
        public void Setfilename(string filename)
        {
            this.filename = filename;
        }

        /* Генерация таблицы частот */
        public void CreateTable()
        {
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);   //Открываем файл
            for (int i = 0; i < fileStream.Length; i++)     //Создание вектора частот
            {
                byte b = (byte)fileStream.ReadByte();       //Считывание строчки посимвольно
                if (!tables.Exists(j => j.symbol == b))     //Проверка на наличие символа в таблице
                {
                    Node t = new Node(b, 1);     //Если символа в таблице нет, добавляем новый символ в таблицу с частотой = 1
                    tables.Add(t);
                }
                else tables.Find(j => j.symbol == b).weight++;   //Если символ найден в таблице, увеличиваем его частоту на 1
            }
            fileStream.Close();             //Закрываем файл
            Sortirovka(tables);             //Упорядочевание вектора частот 
            Node eof = new Node(null, 0);   //Добавление eof
            tables.Add(eof);
            PrintInformation(tables);       //Запись таблицы частот в файл
            CreatTree(tables);              //Создание дерева кодирования
            setCode("", tables[0]);         //Кодировка символов
        }

        /* Сортировка */
        private void Sortirovka(List<Node> S)
        {
            Node temp;
            for (int i = 0; i < S.Count; i++)
            {
                for (int j = i + 1; j < S.Count; j++)
                {
                    if (S[i].weight != S[j].weight)
                    {
                        if (S[i].weight < S[j].weight)
                        {
                            temp = S[i];
                            S[i] = S[j];
                            S[j] = temp;
                        }
                    }
                    else
                    {
                        if (S[i].symbol < S[j].symbol)
                        {
                            temp = S[i];
                            S[i] = S[j];
                            S[j] = temp;
                        }
                    }
                }
            }
        }

        /* Создание дерева */
        private void CreatTree(List<Node> nodeList)
        {
            while (nodeList.Count > 1)                  //Дереву нужно 2 листа
            {
                Node node1 = nodeList.Last();           //Берем последний элемент
                nodeList.Remove(node1);                 //Удаляем его из таблицы
                Node node2 = nodeList.Last();           //Берем предпоследний элемент
                nodeList.Remove(node2);                 //Удаляем его из таблицы
                nodeList.Add(new Node(node1, node2));   //Создаем новый узел с частотой = сумме частот элементов удаленных из таблицы
                Sortirovka(nodeList);                   //Упорядочевание вектора частот     
            }
        }

        /* Задаем коды символам */
        private void setCode(string code, Node Nodes)
        {
            if (Nodes == null)
                return;
            if (Nodes.leftChild == null && Nodes.rightChild == null)    //Поиск листа
            {
                ModelCode mc = new ModelCode(Nodes.symbol, code);
                modelCodes.Add(mc);
                Nodes.code = code;
                return;
            }
            setCode(code + "0", Nodes.leftChild);
            setCode(code + "1", Nodes.rightChild);
        }

        /* Запись таблицы частот */
        public void PrintInformation(List<Node> nodeList)
        {
            FileInfo fileInf = new FileInfo(filename);
            start_size = fileInf.Length;
            h = fileInf.Name;
            h = h.Substring(h.LastIndexOf('.') + 1) + "_" + h.Substring(0, h.LastIndexOf('.') + 1) + "xuf";
            FileStream fileStream = new FileStream(h, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < 256; i++)
            {
                if (tables.Find((x) => x.symbol == i) != null)
                {
                    byte[] intBytes = BitConverter.GetBytes(tables.Find((x) => x.symbol == i).weight);
                    for (int j = 0; j < 4; j++)
                        fileStream.WriteByte(intBytes[j]);
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                        fileStream.WriteByte(0);
                }

            }
            fileStream.Close();
            //foreach (var item in nodeList)
            //{
            //    Console.WriteLine("Символ : {0} - Частота: {1}", item.symbol, item.weight);
            //}
        }

        /* Вывод символа и его код */
        public void PrintfLeafAndCodes(Node nodeList)
        {
            if (nodeList == null)
                return;
            if (nodeList.leftChild == null && nodeList.rightChild == null)
            {
                Console.WriteLine("Символ : {0} -  Код : {1}", nodeList.symbol, nodeList.code);
                return;
            }
            PrintfLeafAndCodes(nodeList.leftChild);
            PrintfLeafAndCodes(nodeList.rightChild);
        }

        /* Кодируем строчку */
        public void Koding()
        {
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            FileStream fileStream1 = new FileStream(h, FileMode.Append, FileAccess.Write);
            byte newb = 0;
            for (int i = 0; i < fileStream.Length; i++)
            {
                form.workerCod.ReportProgress((int)(fileStream.Position * 100 / fileStream.Length));     //Процесс кодирования
                byte b = (byte)fileStream.ReadByte();       //Считывание строчки посимвольно 
                for (int j = 0; j < modelCodes.Find((x) => x.symbol == b).code.Length; j++)
                {
                    bitOperation.setbit(ref newb, modelCodes.Find(x => x.symbol == b).code[j]);
                    if (bitOperation.bitNumber == 0)
                        fileStream1.WriteByte(newb); 
                }
            }
            for (int j = 0; j < modelCodes.Find((x) => x.symbol == null).code.Length; j++)    //Добавление eof
            {
                bitOperation.setbit(ref newb, modelCodes.Find(x => x.symbol == null).code[j]);
                if (bitOperation.bitNumber == 0)
                    fileStream1.WriteByte(newb);
            }
            if (newb != 0)
                fileStream1.WriteByte(newb);
            fileStream.Close();
            fileStream1.Close();
            FileInfo fileInf = new FileInfo(h);
            end_size = fileInf.Length;
            bitOperation.bitNumber = 0;
        }

        /* Восстанавление таблицы частот */
        public void RecoveryTable()
        {
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            for (int i = 0; i < 256; i++)
            {
                byte[] byteN = new byte[4];
                for (int j = 0; j < 4; j++)
                    byteN[j] = (byte)fileStream.ReadByte();
                int chastota = BitConverter.ToInt32(byteN, 0);
                if (chastota != 0)
                {
                    Node m = new Node((byte)i, chastota);
                    tables.Add(m);
                }
            }
            Sortirovka(tables);
            Node eof = new Node(null, 0);     //Добавление eof
            tables.Add(eof);
            CreatTree(tables);          //Создание дерева кодирования
            setCode("", tables[0]);     //Кодировка символов
            Decoding(fileStream);
            fileStream.Close();
        }

        /* Декодируем строчку */
        private void Decoding(FileStream fileStream)
        {
            FileInfo fileInf = new FileInfo(filename);
            start_size = fileInf.Length;
            h = fileInf.Name;
            h = h.Substring(h.LastIndexOf('_') + 1, h.LastIndexOf('.') - h.LastIndexOf('_'));
            h += fileInf.Name.Substring(0, fileInf.Name.LastIndexOf('_'));
            h = "New_" + h;
            bool finish = false;    //Флаг на проверку конца строчки
            FileStream fileStream1 = new FileStream(h, FileMode.Create, FileAccess.Write);
            string cod = "";     //Код
            char c = '0';
            while (!finish)
            {
                byte b = (byte)fileStream.ReadByte();
                form.workerDecod.ReportProgress((int)(fileStream.Position * 100 / fileStream.Length));     //Процесс декодирования
                do
                {
                    bitOperation.readbit(b, ref c);    //Считывание побитам
                    cod += c;
                    if (modelCodes.Find((x) => x.code == cod) != null)
                    {
                        if (modelCodes.Find(x => x.code == cod).symbol != null)
                        {
                            fileStream1.WriteByte((byte)modelCodes.Find(x => x.code == cod).symbol);
                            cod = "";
                        }
                        else finish = true;     //Конец закодированной строчки найден
                    }
                } while (bitOperation.bitNumber != 0);
            }
            fileStream1.Close();
            FileInfo fileInf1 = new FileInfo(h);
            end_size = fileInf1.Length;
        }
    }
}
