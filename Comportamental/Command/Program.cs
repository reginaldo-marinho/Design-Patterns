
Invoker invoker = new Invoker(new SaveCommand(new BaseCommandAPiReceiver()));
invoker.ExecCommand();

invoker = new Invoker(new AlterCommand(new BaseCommandAPiReceiver()));
invoker.ExecCommand();

invoker = new Invoker(new DeleteCommand(new BaseCommandAPiReceiver()));
invoker.ExecCommand();


