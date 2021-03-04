//СТЕК 2
type pStackItem = ^TStackItem; //
     TStackItem = record
       info: string;
       pred: pStackItem;
     end;
     
     var
       SP:pStackItem;
       pTemp:pStackItem;
       z,y:integer;
       
procedure Push();
begin
  New(pTemp);
  writeln('Введите значение:');
  readln(pTemp^.info);
  pTemp^.pred := SP;
  SP:=pTemp;
end;

procedure Pop ();
begin
  if SP = nil then begin 
    writeln('Стек пуст');
  end else begin
  pTemp:=SP;
  SP:=pTemp^.pred;
  Dispose(pTemp);
  end;
end;

procedure show();
begin
pTemp:=SP;
while (pTemp <> nil) do begin
  writeln(pTemp^.info);
  pTemp:=pTemp^.pred;
end;
end;




begin
  repeat
    writeln('Добро пожаловать в программу стек. Тут делается стек.');
    writeln();
    writeln('1:Добавить в стек');
    writeln('2:Удалить из стека');
    writeln('3:Вывести стек');
    writeln('4:Закрыть программу');
    writeln();
    write('Ваше действие:');

    readln(z);
    
    case z of
      1:begin
        push;
        end;
      2:pop;
      3:show;
      4:y:=1;
  end;
  
  until y = 1;
end.