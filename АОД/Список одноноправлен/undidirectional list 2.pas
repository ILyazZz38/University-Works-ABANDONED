program project1;

type
  pListItem = ^TListItem;

  TListItem = record
    info: integer;
    Next: pListItem;
  end;

var
  pFirst, pTemp, pNew, pPrev: pListItem;
  menu, ainf, n: integer;

  procedure Print;
  begin
    writeln;
    if pFirst^.Next = nil then
      write('Список пуст')
    else
    begin
      pTemp := pFirst^.Next;
      while pTemp <> nil do
      begin
        writeln(pTemp^.info);
        pTemp := pTemp^.Next;
      end;
    end;
    writeln;writeln;
  end;

procedure ExitFromSearch;
begin
  writeln;
  if pFirst^.Next = nil then
    write('Cписок пуст')
  else
  begin
    pTemp := pFirst^.Next;
    write('Введите значение для поиска: ');
    while pTemp <> nil do
    begin
      write(pTemp^.info, ' ');
      pTemp := pTemp^.Next;
    end;
  end;
  writeln;
  writeln;
end;

  function Search(ainf: integer): pListItem;
  begin
    if pFirst^.Next = nil then
      writeln('Список пуст')
    else
    begin
      pTemp := pFirst^.Next;
      while (pTemp <> nil) do
      begin
        if (pTemp^.info = ainf) then
        begin
          Result := pTemp;
          break;
        end
        else
        begin
          pTemp := pTemp^.Next;
          Result := nil;
        end;
      end;
    end;
  end;

  function Search2(ainf: integer): pListItem;
  begin
    if pFirst^.Next = nil then
      writeln('Список пуст')
    else
    begin
      pTemp := pFirst^.Next;
      pPrev := pFirst;
      while (pTemp <> nil) do
        if (pTemp^.info = ainf) then
        begin
          Result := pPrev;
          break;
        end
        else
        begin
          pTemp := pTemp^.Next;
          pPrev := pPrev^.Next;
          Result := nil;
        end;
    end;
  end;
  
  procedure PushF;
  begin
    if pFirst^.Next = nil then begin
    write('Введите значение добавляемого элемента: ');readln(n);
      pTemp := pFirst;
      new(pNew);
      pNew^.info := n;
      pNew^.Next := pTemp^.Next;
      pTemp^.Next := pNew
  end else
    writeln('Первый элемент существует');
    end;

  procedure PushA;
  begin
    WriteLn;
      write('Введите значение после какого нужно добавить элемент: ');readln(ainf);
      pTemp := Search(ainf);
      if (pTemp <> nil) then
      begin
        write('Введите значение добавляемого элемента: ');readln(n);
        new(pNew);
        pNew^.info := n;
        pNew^.Next := pTemp^.Next;
        pTemp^.Next := pNew;
      end
      else
        writeln('Элемент не найден');
    WriteLn;
  end;

  procedure PushB;
  begin
    WriteLn;
      write('Введите значение до которого нужно добавить элемент: ');readln(ainf);
      pTemp := Search(ainf);
      pPrev := Search2(ainf);
      if (pTemp <> nil) then
      begin
        write('Введите значение добавляемого элемента: ');readln(n);
        new(pNew);
        pNew^.info := n;
        pNew^.Next := pTemp;
        pPrev^.Next := pNew;
      end
      else
        writeln('Элемент не найден');
    WriteLn;
  end;

  procedure pop;
  begin
    WriteLn;
    if pFirst^.Next = nil then
      writeln('Список пуст')
    else
    begin
      write('Введите значение для поиска: ');readln(ainf);
      pTemp := Search(ainf);
      pPrev := Search2(ainf);
      if pTemp <> nil then
      begin
        pPrev^.Next := pTemp^.Next;
        dispose(pTemp);
      end
      else
        writeln('Элемент отсутсвует');
    end;
    WriteLn;
  end;

begin
  new(pFirst);
  pFirst^.Next := nil;
  repeat
    writeln();
    writeln('Добро пожаловать в программу однонаправленный список. Тут делается однонаправленный список.');
    writeln();

    
    writeln('1. Добавление первого элемента');
    writeln('2. Добавление элемента ПОСЛЕ');
    writeln('3. Добавление элемента ДО');
    writeln('4. Удаление элемента ');
    writeln('5. Вывод списка');
    writeln('6. Выход');
    writeln();
    write('Введите значение: ');
    readln(menu);
    case menu of
      1: PushF;
      2: PushA;
      3: PushB;
      4: pop;
      5: print;
    end;
  until menu = 6;
end.                                                                          