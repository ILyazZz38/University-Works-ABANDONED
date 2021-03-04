var
a : array[1..5] of integer;
size,x,i,z,y:integer;

procedure push(c :integer);
begin
if size <= 5 then begin
  a[size] := c;
size := size + 1;
end
else begin
writeln('Стек заполнен');
  end;
end;

procedure pop;
begin
  if size = 1 then begin
    writeln('Нечего удалять');
  end
  else begin
size := size - 1;
a[size]:=0;
end;
end;

function top : integer;
begin
top := a[size];
end;

procedure stack;
var i:integer;
begin
  for i:=1 to size-1 do
    writeln(a[i]);
end;

begin
  size := 1;
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
        readln(x);
        push(x);
        end;
      2:pop;
      3:stack;
      4:y:=1;
  end;
  
  until y = 1;
end.