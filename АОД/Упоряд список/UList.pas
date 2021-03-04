program project1;

Type
  Ukazatel = ^S;
  S = Record
       Data : integer;
       Next : Ukazatel ;
  End;

var
  Head, x, p: Ukazatel;
  menu, ainf, n: integer;
  
 Procedure SearchAndPush(Digit : integer);
Var
  dx, px, x : Ukazatel ;
Begin
  New(x);
  x^.Data := Digit;
  x^.Next := Nil;
  if Head = Nil
    then {Если список пуст, то вставляем первый элемент}
      Head := x
    else
    {Если список не пуст, то просматриваем его до тех пор, пока не отыщется подходящее место для x^ или не закончится список}
      Begin
        dx := Head;
        px := Head;
        while (px<>Nil) and (px^.Data<=Digit) do
          Begin
            dx := px;
            px :=px^.Next;
          End;
        if px=Nil
          then {Пройден весь список}
            dx^.Next := x {Элемент добавляется в конец списка}
          else {Пройден не весь список}
            Begin
              x^.Next := px;
                if px=Head
                  then
                    Head := x {Вставляем в начало списка}
                  else
                    dx^.Next := x; {Вставляем внутрь списка}
            End;
      End;
End;
  
Procedure Del(Gigit : integer);
Var
  x, dx, y,u : UKAZATEL ;
Begin
  x := Head;
  while x<>Nil do
    if x^.Data=Gigit
      then
        Begin
          if x=y
            then
              Begin
                Head := Head^.Next;
                Dispose(x);
                x := Head;
              End
            else
              Begin
                dx^.Next := x^.Next;
                Dispose(x);
                x := dx^.Next;
              End;
        End
      else
        Begin
          dx := x;
          x := x^.Next;
        End;
End;
  
    procedure Print;
  begin
    writeln;
    p:=Head;
    if Head = nil then
      write('Список пуст')
    else
    begin
      while p<>nil do
Begin
  Write(p^.Data, ' ');
  p := p^.Next;
End
    end;
    writeln;
  end;

begin
  new(Head);
  Head := nil;
  repeat
    writeln();
    writeln('Добро пожаловать в программу упорядоченный список. Тут делается упорядоченный список.');
    writeln();

    
    writeln('1. Добавление элемента');
    writeln('2. Удаление элемента ');
    writeln('3. Вывод списка');
    writeln('4. Выход');
    writeln();
    write('Введите значение: ');
    readln(menu);
    case menu of
      1:begin 
          write('Введите значение добавляемого элемента: ');
          readln(n);
          SearchAndPush(n);
          end;
      2: begin 
          write('Введите значение удаляемого элемента: ');
          readln(n);
          Del(n);
          end;
      3: print;
    end;
  until menu = 4;
end.                                               