program project1;



type
pSTreeNode = ^TSTreeNode;
TSTreeNode = record
  info:string;
  key:integer;
  left:pSTreeNode;
  right:pSTreeNode;
end;



var
  pRoot,pPar:pSTreeNode;
  str:string;
  menu,inf,l:integer;



procedure InOrder(pCurrent:pSTreeNode; x:byte);
begin
  x:=x+5;
  if pCurrent^.left <> nil then
    InOrder(pCurrent^.left, x);
    writeln(pCurrent^.key:x);
  if pCurrent^.right <> nil then 
    InOrder(pCurrent^.right, x);
end;

procedure PostOrder(pCurrent:pSTreeNode; x:byte);
begin
  x:=x+5;
  if pCurrent^.left<>nil then PostOrder(pCurrent^.left, x);
  if pCurrent^.right<>nil then PostOrder(pCurrent^.right, x);
  writeln(pCurrent^.key:x);
end;

procedure PreOrder(pCurrent:pSTreeNode; x:byte);
begin
  x:=x+5;
  writeln(pCurrent^.key:x);
  if pCurrent^.left <> nil then PreOrder(pCurrent^.left, x);
  if pCurrent^.right <> nil then PreOrder(pCurrent^.right, x);
end;

function Search(akey:integer):pStreeNode;
var pCurr:pSTreeNode;
begin
  pCurr:=pRoot;
  result:=nil;
  while(pCurr<>nil)do
    if (akey=pCurr^.key)then begin
      result:=pCurr;
      break
    end else
      if(akey <pCurr^.key)then begin
        pPar :=pCurr;
        pCurr:=pCurr^.left;
      end else begin
        pPar:=pCurr;
        pCurr:=pCurr^.right;
        end;
end;

procedure AddNode(var pCurr:pSTreeNode; akey:integer);
begin
  if (pCurr=nil) then
  begin
    New(pCurr);
    pCurr^.key := akey;
    pCurr^.info:=str;
    pCurr^.left :=nil;
    pCurr^.right :=nil;
  end else if
  (akey < pCurr^.key) then 
    AddNode(pCurr^.left, akey)
  else if (akey > pCurr^.key) then AddNode(pCurr^.right, akey)
  else if (akey = pCurr^.key) then writeln('Такое значение есть в дереве');
end;

procedure Del(akey:integer);
var
    pRTemp, pLTemp: pSTreeNode;
    LR, nKey, dKey: integer;
    begin
      if (Search(akey)^.key <> 0) then
      begin
        if (pRoot^.left = nil) and (pRoot^.right = nil) then
        begin
          WriteLn;
        WriteLn('Вершина терминальная, удаляю.');
        WriteLn('Родителем является: ', pPar^.key);
        pRoot := nil;
        WriteLn('Успешно удалено.');
        WriteLn;
      end else if (pRoot^.left = nil) or (pRoot^.right = nil) then
        begin
          WriteLn;
        WriteLn('У вершины есть один потомок, удаляю безопасным методом.');
        WriteLn('Родителем является: ', pPar^.key);
        if (pRoot^.left = nil) then
        begin
          pPar^.right := pRoot^.right;
        end;
        if (pRoot^.right = nil) then
        begin
          pPar^.left := pRoot^.left;
        end;
        WriteLn('Успешно удалено.');
        WriteLn;
      end
        end;
      end;
   // end;



begin
  repeat
    writeln();
    writeln('Welcome to the TREE zone.');
    writeln('Only trees inside enemy programs.');
    writeln('Quivering leaves, double join to root.');
    writeln('Fresh leaves. elegant end of program');
    writeln('first the search. then the Add.');
    writeln();

    
    writeln('1. Добавление элемента в дерево');
    writeln('2. Прямой обход с выводом');
    writeln('3. Обратный обход с выводом');
    writeln('4. Семетричный обход с выводом');
    writeln('5. Удаление элемента из дерева');
    writeln('6. Поиск элемента из дерева');
    writeln('7. Выход');
    writeln();
    write('Введите значение: ');
    readln(menu);
    case menu of
      1: begin 
         write('Какое число добавить:');
         readln(inf);
         AddNode(pRoot,inf);
         end;
      2: PreOrder(pRoot, l);
      3: PostOrder(pRoot, l);
      4: InOrder(pRoot,l);
      5: begin 
        write('Какое число удалить:');
         readln(inf);
      Del(inf);
      end;
      6:begin
      write('Какое число найти:');
         readln(inf);
         Search(inf);
         end;
      end;
  until menu = 7;
end.