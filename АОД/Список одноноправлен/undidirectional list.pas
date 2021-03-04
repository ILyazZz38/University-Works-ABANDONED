//ОДНОНАПРАВЛЕННЫЙ СПИСОК//
type pListItem = ^TListItem; 
     TListItem = record
       info: string;
       next: pListItem;
     end;
     
     var
       pFirst:pListItem;
       z,y:integer;
       
function SearchA(key:integer):pListItem;
var pTemp:pListitem;
begin
  pTemp:=pFirst;
  while (pTemp<>nil)do
       if(pTemp^.info = key) then begin
         result:=pTemp;
         break
       end else 
       pTemp:=pTemp^.next;
end;  

function SearchB(key:integer):pListItem;
var pTemp,pPrev:pListitem;
begin
  pTemp:=pFirst;
  while (pTemp<>nil)do
       if(pTemp^.info = key) then begin
         pPrev:=pTemp;
         result:=pPrev;
         break
       end else 
       pTemp:=pTemp^.next;
end;        
       
procedure PushA(key, data:integer):boolean;
var pTemp,pNew:pListItem;
begin
  write('После какого элемента вставить:');
  pTemp:=SearchA(key);
  if (pTemp = nil) then result:=false
  else begin
    new(pNew);
    pNew^.inf:=data;
    pNew^.next:=pTemp^.next;
    pTemp^.next:=pNew;
    result:=true;
  end;
end;

procedure PushB(key, data:integer):boolean;
var pTemp,pNew:pListItem;
begin
  write('До какого элемента вставить:');
  pTemp:=SearchB(key);
  if (pTemp = nil) then result:=false
  else begin
    new(pNew);
    pNew^.inf:=data;
    pNew^.next:=pTemp^.next;
    pTemp^.next:=pNew;
    result:=true;
  end;
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