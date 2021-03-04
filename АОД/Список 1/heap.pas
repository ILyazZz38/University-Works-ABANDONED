var
arr : array[1..5] of integer;
count,x,i,z,y:integer;

procedure push(c :integer);
begin
arr[1]:=c;
count:=count+1;
end;

procedure pushB();
var i,x,c,b:integer;
begin
if count = 5 then begin
  writeln('Список заполнен')
end else begin
  write('Какое число добавить:');
  readln(c);
  write('Перед каким числом добавить:');
  readln(b);
  for i:= 1 to 5 do begin
    if b = arr[i] then begin
          for x:= count downto i do begin
            arr[x+1]:=arr[x];
            //arr[x]:=0;
            end;
            arr[i]:=c;
            count:= count+1;
            break;
          end;
        end;
      end;
end;




procedure pushA();
var a,i,x,c:integer;
begin
if count = 5 then begin
  writeln('Список заполнен')
end else begin
  write('Какое число добавить:');
  readln(c);
  write('После какого числа добавить:');
  readln(a);
  for i:= 1 to 5 do begin
    if a = arr[i] then begin
          for x:= count downto i+1 do begin
            arr[x+1]:=arr[x];
            arr[x]:=0;
            end;
            arr[i+1]:=c;
            count:=count+1;
          end;
        end;
      end;
end;




procedure pop();
var p,x,i:integer;
begin
  if count = 0 then begin
    writeln('Нечего удалять');
  end
  else if count = 1 then begin
    arr[count] := 0;
    count:= count - 1;
    end else begin
      write('Какой элемент удалить:');
      readln(p);
      for i:= 1 to count do begin
        if p = arr[i] then begin
          arr[i]:=0;
          for x:=i+1 to count do begin
            arr[x-1]:=arr[x];
            arr[x]:=0;
          end;
        end
      end;
      count:= count -1;
    end
end;

function top : integer;
begin
top := arr[count];
end;

procedure queue;
var i:integer;
begin
  for i:= 1 to count do
    writeln(arr[i])
end;

begin
  count := 0;
  for i:= 1 to 5 do
    arr[i]:=0;
  repeat
    writeln('Добро пожаловать в программу список. Тут делается список.');
    writeln();
    writeln('1:Добавить первый элемент в список');
    writeln('2:Добавить перед');
    writeln('3:Добавить после');
    writeln('4:Удалить из списка');
    writeln('5:Вывести список');
    writeln('6:Закрыть программу');
    writeln();
    write('Ваше действие:');

    readln(z);
    
    case z of
      1:begin write('Первый элемент:');
      readln(x);
      push(x);
      end;
      2:pushB;
      3:pushA;
      4:pop;
      5:queue;
      6:y:=1;
  end;
  
  until y = 1;
end.