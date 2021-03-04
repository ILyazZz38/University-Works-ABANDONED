//ОЧЕРЕДЬ 2
type pQueueItem = ^TQueueItem; //
     TQueueItem = record
       info: string;
       next: pQueueItem;
     end;
     
     var
       pFirst,pTemp, pLast:pQueueItem;
       z,y:integer;
       
procedure PushF();
begin
  New(pLast);
  writeln('Введите значение:');
  readln(pLast^.info);
  pLast^.next := nil;
  pFirst:=pLast;
end;

procedure PushL();
begin
  New(pTemp);
  writeln('Введите значение:');
  readln(pTemp^.info);
  pTemp^.next := nil;
  pLast^.next:=pTemp;
  pLast:=pTemp;
end;

procedure Pop ();
begin
  if (pFirst = nil) and (pLast = nil) then begin 
    writeln('Очередь пуста');
  end else begin
  pTemp:=pFirst;
  pFirst:=pTemp^.next;
  Dispose(pTemp);
  end;
end;

procedure show();
begin
pTemp:=pFirst;
while (pTemp <> nil) do begin
  writeln(pTemp^.info);
  pTemp:=pTemp^.next;
end;
end;




begin
  repeat
    writeln('Добро пожаловать в программу очередь. Тут делается очередь.');
    writeln();
    writeln('1:Добавить первый элемент в очередь');
    writeln('2:Добавить элемент в непустую очередь');
    writeln('3:Удалить из очереди');
    writeln('4:Вывести очередь');
    writeln('5:Закрыть программу');
    writeln();
    write('Ваше действие:');

    readln(z);
    
    case z of
      1:pushF;
      2:pushL;
      3:pop;
      4:show;
      5:y:=1;
  end;
  
  until y = 1;
end.