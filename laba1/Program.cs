using laba1;


//задание 2

void task2()
{
    

    var item1 = new TimeEuro();
    Console.WriteLine(item1.ShowTime());

    var timeDecorator = new TimeEuroDecorator(item1);
    Console.WriteLine(timeDecorator.ShowTime());


    var item2 = new TimeUSA();
    Console.WriteLine(item2.ShowTime());

    var timeUSDEC = new TimeUSADecorator(item2);
    Console.WriteLine(timeUSDEC.ShowTime());
}

//задание 3

void task3()
{
    Node begin = new Node("Ручка");
    Node node1 = new Node("Колпачек");
    Node node2 = new Node("Стержень");
    Node node3 = new Node("Корпус");
    Node node4 = new Node("Нижняя часть");
    Node node5 = new Node("Верзняя часть");
    Node node6 = new Node("Паста");
    Node node7 = new Node("Трубочка");
    Node node8 = new Node("Химикаты");

    begin.NewChild(node1);
    begin.NewChild(node2);
    begin.NewChild(node3);
    node3.NewChild(node4);
    node3.NewChild(node5);
    node2.NewChild(node6);
    node2.NewChild(node7);
    node6.NewChild(node8);

    begin.ShowTree();
}