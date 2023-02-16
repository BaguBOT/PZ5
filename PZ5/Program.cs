internal class Program
{
    static void Main(string[] args)
    {
        // publisher state= new publisher();
        client Tom = new client(1, "Tom");
        int[] mas = new int[50];
        mas[0] = 1;

        Tom.subscribe();
        //Tom.unsubscribe();
        Tom.notifySubscribers();
       string text= Console.ReadLine();
        if(text == "update")
        {
            Message hello = new Message("обновление базы");
            hello.Print();
        }
        publisher pub = new publisher();
        pub.Mainstate = new string[50];
        Console.ReadKey();
    }
    interface Isubcriber
    {
        string Text { get; set; }
    }
    interface IPrint
    {
        void Print();
    }
    class Message : Isubcriber, IPrint
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
        public void Print() => Console.WriteLine(Text);
    }
}
    public class client
    {
        public client(int id, string name)
        {
            ID = id;
            Name = name;
        }

        private int _id = 1;
        public int ID
        {
            get { return _id; }
            set { if (value < 1)
                { Console.WriteLine("Ошибка"); }
                else _id = value; }
        }
        private string _name = "NULL";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        void Example(params string[] names)
        {
            Example("feewf", "fewfe", "fewfew");
        }
        public void subscribe()
        {
            //При подписки нового подпищика, системному аднимистратора высылается собщение 
            Console.WriteLine("Новый подпищик");

        }
        public void unsubscribe()
        {
            //При потери подпищика, системному аднимистратора высылается собщение 
            Console.WriteLine("Потеря подпищика");

        }
        public string meseage;
        
        public void notifySubscribers()
        {
            // При вызове метода сообщение подпищекам. Просит сначало написать текст потом отправляет его всем подпищикам. 
            Console.WriteLine("Отправить сообщение подпищику");
            meseage = Console.ReadLine();
            Console.WriteLine("Сообщение отправлено подпищика");
    
      
        }

        
        public void mainBusinessLogic()
        {
        //При вызове команды посмотр логов отображает последние логи приложения 
            Console.WriteLine("открытие логов"/*тут либо массив, либо лист */);
        }
    }
    public class publisher
    { 
            
    
    private string[] _mainstate ;
             public string[] Mainstate
              {


                 get { return _mainstate ; }
                    set { _mainstate = value ; }
                  }

           
    }
