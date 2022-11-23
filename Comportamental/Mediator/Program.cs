
     ConcreteMediador ConcreteMediador = new ConcreteMediador(); // Implementação concreta do Mediator
     /*
          Todos os colegas recebem o mesmo mediator
     */
     Colleague1 colleague1 = new Colleague1 (ConcreteMediador);  
     Colleague2 colleague2 = new Colleague2 (ConcreteMediador); 
     Colleague3 colleague3 = new Colleague3 (ConcreteMediador); 

     ConcreteMediador.colleague1 = colleague1;
     ConcreteMediador.colleague2 = colleague2;
     ConcreteMediador.colleague3 = colleague3;
     
     Console.WriteLine("colleague 1");
     colleague1.SendMensage();
     Console.WriteLine();
     Console.WriteLine("colleague 2");
     colleague2.SendMensage();
     Console.WriteLine();
     Console.WriteLine("colleague 3");
     colleague3.SendMensage();