internal class Program
{
    static void Main(string[] args)
    {
       // publisher state= new publisher();
        client Tom = new client(1,"Tom");
        int[] mas = new int[50];
        mas[0] =1;
        
        Tom.subscribe();
        Tom.unsubscribe();
        Tom.notifySubscribers();
        Tom.mainBusinessLogic();

    }
   
    public class client
    {
        public client(int id,string name)
        {
            ID= id;
            Name = name;
        }

        private int _id = 1 ;
        public int ID
        { 
            get { return _id ; }
            set { if (value < 1)
                { Console.WriteLine("Ошибка"); }
                    else _id = value ; }
        }
        private string _name = "NULL";
        public string Name
        {
            get { return _name ; }
            set { _name = value ; }
        }
        public void subscribe()
        {
            Console.WriteLine("Новый подпищик");
        }
        public void unsubscribe()
        {
            Console.WriteLine("Потеря подпищика");
        }
        public void notifySubscribers()
        {
            Console.WriteLine("Сообщение отправлено подпищика");
        }
        public void mainBusinessLogic()
        {
            Console.WriteLine("открытие логов");
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
}