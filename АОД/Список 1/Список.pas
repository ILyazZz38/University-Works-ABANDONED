type
point= ^list;

list= record
info: integer;
next: point;
end;

var:phead,q,p:point;

procedure add(var t:point);
var y: point;
i:integer;
begin
  new(y);
  readln(i);
  y^.info := i;
  y^.next = t;
  t:= y;
end;


begin
  addHead(phead);
  
  1:=pHead;
  while (q()nil) do
  begin
    writeln(q^.info);
    q:= q^.next;
  end;
  readln;
end.